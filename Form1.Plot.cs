using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.Reflection;


namespace SerialTerminal {
	public partial class Form1 {
		ChartArea chartArea = new ChartArea();
		Series series1 = new Series();
		Series series2 = new Series();
		Series series3 = new Series();
		int xRangeNum;
		int[] x;
		double[] y1, y2, y3;

		private Regex plotre1, plotre2, plotre3;

		// --------------------------
		private void InitPlot() {
		// --------------------------
			chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
			chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
			chartArea.AxisX.LabelStyle.Font = new Font("Consolas", 6);
			chartArea.AxisY.LabelStyle.Font = new Font("Consolas", 6);
			chartArea.AxisX.Minimum = 0;
			chart1.ChartAreas.Add(chartArea);

			series1.ChartType = SeriesChartType.FastLine;
			series1.XValueType = ChartValueType.Int32;
			series1.YValueType = ChartValueType.Double;
			series1.Color = Color.Maroon;
			chart1.Series.Add(series1);

			series2.ChartType = SeriesChartType.FastLine;
			series2.XValueType = ChartValueType.Int32;
			series2.YValueType = ChartValueType.Double;
			series2.Color = Color.Navy;
			chart1.Series.Add(series2);

			series3.ChartType = SeriesChartType.FastLine;
			series3.XValueType = ChartValueType.Int32;
			series3.YValueType = ChartValueType.Double;
			series3.Color = Color.Green;
			chart1.Series.Add(series3);

			scaleXRange();
			chart1.Invalidate();
		}


		// --------------------------
		private void clearPlot() {
		// --------------------------
			plotInputDisplay.Text = "";
			plotValue1.Text = "";
			plotValue2.Text = "";
			plotValue3.Text = "";
			scaleXRange();
		}


		// --------------------------
		private void plotMessage(String strLine) {
		// --------------------------
			plotInputDisplay.Text = strLine;
			try {
				matchAndPlot(strLine, plotre1, plotValue1, series1, y1);
				matchAndPlot(strLine, plotre2, plotValue2, series2, y2);
				matchAndPlot(strLine, plotre3, plotValue3, series3, y3);
			}
			catch {
				error("Error applying Regex highlighting");
			}
		}



		// --------------------------
		private void matchAndPlot(String text, Regex re, Label lbl, Series ser, double[] y) {
		// --------------------------
			lbl.Text = "";

			if (re != null) {
				Match m = re.Match(text);

				if (m.Success) {
					Group g = m.Groups[1];
					lbl.Text = g.Value;

					try {
						double value = Double.Parse(g.Value);
						// shift the line
						for (int i = 0; i < xRangeNum - 1; i++)
							y[i] = y[i + 1];

						// add the new point
						y[xRangeNum - 1] = value;
						ser.Points.DataBindXY(x, y);
					}
					catch { };
				}
			}
		}



		// --------------------------
		private void updatePlotRegex(object sender, EventArgs e) {
		// --------------------------
			updatePlotRegexImpl();
		}


		// --------------------------
		private void updatePlotRegexImpl() {
		// --------------------------
			if(plotRegex1.Text != "") {
				try {	        
					plotre1 = new Regex(plotRegex1.Text);
					plotRegex1.BackColor = default(Color);
				}
				catch {
					plotre1 = null;
					plotRegex1.BackColor = Color.LightPink;
				}
			}
			else
				plotre1 = null;


			if (plotRegex2.Text != "") {
				try {
					plotre2 = new Regex(plotRegex2.Text);
					plotRegex2.BackColor = default(Color);
				}
				catch {
					plotre2 = null;
					plotRegex2.BackColor = Color.LightPink;
				}
			}
			else
				plotre2 = null;

			if (plotRegex3.Text != "") {
				try {
					plotre3 = new Regex(plotRegex3.Text);
					plotRegex3.BackColor = default(Color);
				}
				catch {
					plotre3 = null;
					plotRegex3.BackColor = Color.LightPink;
				}
			}
			else
				plotre3 = null;
		}




		#region ChartRange

		// --------------------------
		private void yMaxText_KeyDown(object sender, KeyEventArgs e) {
		// --------------------------
			if (e.KeyCode == Keys.Enter) {
				e.Handled = true;
				e.SuppressKeyPress = true;
				scaleChartRange();
			}
		}

		// --------------------------
		private void yMinText_KeyDown(object sender, KeyEventArgs e) {
		// --------------------------
			if (e.KeyCode == Keys.Enter) {
				e.Handled = true;
				e.SuppressKeyPress = true;
				scaleChartRange();
			}
		}

		// --------------------------
		private void xRange_KeyDown(object sender, KeyEventArgs e) {
		// --------------------------
			if (e.KeyCode == Keys.Enter) {
				e.Handled = true;
				e.SuppressKeyPress = true;
				scaleXRange();
			}
		}


		// --------------------------
		private void yMaxText_Leave(object sender, EventArgs e) {
		// --------------------------
			scaleChartRange();
		}

		// --------------------------
		private void yMinText_Leave(object sender, EventArgs e) {
		// --------------------------
			scaleChartRange();
		}

		// --------------------------
		private void xRange_Leave(object sender, EventArgs e) {
		// --------------------------
			scaleXRange();
		}


		// --------------------------
		private void scaleChartRange() {
		// --------------------------
			chartArea.AxisY.Maximum = Double.NaN;
			chartArea.AxisY.Minimum = Double.NaN;

			try {
				chartArea.AxisY.Maximum = Int32.Parse(yMaxText.Text);
			}
			catch { };

			try {
				chartArea.AxisY.Minimum = Int32.Parse(yMinText.Text);
			}
			catch { };

			try {
				chartArea.RecalculateAxesScale();
			}
			catch {
				error("Error: Y Min range higher than Max range");
				chartArea.AxisY.Minimum = Double.NaN;
				chartArea.RecalculateAxesScale();
			};
		}



		// --------------------------
		private void scaleXRange() {
		// --------------------------
			try {
				xRangeNum = Int32.Parse(xRange.Text);
			}
			catch {
				xRangeNum = 20;
			}

			chartArea.AxisX.Maximum = xRangeNum;

			x = new int[xRangeNum];
			y1 = new double[xRangeNum];
			y2 = new double[xRangeNum];
			y3 = new double[xRangeNum];

			for (int i = 0; i < xRangeNum; i++) {
				x[i] = i;
			}

			series1.Points.DataBindXY(x, y1);
			series2.Points.DataBindXY(x, y2);
			series3.Points.DataBindXY(x, y3);
			chart1.Invalidate();
		}


		#endregion
	}
}