namespace SerialTerminal {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.BaudratesSel = new System.Windows.Forms.ComboBox();
			this.SerialPortsSel = new System.Windows.Forms.ComboBox();
			this.SendBtn = new System.Windows.Forms.Button();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.RefreshBtn = new System.Windows.Forms.Button();
			this.autoscroll = new System.Windows.Forms.CheckBox();
			this.rxDataTextBox = new System.Windows.Forms.RichTextBox();
			this.CopyBtn = new System.Windows.Forms.Button();
			this.lineEndingBox = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Console = new System.Windows.Forms.TabPage();
			this.Highlight = new System.Windows.Forms.TabPage();
			this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.highlightedOutputBox = new System.Windows.Forms.RichTextBox();
			this.sampleInputBox = new System.Windows.Forms.TextBox();
			this.Plot = new System.Windows.Forms.TabPage();
			this.plotInputDisplay = new System.Windows.Forms.TextBox();
			this.xRange = new System.Windows.Forms.TextBox();
			this.yMinText = new System.Windows.Forms.TextBox();
			this.yMaxText = new System.Windows.Forms.TextBox();
			this.plotValue3 = new System.Windows.Forms.Label();
			this.plotValue2 = new System.Windows.Forms.Label();
			this.plotValue1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.plotRegex3 = new System.Windows.Forms.TextBox();
			this.plotRegex2 = new System.Windows.Forms.TextBox();
			this.plotRegex1 = new System.Windows.Forms.TextBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Instructions = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.logLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.rxBufferBar = new System.Windows.Forms.ToolStripProgressBar();
			this.txBox = new System.Windows.Forms.ComboBox();
			this.dtr = new System.Windows.Forms.CheckBox();
			this.openClose = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.Console.SuspendLayout();
			this.Highlight.SuspendLayout();
			this.Plot.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.Instructions.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BaudratesSel
			// 
			this.BaudratesSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BaudratesSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BaudratesSel.FormattingEnabled = true;
			this.BaudratesSel.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "256000",
            "512000",
            "921600"});
			this.BaudratesSel.Location = new System.Drawing.Point(140, 438);
			this.BaudratesSel.Name = "BaudratesSel";
			this.BaudratesSel.Size = new System.Drawing.Size(70, 24);
			this.BaudratesSel.TabIndex = 1;
			// 
			// SerialPortsSel
			// 
			this.SerialPortsSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SerialPortsSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SerialPortsSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SerialPortsSel.FormattingEnabled = true;
			this.SerialPortsSel.Location = new System.Drawing.Point(24, 439);
			this.SerialPortsSel.Name = "SerialPortsSel";
			this.SerialPortsSel.Size = new System.Drawing.Size(60, 21);
			this.SerialPortsSel.Sorted = true;
			this.SerialPortsSel.TabIndex = 0;
			// 
			// SendBtn
			// 
			this.SendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SendBtn.Enabled = false;
			this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SendBtn.Location = new System.Drawing.Point(455, 3);
			this.SendBtn.Name = "SendBtn";
			this.SendBtn.Size = new System.Drawing.Size(55, 23);
			this.SendBtn.TabIndex = 2;
			this.SendBtn.Text = "▶ Send";
			this.SendBtn.UseVisualStyleBackColor = true;
			this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
			// 
			// ClearBtn
			// 
			this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearBtn.Location = new System.Drawing.Point(57, 461);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(55, 23);
			this.ClearBtn.TabIndex = 5;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// RefreshBtn
			// 
			this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RefreshBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RefreshBtn.Location = new System.Drawing.Point(-1, 438);
			this.RefreshBtn.Name = "RefreshBtn";
			this.RefreshBtn.Size = new System.Drawing.Size(23, 23);
			this.RefreshBtn.TabIndex = 7;
			this.RefreshBtn.Text = "↺";
			this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.RefreshBtn.UseVisualStyleBackColor = true;
			this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
			// 
			// autoscroll
			// 
			this.autoscroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.autoscroll.AutoSize = true;
			this.autoscroll.Checked = true;
			this.autoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
			this.autoscroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.autoscroll.Location = new System.Drawing.Point(120, 466);
			this.autoscroll.Name = "autoscroll";
			this.autoscroll.Size = new System.Drawing.Size(72, 17);
			this.autoscroll.TabIndex = 8;
			this.autoscroll.Text = "Autoscroll";
			this.autoscroll.UseVisualStyleBackColor = true;
			// 
			// rxDataTextBox
			// 
			this.rxDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rxDataTextBox.DetectUrls = false;
			this.rxDataTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rxDataTextBox.Location = new System.Drawing.Point(0, 0);
			this.rxDataTextBox.Name = "rxDataTextBox";
			this.rxDataTextBox.ReadOnly = true;
			this.rxDataTextBox.Size = new System.Drawing.Size(506, 382);
			this.rxDataTextBox.TabIndex = 10;
			this.rxDataTextBox.Text = "";
			this.rxDataTextBox.WordWrap = false;
			// 
			// CopyBtn
			// 
			this.CopyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CopyBtn.Location = new System.Drawing.Point(0, 461);
			this.CopyBtn.Name = "CopyBtn";
			this.CopyBtn.Size = new System.Drawing.Size(55, 23);
			this.CopyBtn.TabIndex = 11;
			this.CopyBtn.Text = "Copy";
			this.CopyBtn.UseVisualStyleBackColor = true;
			this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
			// 
			// lineEndingBox
			// 
			this.lineEndingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lineEndingBox.FormattingEnabled = true;
			this.lineEndingBox.Items.AddRange(new object[] {
            "None",
            "CR",
            "LF",
            "CR/LF"});
			this.lineEndingBox.Location = new System.Drawing.Point(4, 4);
			this.lineEndingBox.Name = "lineEndingBox";
			this.lineEndingBox.Size = new System.Drawing.Size(55, 21);
			this.lineEndingBox.TabIndex = 13;
			this.lineEndingBox.SelectedIndexChanged += new System.EventHandler(this.lineEndingBox_SelectedIndexChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.Console);
			this.tabControl1.Controls.Add(this.Highlight);
			this.tabControl1.Controls.Add(this.Plot);
			this.tabControl1.Controls.Add(this.Instructions);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 30);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(7, 3);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(514, 408);
			this.tabControl1.TabIndex = 14;
			this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
			this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.highlightEnableDisable);
			// 
			// Console
			// 
			this.Console.Controls.Add(this.rxDataTextBox);
			this.Console.Location = new System.Drawing.Point(4, 22);
			this.Console.Name = "Console";
			this.Console.Padding = new System.Windows.Forms.Padding(3);
			this.Console.Size = new System.Drawing.Size(506, 382);
			this.Console.TabIndex = 0;
			this.Console.Text = "Console";
			this.Console.UseVisualStyleBackColor = true;
			// 
			// Highlight
			// 
			this.Highlight.BackColor = System.Drawing.Color.LightGray;
			this.Highlight.Controls.Add(this.layoutPanel);
			this.Highlight.Controls.Add(this.highlightedOutputBox);
			this.Highlight.Controls.Add(this.sampleInputBox);
			this.Highlight.Location = new System.Drawing.Point(4, 22);
			this.Highlight.Name = "Highlight";
			this.Highlight.Padding = new System.Windows.Forms.Padding(3);
			this.Highlight.Size = new System.Drawing.Size(506, 382);
			this.Highlight.TabIndex = 1;
			this.Highlight.Text = "Highlight";
			this.Highlight.ToolTipText = "Right click to Enable/Disable all RegEx highlights";
			this.Highlight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.highlightEnableDisable);
			// 
			// layoutPanel
			// 
			this.layoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.layoutPanel.BackColor = System.Drawing.Color.Transparent;
			this.layoutPanel.ColumnCount = 2;
			this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layoutPanel.Location = new System.Drawing.Point(6, 66);
			this.layoutPanel.Name = "layoutPanel";
			this.layoutPanel.RowCount = 1;
			this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layoutPanel.Size = new System.Drawing.Size(497, 333);
			this.layoutPanel.TabIndex = 3;
			// 
			// highlightedOutputBox
			// 
			this.highlightedOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.highlightedOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.highlightedOutputBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highlightedOutputBox.Location = new System.Drawing.Point(5, 40);
			this.highlightedOutputBox.Multiline = false;
			this.highlightedOutputBox.Name = "highlightedOutputBox";
			this.highlightedOutputBox.ReadOnly = true;
			this.highlightedOutputBox.Size = new System.Drawing.Size(498, 20);
			this.highlightedOutputBox.TabIndex = 2;
			this.highlightedOutputBox.Text = " Highlighted Output";
			this.highlightedOutputBox.WordWrap = false;
			// 
			// sampleInputBox
			// 
			this.sampleInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sampleInputBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sampleInputBox.Location = new System.Drawing.Point(6, 10);
			this.sampleInputBox.Name = "sampleInputBox";
			this.sampleInputBox.Size = new System.Drawing.Size(497, 23);
			this.sampleInputBox.TabIndex = 1;
			this.sampleInputBox.Text = "Sample Input";
			// 
			// Plot
			// 
			this.Plot.Controls.Add(this.plotInputDisplay);
			this.Plot.Controls.Add(this.xRange);
			this.Plot.Controls.Add(this.yMinText);
			this.Plot.Controls.Add(this.yMaxText);
			this.Plot.Controls.Add(this.plotValue3);
			this.Plot.Controls.Add(this.plotValue2);
			this.Plot.Controls.Add(this.plotValue1);
			this.Plot.Controls.Add(this.label4);
			this.Plot.Controls.Add(this.label3);
			this.Plot.Controls.Add(this.label1);
			this.Plot.Controls.Add(this.plotRegex3);
			this.Plot.Controls.Add(this.plotRegex2);
			this.Plot.Controls.Add(this.plotRegex1);
			this.Plot.Controls.Add(this.chart1);
			this.Plot.Location = new System.Drawing.Point(4, 22);
			this.Plot.Margin = new System.Windows.Forms.Padding(0);
			this.Plot.Name = "Plot";
			this.Plot.Size = new System.Drawing.Size(506, 382);
			this.Plot.TabIndex = 3;
			this.Plot.Text = "  Plot";
			this.Plot.UseVisualStyleBackColor = true;
			// 
			// plotInputDisplay
			// 
			this.plotInputDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.plotInputDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.plotInputDisplay.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plotInputDisplay.Location = new System.Drawing.Point(0, 71);
			this.plotInputDisplay.Name = "plotInputDisplay";
			this.plotInputDisplay.ReadOnly = true;
			this.plotInputDisplay.Size = new System.Drawing.Size(504, 23);
			this.plotInputDisplay.TabIndex = 14;
			// 
			// xRange
			// 
			this.xRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.xRange.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xRange.Location = new System.Drawing.Point(475, 363);
			this.xRange.Name = "xRange";
			this.xRange.Size = new System.Drawing.Size(30, 20);
			this.xRange.TabIndex = 13;
			this.xRange.Text = "20";
			this.xRange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xRange_KeyDown);
			this.xRange.Leave += new System.EventHandler(this.xRange_Leave);
			// 
			// yMinText
			// 
			this.yMinText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.yMinText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yMinText.Location = new System.Drawing.Point(-1, 363);
			this.yMinText.Name = "yMinText";
			this.yMinText.Size = new System.Drawing.Size(40, 20);
			this.yMinText.TabIndex = 12;
			this.yMinText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yMinText_KeyDown);
			this.yMinText.Leave += new System.EventHandler(this.yMinText_Leave);
			// 
			// yMaxText
			// 
			this.yMaxText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yMaxText.Location = new System.Drawing.Point(-1, 95);
			this.yMaxText.Name = "yMaxText";
			this.yMaxText.Size = new System.Drawing.Size(40, 20);
			this.yMaxText.TabIndex = 11;
			this.yMaxText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yMaxText_KeyDown);
			this.yMaxText.Leave += new System.EventHandler(this.yMaxText_Leave);
			// 
			// plotValue3
			// 
			this.plotValue3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.plotValue3.AutoSize = true;
			this.plotValue3.ForeColor = System.Drawing.Color.Green;
			this.plotValue3.Location = new System.Drawing.Point(417, 50);
			this.plotValue3.Name = "plotValue3";
			this.plotValue3.Size = new System.Drawing.Size(0, 13);
			this.plotValue3.TabIndex = 10;
			// 
			// plotValue2
			// 
			this.plotValue2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.plotValue2.AutoSize = true;
			this.plotValue2.ForeColor = System.Drawing.Color.Navy;
			this.plotValue2.Location = new System.Drawing.Point(417, 27);
			this.plotValue2.Name = "plotValue2";
			this.plotValue2.Size = new System.Drawing.Size(0, 13);
			this.plotValue2.TabIndex = 9;
			// 
			// plotValue1
			// 
			this.plotValue1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.plotValue1.AutoSize = true;
			this.plotValue1.ForeColor = System.Drawing.Color.Maroon;
			this.plotValue1.Location = new System.Drawing.Point(417, 5);
			this.plotValue1.Name = "plotValue1";
			this.plotValue1.Size = new System.Drawing.Size(0, 13);
			this.plotValue1.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Green;
			this.label4.Location = new System.Drawing.Point(0, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "RegEx3";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Location = new System.Drawing.Point(0, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "RegEx2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Location = new System.Drawing.Point(0, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "RegEx1";
			// 
			// plotRegex3
			// 
			this.plotRegex3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.plotRegex3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.plotRegex3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plotRegex3.ForeColor = System.Drawing.Color.Green;
			this.plotRegex3.Location = new System.Drawing.Point(45, 46);
			this.plotRegex3.Name = "plotRegex3";
			this.plotRegex3.Size = new System.Drawing.Size(370, 23);
			this.plotRegex3.TabIndex = 3;
			this.plotRegex3.TextChanged += new System.EventHandler(this.updatePlotRegex);
			// 
			// plotRegex2
			// 
			this.plotRegex2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.plotRegex2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.plotRegex2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plotRegex2.ForeColor = System.Drawing.Color.Navy;
			this.plotRegex2.Location = new System.Drawing.Point(45, 24);
			this.plotRegex2.Name = "plotRegex2";
			this.plotRegex2.Size = new System.Drawing.Size(370, 23);
			this.plotRegex2.TabIndex = 2;
			this.plotRegex2.TextChanged += new System.EventHandler(this.updatePlotRegex);
			// 
			// plotRegex1
			// 
			this.plotRegex1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.plotRegex1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.plotRegex1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plotRegex1.ForeColor = System.Drawing.Color.Maroon;
			this.plotRegex1.Location = new System.Drawing.Point(45, 2);
			this.plotRegex1.Name = "plotRegex1";
			this.plotRegex1.Size = new System.Drawing.Size(370, 23);
			this.plotRegex1.TabIndex = 1;
			this.plotRegex1.TextChanged += new System.EventHandler(this.updatePlotRegex);
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chart1.Location = new System.Drawing.Point(0, 101);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(504, 279);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// Instructions
			// 
			this.Instructions.Controls.Add(this.label2);
			this.Instructions.Location = new System.Drawing.Point(4, 22);
			this.Instructions.Name = "Instructions";
			this.Instructions.Padding = new System.Windows.Forms.Padding(3);
			this.Instructions.Size = new System.Drawing.Size(506, 382);
			this.Instructions.TabIndex = 2;
			this.Instructions.Text = "Instructions";
			this.Instructions.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(499, 312);
			this.label2.TabIndex = 2;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logLabel,
            this.rxBufferBar});
			this.statusStrip1.Location = new System.Drawing.Point(0, 484);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.ShowItemToolTips = true;
			this.statusStrip1.Size = new System.Drawing.Size(514, 22);
			this.statusStrip1.TabIndex = 15;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// logLabel
			// 
			this.logLabel.Name = "logLabel";
			this.logLabel.Size = new System.Drawing.Size(447, 17);
			this.logLabel.Spring = true;
			this.logLabel.Text = "Log";
			this.logLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rxBufferBar
			// 
			this.rxBufferBar.Name = "rxBufferBar";
			this.rxBufferBar.Size = new System.Drawing.Size(50, 16);
			this.rxBufferBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// txBox
			// 
			this.txBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txBox.Enabled = false;
			this.txBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txBox.FormattingEnabled = true;
			this.txBox.Location = new System.Drawing.Point(65, 4);
			this.txBox.Name = "txBox";
			this.txBox.Size = new System.Drawing.Size(385, 23);
			this.txBox.TabIndex = 16;
			this.txBox.SelectedIndexChanged += new System.EventHandler(this.txBox_SelectedIndexChanged);
			// 
			// dtr
			// 
			this.dtr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtr.AutoSize = true;
			this.dtr.Checked = true;
			this.dtr.CheckState = System.Windows.Forms.CheckState.Checked;
			this.dtr.Location = new System.Drawing.Point(214, 442);
			this.dtr.Name = "dtr";
			this.dtr.Size = new System.Drawing.Size(49, 17);
			this.dtr.TabIndex = 17;
			this.dtr.Text = "DTR";
			this.dtr.UseVisualStyleBackColor = true;
			// 
			// openClose
			// 
			this.openClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.openClose.Appearance = System.Windows.Forms.Appearance.Button;
			this.openClose.Location = new System.Drawing.Point(87, 438);
			this.openClose.Name = "openClose";
			this.openClose.Size = new System.Drawing.Size(50, 23);
			this.openClose.TabIndex = 18;
			this.openClose.Text = "Open";
			this.openClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.openClose.UseVisualStyleBackColor = false;
			this.openClose.CheckedChanged += new System.EventHandler(this.openClose_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 506);
			this.Controls.Add(this.openClose);
			this.Controls.Add(this.dtr);
			this.Controls.Add(this.txBox);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lineEndingBox);
			this.Controls.Add(this.autoscroll);
			this.Controls.Add(this.RefreshBtn);
			this.Controls.Add(this.SendBtn);
			this.Controls.Add(this.SerialPortsSel);
			this.Controls.Add(this.BaudratesSel);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.CopyBtn);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SerialTerminal.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = global::SerialTerminal.Properties.Settings.Default.Location;
			this.Name = "Form1";
			this.Text = "Serial Terminal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.Console.ResumeLayout(false);
			this.Highlight.ResumeLayout(false);
			this.Highlight.PerformLayout();
			this.Plot.ResumeLayout(false);
			this.Plot.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.Instructions.ResumeLayout(false);
			this.Instructions.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox BaudratesSel;
		private System.Windows.Forms.ComboBox SerialPortsSel;
		private System.Windows.Forms.Button SendBtn;
		private System.Windows.Forms.Button ClearBtn;
		private System.Windows.Forms.Button RefreshBtn;
		private System.Windows.Forms.CheckBox autoscroll;
		private System.Windows.Forms.RichTextBox rxDataTextBox;
		private System.Windows.Forms.Button CopyBtn;
		private System.Windows.Forms.ComboBox lineEndingBox;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Console;
		private System.Windows.Forms.TabPage Highlight;
		private System.Windows.Forms.RichTextBox highlightedOutputBox;
		private System.Windows.Forms.TextBox sampleInputBox;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.TabPage Instructions;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel logLabel;
		private System.Windows.Forms.ToolStripProgressBar rxBufferBar;
		private System.Windows.Forms.TableLayoutPanel layoutPanel;
		private System.Windows.Forms.ComboBox txBox;
		private System.Windows.Forms.CheckBox dtr;
		private System.Windows.Forms.CheckBox openClose;
		private System.Windows.Forms.TabPage Plot;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.TextBox plotRegex3;
		private System.Windows.Forms.TextBox plotRegex2;
		private System.Windows.Forms.TextBox plotRegex1;
		private System.Windows.Forms.Label plotValue3;
		private System.Windows.Forms.Label plotValue2;
		private System.Windows.Forms.Label plotValue1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox yMaxText;
		private System.Windows.Forms.TextBox yMinText;
		private System.Windows.Forms.TextBox xRange;
		private System.Windows.Forms.TextBox plotInputDisplay;

	}
}

