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
			this.OpenBtn = new System.Windows.Forms.Button();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.CloseBtn = new System.Windows.Forms.Button();
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.logLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.rxBufferBar = new System.Windows.Forms.ToolStripProgressBar();
			this.txBox = new System.Windows.Forms.ComboBox();
			this.tabControl1.SuspendLayout();
			this.Console.SuspendLayout();
			this.Highlight.SuspendLayout();
			this.tabPage1.SuspendLayout();
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
			this.BaudratesSel.Location = new System.Drawing.Point(220, 455);
			this.BaudratesSel.Name = "BaudratesSel";
			this.BaudratesSel.Size = new System.Drawing.Size(91, 24);
			this.BaudratesSel.TabIndex = 1;
			// 
			// SerialPortsSel
			// 
			this.SerialPortsSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SerialPortsSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SerialPortsSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SerialPortsSel.FormattingEnabled = true;
			this.SerialPortsSel.Location = new System.Drawing.Point(30, 456);
			this.SerialPortsSel.Name = "SerialPortsSel";
			this.SerialPortsSel.Size = new System.Drawing.Size(65, 21);
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
			// OpenBtn
			// 
			this.OpenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.OpenBtn.BackColor = System.Drawing.SystemColors.Control;
			this.OpenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OpenBtn.Location = new System.Drawing.Point(100, 455);
			this.OpenBtn.Name = "OpenBtn";
			this.OpenBtn.Size = new System.Drawing.Size(55, 23);
			this.OpenBtn.TabIndex = 4;
			this.OpenBtn.Text = "Open";
			this.OpenBtn.UseVisualStyleBackColor = false;
			this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
			// 
			// ClearBtn
			// 
			this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearBtn.Location = new System.Drawing.Point(394, 455);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(55, 23);
			this.ClearBtn.TabIndex = 5;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// CloseBtn
			// 
			this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CloseBtn.BackColor = System.Drawing.SystemColors.Control;
			this.CloseBtn.Enabled = false;
			this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseBtn.Location = new System.Drawing.Point(158, 455);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(55, 23);
			this.CloseBtn.TabIndex = 6;
			this.CloseBtn.Text = "Close";
			this.CloseBtn.UseVisualStyleBackColor = false;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// RefreshBtn
			// 
			this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RefreshBtn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RefreshBtn.Location = new System.Drawing.Point(3, 455);
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
			this.autoscroll.Location = new System.Drawing.Point(322, 458);
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
			this.rxDataTextBox.Size = new System.Drawing.Size(499, 398);
			this.rxDataTextBox.TabIndex = 10;
			this.rxDataTextBox.Text = "";
			this.rxDataTextBox.WordWrap = false;
			// 
			// CopyBtn
			// 
			this.CopyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CopyBtn.Location = new System.Drawing.Point(455, 455);
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
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(4, 30);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(507, 424);
			this.tabControl1.TabIndex = 14;
			this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.highlightEnableDisable);
			// 
			// Console
			// 
			this.Console.Controls.Add(this.rxDataTextBox);
			this.Console.Location = new System.Drawing.Point(4, 22);
			this.Console.Name = "Console";
			this.Console.Padding = new System.Windows.Forms.Padding(3);
			this.Console.Size = new System.Drawing.Size(499, 398);
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
			this.Highlight.Size = new System.Drawing.Size(499, 398);
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
			this.layoutPanel.Size = new System.Drawing.Size(490, 329);
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
			this.highlightedOutputBox.Size = new System.Drawing.Size(491, 20);
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
			this.sampleInputBox.Size = new System.Drawing.Size(490, 23);
			this.sampleInputBox.TabIndex = 1;
			this.sampleInputBox.Text = "Sample Input";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(499, 398);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Instructions";
			this.tabPage1.UseVisualStyleBackColor = true;
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 480);
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
			this.txBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txBox.FormattingEnabled = true;
			this.txBox.Location = new System.Drawing.Point(65, 4);
			this.txBox.Name = "txBox";
			this.txBox.Size = new System.Drawing.Size(385, 23);
			this.txBox.TabIndex = 16;
			this.txBox.SelectedIndexChanged += new System.EventHandler(this.txBox_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AcceptButton = this.SendBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 502);
			this.Controls.Add(this.txBox);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lineEndingBox);
			this.Controls.Add(this.CopyBtn);
			this.Controls.Add(this.autoscroll);
			this.Controls.Add(this.RefreshBtn);
			this.Controls.Add(this.SendBtn);
			this.Controls.Add(this.CloseBtn);
			this.Controls.Add(this.SerialPortsSel);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.BaudratesSel);
			this.Controls.Add(this.OpenBtn);
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
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox BaudratesSel;
		private System.Windows.Forms.ComboBox SerialPortsSel;
		private System.Windows.Forms.Button SendBtn;
		private System.Windows.Forms.Button OpenBtn;
		private System.Windows.Forms.Button ClearBtn;
		private System.Windows.Forms.Button CloseBtn;
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
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel logLabel;
		private System.Windows.Forms.ToolStripProgressBar rxBufferBar;
		private System.Windows.Forms.TableLayoutPanel layoutPanel;
		private System.Windows.Forms.ComboBox txBox;

	}
}

