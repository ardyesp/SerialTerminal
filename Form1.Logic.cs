using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.Reflection;


namespace SerialTerminal {
	public partial class Form1 {

		#region OpenCloseSerial


		// --------------------------
		private bool OpenComPort() {
		// --------------------------
			string port = SerialPortsSel.Text;
			string baudRate = BaudratesSel.Text;

			// verify the correct port/baud rate
			if (port == "") {
				error("Invalid COM port");
				return false;
			}

			int intBaud;
			bool isNumeric = int.TryParse(baudRate, out intBaud);

			if(!isNumeric) {
				error("Invalid baud rate");
				return false;
			}

			try {
				// set and try to open the COM port
				log("Opening port...");
				comPort = new SerialPort(port, intBaud);
				setLineEndings();
				comPort.RtsEnable = true;
				comPort.DtrEnable = dtr.Checked;
				comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
				comPort.ReadTimeout = 500;
				comPort.Open();
				log(port + " open");
				
				// start a port monitoring thread
				(new System.Threading.Thread(() => {
					int bufLevel = 0;
					int maxBuffer = 50000;
					try {
						while (comPort.IsOpen) {
							bufLevel = comPort.BytesToRead;
							System.Threading.Thread.Sleep(500);
							this.Invoke(new Action<int>(setBufferLevel), new object[] { (bufLevel * 100 / maxBuffer) });
							if (globalHighlightEnabled && (bufLevel > maxBuffer)) {
								globalHighlightEnabled = false;
								this.Invoke(new Action<string>(error), new object[] { "Too much data backlog, disabling highlighting" });
								this.Invoke(new Action<bool>(changeHighlight), new object[] { globalHighlightEnabled });
							}
						}
						// port closed
						this.Invoke(new Action(() => { openClose.CheckState = CheckState.Unchecked; }));
					}
					catch {
						try { comPort.Close(); } catch { }
					}

				})).Start();

				return true;
			}
			catch(Exception excp) {
				error("Unable to open Serial: " + excp.Message);
				try { comPort.Close(); } catch { }
				return false;
			}
		}

		
		// --------------------------
		private void CloseComPort() {
		// --------------------------
			try {
				log("Closing COM port...");

				(new System.Threading.Thread(() => {
					comPort.Close();
					this.Invoke(new Action<string>(log), new object[] { "Port closed" });
					System.Threading.Thread.Sleep(600);
					this.Invoke(new Action<int>(setBufferLevel), new object[] { 0 });
				})).Start();

			}
			catch (Exception excp) {
				error("Unable to close Serial: " + excp.Message);
			}
		}


		#endregion


		#region Logging

		// --------------------------
		private void inject(string message) {
		// --------------------------
			rxDataTextBox.SelectionBackColor = Color.DarkSlateGray;
			rxDataTextBox.SelectionColor = Color.White;
			
			if (autoscroll.Checked) {
				rxDataTextBox.AppendText(message + "\r\n");
				rxDataTextBox.SelectionStart = rxDataTextBox.Text.Length;
				rxDataTextBox.ScrollToCaret();
			}
			else {
				rxDataTextBox.AppendText(message + "\r\n");
			}
		}


		// --------------------------
		private void log(string message) {
		// --------------------------
			logLabel.ForeColor = default(Color);
			logLabel.Text = message;
		}


		// --------------------------
		private void error(string message) {
		// --------------------------
			logLabel.ForeColor = Color.Red;
			logLabel.Text = message;
			logLabel.ToolTipText += "ERROR: " + message + "\r\n";
			System.Media.SystemSounds.Beep.Play();
		}


		// --------------------------
		private void setBufferLevel(int percent) {
		// --------------------------
			if (percent > 100)
				percent = 100;
			rxBufferBar.Value = percent;
		}

		#endregion


		#region SerialDataTx

		// --------------------------
		private void txData() {
		// --------------------------
			string Data = txBox.Text;
			try {
				switch (lineEndingBox.Text) {
					case "None":
						comPort.Write(Data);
						break;
					case "CR":
						comPort.Write(Data + "\r");
						break;
					case "LF":
						comPort.Write(Data + "\n");
						break;
					case "CR/LF":
						comPort.Write(Data + "\r\n");
						break;
				}

				inject("SENT: " + Data);

				// append Data to the list, only if user typed it in
				if (newTxItem) {
					int cIdx = txBox.Items.Add(Data);
					txBox.SelectedIndex = cIdx;
				}
			}
			catch (Exception excp) {
				error("Unable to send data: " + excp.Message);
				try { comPort.Close(); }
				catch { }
			}
		}



		// --------------------------
		private void setLineEndings() {
		// --------------------------
			if (comPort != null) {
				switch (lineEndingBox.Text) {
					case "CR":
						comPort.NewLine = "\r";
						break;
					case "LF":
						comPort.NewLine = "\n";
						break;
					case "CR/LF":
						comPort.NewLine = "\r\n";
						break;
				}
			}
		}

		#endregion


		#region SerialDataRx

		// --------------------------
		private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e) {
		// --------------------------
			this.Invoke(new Action(ProcessPrintSerialData), new object[] { });
		}


		// --------------------------
		public void ProcessPrintSerialData() {
		// --------------------------
			try {
				try {
					int numBytesInBuf = comPort.BytesToRead;
					while ((numBytesInBuf > 0) && comPort.IsOpen) {
						String strLine = comPort.ReadLine();
						numBytesInBuf -= (strLine.Length + comPort.NewLine.Length);
						// apply the highlight filters if asked for
						if (globalHighlightEnabled)
							applyFilters(strLine);
						else
							rxDataTextBox.AppendText(strLine + Environment.NewLine);
					}
				}
				catch (TimeoutException) {
					if (comPort.IsOpen && (comPort.BytesToRead > 0))
						rxDataTextBox.AppendText(comPort.ReadExisting());
					return;
				}
				catch (Exception ex) {
					error("Error applying Regex highlighting");
					System.Console.WriteLine(ex.ToString());
				}


				if (autoscroll.Checked) {
					rxDataTextBox.HideSelection = false;
					rxDataTextBox.SelectionStart = rxDataTextBox.Text.Length;
					rxDataTextBox.ScrollToCaret();
				}
			}
			catch { }
		}



		// --------------------------
		private void applyFilters(string text) {
		// --------------------------
			for (int index = 0; index < numControls; index++) {
				if (groupHighlightEnabled[index]) {
					Match m = regex[index].Match(text);

					if (m.Success) {
						int curIdx = 0;
						while (m.Success) {
							// matching one group only
							Group g = m.Groups[1];
							rxDataTextBox.AppendText(text.Substring(curIdx, g.Index - curIdx));
							rxDataTextBox.SelectionColor = hgColors[index];
							rxDataTextBox.SelectionFont = hgFonts[index];
							rxDataTextBox.AppendText(g.Value);
							rxDataTextBox.SelectionColor = default(Color);
							rxDataTextBox.SelectionFont = defaultFont;
							curIdx = g.Index + g.Length;
							m = m.NextMatch();
						}

						rxDataTextBox.AppendText(text.Substring(curIdx, text.Length - curIdx));
						rxDataTextBox.AppendText(Environment.NewLine);
						return;
					}
				}
			}

			// no match occoured, just output the line
			rxDataTextBox.AppendText(text + Environment.NewLine);
		}

		#endregion		
		
		
	}
}