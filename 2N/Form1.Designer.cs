namespace _2N
{
	partial class Form2N
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox2N = new System.Windows.Forms.GroupBox();
			this.labelBeta = new System.Windows.Forms.Label();
			this.textBoxBeta = new System.Windows.Forms.TextBox();
			this.radioButtonGe = new System.Windows.Forms.RadioButton();
			this.radioButtonSi = new System.Windows.Forms.RadioButton();
			this.groupBoxB = new System.Windows.Forms.GroupBox();
			this.labelBROhm = new System.Windows.Forms.Label();
			this.textBoxBR = new System.Windows.Forms.TextBox();
			this.labelBR = new System.Windows.Forms.Label();
			this.labelBVV = new System.Windows.Forms.Label();
			this.textBoxBV = new System.Windows.Forms.TextBox();
			this.labelBV = new System.Windows.Forms.Label();
			this.groupBoxC = new System.Windows.Forms.GroupBox();
			this.labelCROhm = new System.Windows.Forms.Label();
			this.textBoxCR = new System.Windows.Forms.TextBox();
			this.labelCR = new System.Windows.Forms.Label();
			this.labelCVV = new System.Windows.Forms.Label();
			this.textBoxCV = new System.Windows.Forms.TextBox();
			this.labelCV = new System.Windows.Forms.Label();
			this.groupBoxE = new System.Windows.Forms.GroupBox();
			this.labelEROhm = new System.Windows.Forms.Label();
			this.textBoxER = new System.Windows.Forms.TextBox();
			this.labelER = new System.Windows.Forms.Label();
			this.labelEVV = new System.Windows.Forms.Label();
			this.textBoxEV = new System.Windows.Forms.TextBox();
			this.labelEV = new System.Windows.Forms.Label();
			this.buttonCal = new System.Windows.Forms.Button();
			this.labelAns = new System.Windows.Forms.Label();
			this.saveFileDialog2N = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog2N = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip2N = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewHelpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2N.SuspendLayout();
			this.groupBoxB.SuspendLayout();
			this.groupBoxC.SuspendLayout();
			this.groupBoxE.SuspendLayout();
			this.menuStrip2N.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2N
			// 
			this.groupBox2N.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2N.Controls.Add(this.labelBeta);
			this.groupBox2N.Controls.Add(this.textBoxBeta);
			this.groupBox2N.Controls.Add(this.radioButtonGe);
			this.groupBox2N.Controls.Add(this.radioButtonSi);
			this.groupBox2N.Location = new System.Drawing.Point(13, 32);
			this.groupBox2N.Name = "groupBox2N";
			this.groupBox2N.Size = new System.Drawing.Size(227, 80);
			this.groupBox2N.TabIndex = 0;
			this.groupBox2N.TabStop = false;
			this.groupBox2N.Text = "2N";
			// 
			// labelBeta
			// 
			this.labelBeta.AutoSize = true;
			this.labelBeta.Location = new System.Drawing.Point(7, 51);
			this.labelBeta.Name = "labelBeta";
			this.labelBeta.Size = new System.Drawing.Size(56, 17);
			this.labelBeta.TabIndex = 3;
			this.labelBeta.Text = "\\beta = ";
			// 
			// textBoxBeta
			// 
			this.textBoxBeta.Location = new System.Drawing.Point(69, 48);
			this.textBoxBeta.Name = "textBoxBeta";
			this.textBoxBeta.Size = new System.Drawing.Size(100, 23);
			this.textBoxBeta.TabIndex = 2;
			this.textBoxBeta.Text = "1";
			this.textBoxBeta.TextChanged += new System.EventHandler(this.textBoxBeta_TextChanged);
			// 
			// radioButtonGe
			// 
			this.radioButtonGe.AutoSize = true;
			this.radioButtonGe.Location = new System.Drawing.Point(49, 23);
			this.radioButtonGe.Name = "radioButtonGe";
			this.radioButtonGe.Size = new System.Drawing.Size(42, 21);
			this.radioButtonGe.TabIndex = 1;
			this.radioButtonGe.Text = "Ge";
			this.radioButtonGe.UseVisualStyleBackColor = true;
			this.radioButtonGe.CheckedChanged += new System.EventHandler(this.radioButtonGe_CheckedChanged);
			// 
			// radioButtonSi
			// 
			this.radioButtonSi.AutoSize = true;
			this.radioButtonSi.Checked = true;
			this.radioButtonSi.Location = new System.Drawing.Point(7, 23);
			this.radioButtonSi.Name = "radioButtonSi";
			this.radioButtonSi.Size = new System.Drawing.Size(36, 21);
			this.radioButtonSi.TabIndex = 0;
			this.radioButtonSi.TabStop = true;
			this.radioButtonSi.Text = "Si";
			this.radioButtonSi.UseVisualStyleBackColor = true;
			this.radioButtonSi.CheckedChanged += new System.EventHandler(this.radioButtonSi_CheckedChanged);
			// 
			// groupBoxB
			// 
			this.groupBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxB.Controls.Add(this.labelBROhm);
			this.groupBoxB.Controls.Add(this.textBoxBR);
			this.groupBoxB.Controls.Add(this.labelBR);
			this.groupBoxB.Controls.Add(this.labelBVV);
			this.groupBoxB.Controls.Add(this.textBoxBV);
			this.groupBoxB.Controls.Add(this.labelBV);
			this.groupBoxB.Location = new System.Drawing.Point(13, 119);
			this.groupBoxB.Name = "groupBoxB";
			this.groupBoxB.Size = new System.Drawing.Size(226, 84);
			this.groupBoxB.TabIndex = 1;
			this.groupBoxB.TabStop = false;
			this.groupBoxB.Text = "B";
			// 
			// labelBROhm
			// 
			this.labelBROhm.AutoSize = true;
			this.labelBROhm.Location = new System.Drawing.Point(166, 53);
			this.labelBROhm.Name = "labelBROhm";
			this.labelBROhm.Size = new System.Drawing.Size(41, 17);
			this.labelBROhm.TabIndex = 5;
			this.labelBROhm.Text = "\\Ohm";
			// 
			// textBoxBR
			// 
			this.textBoxBR.Location = new System.Drawing.Point(59, 50);
			this.textBoxBR.Name = "textBoxBR";
			this.textBoxBR.Size = new System.Drawing.Size(100, 23);
			this.textBoxBR.TabIndex = 4;
			this.textBoxBR.Text = "0";
			this.textBoxBR.TextChanged += new System.EventHandler(this.textBoxBR_TextChanged);
			// 
			// labelBR
			// 
			this.labelBR.AutoSize = true;
			this.labelBR.Location = new System.Drawing.Point(7, 53);
			this.labelBR.Name = "labelBR";
			this.labelBR.Size = new System.Drawing.Size(46, 17);
			this.labelBR.TabIndex = 3;
			this.labelBR.Text = "R_B = ";
			// 
			// labelBVV
			// 
			this.labelBVV.AutoSize = true;
			this.labelBVV.Location = new System.Drawing.Point(166, 23);
			this.labelBVV.Name = "labelBVV";
			this.labelBVV.Size = new System.Drawing.Size(16, 17);
			this.labelBVV.TabIndex = 2;
			this.labelBVV.Text = "V";
			// 
			// textBoxBV
			// 
			this.textBoxBV.Location = new System.Drawing.Point(59, 20);
			this.textBoxBV.Name = "textBoxBV";
			this.textBoxBV.Size = new System.Drawing.Size(100, 23);
			this.textBoxBV.TabIndex = 1;
			this.textBoxBV.Text = "0";
			this.textBoxBV.TextChanged += new System.EventHandler(this.textBoxBV_TextChanged);
			// 
			// labelBV
			// 
			this.labelBV.AutoSize = true;
			this.labelBV.Location = new System.Drawing.Point(7, 23);
			this.labelBV.Name = "labelBV";
			this.labelBV.Size = new System.Drawing.Size(46, 17);
			this.labelBV.TabIndex = 0;
			this.labelBV.Text = "V_B = ";
			// 
			// groupBoxC
			// 
			this.groupBoxC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxC.Controls.Add(this.labelCROhm);
			this.groupBoxC.Controls.Add(this.textBoxCR);
			this.groupBoxC.Controls.Add(this.labelCR);
			this.groupBoxC.Controls.Add(this.labelCVV);
			this.groupBoxC.Controls.Add(this.textBoxCV);
			this.groupBoxC.Controls.Add(this.labelCV);
			this.groupBoxC.Location = new System.Drawing.Point(13, 209);
			this.groupBoxC.Name = "groupBoxC";
			this.groupBoxC.Size = new System.Drawing.Size(227, 84);
			this.groupBoxC.TabIndex = 6;
			this.groupBoxC.TabStop = false;
			this.groupBoxC.Text = "C";
			// 
			// labelCROhm
			// 
			this.labelCROhm.AutoSize = true;
			this.labelCROhm.Location = new System.Drawing.Point(166, 53);
			this.labelCROhm.Name = "labelCROhm";
			this.labelCROhm.Size = new System.Drawing.Size(41, 17);
			this.labelCROhm.TabIndex = 5;
			this.labelCROhm.Text = "\\Ohm";
			// 
			// textBoxCR
			// 
			this.textBoxCR.Location = new System.Drawing.Point(59, 50);
			this.textBoxCR.Name = "textBoxCR";
			this.textBoxCR.Size = new System.Drawing.Size(100, 23);
			this.textBoxCR.TabIndex = 4;
			this.textBoxCR.Text = "0";
			this.textBoxCR.TextChanged += new System.EventHandler(this.textBoxCR_TextChanged);
			// 
			// labelCR
			// 
			this.labelCR.AutoSize = true;
			this.labelCR.Location = new System.Drawing.Point(7, 53);
			this.labelCR.Name = "labelCR";
			this.labelCR.Size = new System.Drawing.Size(46, 17);
			this.labelCR.TabIndex = 3;
			this.labelCR.Text = "R_C = ";
			// 
			// labelCVV
			// 
			this.labelCVV.AutoSize = true;
			this.labelCVV.Location = new System.Drawing.Point(166, 23);
			this.labelCVV.Name = "labelCVV";
			this.labelCVV.Size = new System.Drawing.Size(16, 17);
			this.labelCVV.TabIndex = 2;
			this.labelCVV.Text = "V";
			// 
			// textBoxCV
			// 
			this.textBoxCV.Location = new System.Drawing.Point(59, 20);
			this.textBoxCV.Name = "textBoxCV";
			this.textBoxCV.Size = new System.Drawing.Size(100, 23);
			this.textBoxCV.TabIndex = 1;
			this.textBoxCV.Text = "0";
			this.textBoxCV.TextChanged += new System.EventHandler(this.textBoxCV_TextChanged);
			// 
			// labelCV
			// 
			this.labelCV.AutoSize = true;
			this.labelCV.Location = new System.Drawing.Point(7, 23);
			this.labelCV.Name = "labelCV";
			this.labelCV.Size = new System.Drawing.Size(46, 17);
			this.labelCV.TabIndex = 0;
			this.labelCV.Text = "V_C = ";
			// 
			// groupBoxE
			// 
			this.groupBoxE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxE.Controls.Add(this.labelEROhm);
			this.groupBoxE.Controls.Add(this.textBoxER);
			this.groupBoxE.Controls.Add(this.labelER);
			this.groupBoxE.Controls.Add(this.labelEVV);
			this.groupBoxE.Controls.Add(this.textBoxEV);
			this.groupBoxE.Controls.Add(this.labelEV);
			this.groupBoxE.Location = new System.Drawing.Point(12, 299);
			this.groupBoxE.Name = "groupBoxE";
			this.groupBoxE.Size = new System.Drawing.Size(227, 84);
			this.groupBoxE.TabIndex = 6;
			this.groupBoxE.TabStop = false;
			this.groupBoxE.Text = "E";
			// 
			// labelEROhm
			// 
			this.labelEROhm.AutoSize = true;
			this.labelEROhm.Location = new System.Drawing.Point(166, 53);
			this.labelEROhm.Name = "labelEROhm";
			this.labelEROhm.Size = new System.Drawing.Size(41, 17);
			this.labelEROhm.TabIndex = 5;
			this.labelEROhm.Text = "\\Ohm";
			// 
			// textBoxER
			// 
			this.textBoxER.Location = new System.Drawing.Point(59, 50);
			this.textBoxER.Name = "textBoxER";
			this.textBoxER.Size = new System.Drawing.Size(100, 23);
			this.textBoxER.TabIndex = 4;
			this.textBoxER.Text = "0";
			this.textBoxER.TextChanged += new System.EventHandler(this.textBoxER_TextChanged);
			// 
			// labelER
			// 
			this.labelER.AutoSize = true;
			this.labelER.Location = new System.Drawing.Point(7, 53);
			this.labelER.Name = "labelER";
			this.labelER.Size = new System.Drawing.Size(45, 17);
			this.labelER.TabIndex = 3;
			this.labelER.Text = "R_E = ";
			// 
			// labelEVV
			// 
			this.labelEVV.AutoSize = true;
			this.labelEVV.Location = new System.Drawing.Point(166, 23);
			this.labelEVV.Name = "labelEVV";
			this.labelEVV.Size = new System.Drawing.Size(16, 17);
			this.labelEVV.TabIndex = 2;
			this.labelEVV.Text = "V";
			// 
			// textBoxEV
			// 
			this.textBoxEV.Location = new System.Drawing.Point(59, 20);
			this.textBoxEV.Name = "textBoxEV";
			this.textBoxEV.Size = new System.Drawing.Size(100, 23);
			this.textBoxEV.TabIndex = 1;
			this.textBoxEV.Text = "0";
			this.textBoxEV.TextChanged += new System.EventHandler(this.textBoxEV_TextChanged);
			// 
			// labelEV
			// 
			this.labelEV.AutoSize = true;
			this.labelEV.Location = new System.Drawing.Point(7, 23);
			this.labelEV.Name = "labelEV";
			this.labelEV.Size = new System.Drawing.Size(45, 17);
			this.labelEV.TabIndex = 0;
			this.labelEV.Text = "V_E = ";
			// 
			// buttonCal
			// 
			this.buttonCal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCal.Location = new System.Drawing.Point(165, 390);
			this.buttonCal.Name = "buttonCal";
			this.buttonCal.Size = new System.Drawing.Size(75, 23);
			this.buttonCal.TabIndex = 7;
			this.buttonCal.Text = "Cal";
			this.buttonCal.UseVisualStyleBackColor = true;
			this.buttonCal.Click += new System.EventHandler(this.buttonCal_Click);
			// 
			// labelAns
			// 
			this.labelAns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelAns.AutoSize = true;
			this.labelAns.Location = new System.Drawing.Point(12, 393);
			this.labelAns.Name = "labelAns";
			this.labelAns.Size = new System.Drawing.Size(147, 17);
			this.labelAns.TabIndex = 8;
			this.labelAns.Text = "Click Button Cal For Ans";
			// 
			// saveFileDialog2N
			// 
			this.saveFileDialog2N.Filter = "2N Files|*.2n|All Files|*.*";
			// 
			// openFileDialog2N
			// 
			this.openFileDialog2N.Filter = "2N Files|*.2n|All Files|*.*";
			// 
			// menuStrip2N
			// 
			this.menuStrip2N.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip2N.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2N.Name = "menuStrip2N";
			this.menuStrip2N.Size = new System.Drawing.Size(252, 25);
			this.menuStrip2N.TabIndex = 9;
			this.menuStrip2N.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveAsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As…";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpContentsToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// viewHelpContentsToolStripMenuItem
			// 
			this.viewHelpContentsToolStripMenuItem.Name = "viewHelpContentsToolStripMenuItem";
			this.viewHelpContentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
			this.viewHelpContentsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.viewHelpContentsToolStripMenuItem.Text = "&View Help Contents";
			this.viewHelpContentsToolStripMenuItem.Click += new System.EventHandler(this.viewHelpContentsToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// Form2N
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(252, 425);
			this.Controls.Add(this.labelAns);
			this.Controls.Add(this.buttonCal);
			this.Controls.Add(this.groupBoxE);
			this.Controls.Add(this.groupBoxC);
			this.Controls.Add(this.groupBoxB);
			this.Controls.Add(this.groupBox2N);
			this.Controls.Add(this.menuStrip2N);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip2N;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "Form2N";
			this.Text = "2N WMI";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2N_KeyDown);
			this.groupBox2N.ResumeLayout(false);
			this.groupBox2N.PerformLayout();
			this.groupBoxB.ResumeLayout(false);
			this.groupBoxB.PerformLayout();
			this.groupBoxC.ResumeLayout(false);
			this.groupBoxC.PerformLayout();
			this.groupBoxE.ResumeLayout(false);
			this.groupBoxE.PerformLayout();
			this.menuStrip2N.ResumeLayout(false);
			this.menuStrip2N.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2N;
		private System.Windows.Forms.RadioButton radioButtonSi;
		private System.Windows.Forms.RadioButton radioButtonGe;
		private System.Windows.Forms.Label labelBeta;
		private System.Windows.Forms.TextBox textBoxBeta;
		private System.Windows.Forms.GroupBox groupBoxB;
		private System.Windows.Forms.TextBox textBoxBV;
		private System.Windows.Forms.Label labelBV;
		private System.Windows.Forms.Label labelBROhm;
		private System.Windows.Forms.TextBox textBoxBR;
		private System.Windows.Forms.Label labelBR;
		private System.Windows.Forms.Label labelBVV;
		private System.Windows.Forms.GroupBox groupBoxC;
		private System.Windows.Forms.Label labelCROhm;
		private System.Windows.Forms.TextBox textBoxCR;
		private System.Windows.Forms.Label labelCR;
		private System.Windows.Forms.Label labelCVV;
		private System.Windows.Forms.TextBox textBoxCV;
		private System.Windows.Forms.Label labelCV;
		private System.Windows.Forms.GroupBox groupBoxE;
		private System.Windows.Forms.Label labelEROhm;
		private System.Windows.Forms.TextBox textBoxER;
		private System.Windows.Forms.Label labelER;
		private System.Windows.Forms.Label labelEVV;
		private System.Windows.Forms.TextBox textBoxEV;
		private System.Windows.Forms.Label labelEV;
		private System.Windows.Forms.Button buttonCal;
		private System.Windows.Forms.Label labelAns;
		private System.Windows.Forms.SaveFileDialog saveFileDialog2N;
		private System.Windows.Forms.OpenFileDialog openFileDialog2N;
		private System.Windows.Forms.MenuStrip menuStrip2N;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewHelpContentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}

