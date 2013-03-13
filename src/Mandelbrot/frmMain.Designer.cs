namespace Mandelbrot
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnNewColor = new System.Windows.Forms.Button();
            this.cbColors = new System.Windows.Forms.ComboBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.grpDrawing = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.checkAxis = new System.Windows.Forms.CheckBox();
            this.txtIter = new System.Windows.Forms.TextBox();
            this.lblIter = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtYmax = new System.Windows.Forms.TextBox();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.txtYmin = new System.Windows.Forms.TextBox();
            this.txtXmin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progStatus = new System.Windows.Forms.ProgressBar();
            this.btnAbort = new System.Windows.Forms.Button();
            this.checkLiveRender = new System.Windows.Forms.CheckBox();
            this.grpSettings.SuspendLayout();
            this.grpDrawing.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpView.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.btnNewColor);
            this.grpSettings.Controls.Add(this.cbColors);
            this.grpSettings.Controls.Add(this.txtWidth);
            this.grpSettings.Controls.Add(this.txtColor);
            this.grpSettings.Controls.Add(this.txtHeight);
            this.grpSettings.Controls.Add(this.lblWidth);
            this.grpSettings.Controls.Add(this.lblHeight);
            this.grpSettings.Location = new System.Drawing.Point(6, 32);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(315, 94);
            this.grpSettings.TabIndex = 7;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // btnNewColor
            // 
            this.btnNewColor.Location = new System.Drawing.Point(225, 47);
            this.btnNewColor.Name = "btnNewColor";
            this.btnNewColor.Size = new System.Drawing.Size(75, 23);
            this.btnNewColor.TabIndex = 8;
            this.btnNewColor.Text = "&New Color...";
            this.btnNewColor.UseVisualStyleBackColor = true;
            this.btnNewColor.Click += new System.EventHandler(this.btnNewColor_Click);
            // 
            // cbColors
            // 
            this.cbColors.FormattingEnabled = true;
            this.cbColors.Location = new System.Drawing.Point(201, 23);
            this.cbColors.Name = "cbColors";
            this.cbColors.Size = new System.Drawing.Size(99, 21);
            this.cbColors.TabIndex = 3;
            this.cbColors.SelectedIndexChanged += new System.EventHandler(this.cbColors_SelectedIndexChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(59, 23);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(48, 20);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Text = "700";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtColor
            // 
            this.txtColor.AutoSize = true;
            this.txtColor.Location = new System.Drawing.Point(124, 26);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(71, 13);
            this.txtColor.TabIndex = 4;
            this.txtColor.Text = "Colorscheme:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(59, 49);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(48, 20);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.Text = "700";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(12, 26);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 52);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height:";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(156, 47);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(102, 23);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "&Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // grpDrawing
            // 
            this.grpDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDrawing.Controls.Add(this.btnReset);
            this.grpDrawing.Controls.Add(this.lblPreview);
            this.grpDrawing.Controls.Add(this.btnDraw);
            this.grpDrawing.Location = new System.Drawing.Point(702, 32);
            this.grpDrawing.Name = "grpDrawing";
            this.grpDrawing.Size = new System.Drawing.Size(264, 94);
            this.grpDrawing.TabIndex = 9;
            this.grpDrawing.TabStop = false;
            this.grpDrawing.Text = "Drawing";
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(156, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(6, 16);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(48, 13);
            this.lblPreview.TabIndex = 9;
            this.lblPreview.Text = "Preview:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openXMLToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveAsToolStripMenuItem,
            this.saveXMLAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openXMLToolStripMenuItem
            // 
            this.openXMLToolStripMenuItem.Image = global::Mandelbrot.Properties.Resources.openfolderHS;
            this.openXMLToolStripMenuItem.Name = "openXMLToolStripMenuItem";
            this.openXMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openXMLToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.openXMLToolStripMenuItem.Text = "Open (XML)...";
            this.openXMLToolStripMenuItem.Click += new System.EventHandler(this.openXMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::Mandelbrot.Properties.Resources.saveHS1;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveAsToolStripMenuItem.Text = "Save (Image) As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveXMLAsToolStripMenuItem
            // 
            this.saveXMLAsToolStripMenuItem.Name = "saveXMLAsToolStripMenuItem";
            this.saveXMLAsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveXMLAsToolStripMenuItem.Text = "Save (XML) As...";
            this.saveXMLAsToolStripMenuItem.Click += new System.EventHandler(this.saveXMLAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpView
            // 
            this.grpView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpView.Controls.Add(this.checkLiveRender);
            this.grpView.Controls.Add(this.checkAxis);
            this.grpView.Controls.Add(this.txtIter);
            this.grpView.Controls.Add(this.lblIter);
            this.grpView.Controls.Add(this.btnApply);
            this.grpView.Controls.Add(this.txtYmax);
            this.grpView.Controls.Add(this.txtXmax);
            this.grpView.Controls.Add(this.txtYmin);
            this.grpView.Controls.Add(this.txtXmin);
            this.grpView.Controls.Add(this.label4);
            this.grpView.Controls.Add(this.label3);
            this.grpView.Controls.Add(this.label2);
            this.grpView.Controls.Add(this.label1);
            this.grpView.Location = new System.Drawing.Point(327, 32);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(369, 94);
            this.grpView.TabIndex = 11;
            this.grpView.TabStop = false;
            this.grpView.Text = "Set window";
            // 
            // checkAxis
            // 
            this.checkAxis.AutoSize = true;
            this.checkAxis.Location = new System.Drawing.Point(9, 75);
            this.checkAxis.Name = "checkAxis";
            this.checkAxis.Size = new System.Drawing.Size(97, 17);
            this.checkAxis.TabIndex = 5;
            this.checkAxis.Text = "Show X/Y Axis";
            this.checkAxis.UseVisualStyleBackColor = true;
            // 
            // txtIter
            // 
            this.txtIter.Location = new System.Drawing.Point(316, 23);
            this.txtIter.Name = "txtIter";
            this.txtIter.Size = new System.Drawing.Size(47, 20);
            this.txtIter.TabIndex = 4;
            this.txtIter.Text = "100";
            this.txtIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIter
            // 
            this.lblIter.AutoSize = true;
            this.lblIter.Location = new System.Drawing.Point(262, 26);
            this.lblIter.Name = "lblIter";
            this.lblIter.Size = new System.Drawing.Size(53, 13);
            this.lblIter.TabIndex = 3;
            this.lblIter.Text = "Iterations:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(288, 47);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtYmax
            // 
            this.txtYmax.Location = new System.Drawing.Point(174, 49);
            this.txtYmax.Name = "txtYmax";
            this.txtYmax.Size = new System.Drawing.Size(73, 20);
            this.txtYmax.TabIndex = 1;
            this.txtYmax.Text = "1.3";
            // 
            // txtXmax
            // 
            this.txtXmax.Location = new System.Drawing.Point(174, 23);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(73, 20);
            this.txtXmax.TabIndex = 1;
            this.txtXmax.Text = "1";
            // 
            // txtYmin
            // 
            this.txtYmin.Location = new System.Drawing.Point(49, 49);
            this.txtYmin.Name = "txtYmin";
            this.txtYmin.Size = new System.Drawing.Size(73, 20);
            this.txtYmin.TabIndex = 1;
            this.txtYmin.Text = "-1.3";
            // 
            // txtXmin
            // 
            this.txtXmin.AcceptsReturn = true;
            this.txtXmin.Location = new System.Drawing.Point(49, 23);
            this.txtXmin.Name = "txtXmin";
            this.txtXmin.Size = new System.Drawing.Size(73, 20);
            this.txtXmin.TabIndex = 1;
            this.txtXmin.Text = "-2.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Y Max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Y Min:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "X Max:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Min:";
            // 
            // progStatus
            // 
            this.progStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progStatus.Location = new System.Drawing.Point(0, 671);
            this.progStatus.Name = "progStatus";
            this.progStatus.Size = new System.Drawing.Size(978, 23);
            this.progStatus.TabIndex = 12;
            // 
            // btnAbort
            // 
            this.btnAbort.Enabled = false;
            this.btnAbort.Location = new System.Drawing.Point(436, 132);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 13;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // checkLiveRender
            // 
            this.checkLiveRender.AutoSize = true;
            this.checkLiveRender.Location = new System.Drawing.Point(131, 75);
            this.checkLiveRender.Name = "checkLiveRender";
            this.checkLiveRender.Size = new System.Drawing.Size(84, 17);
            this.checkLiveRender.TabIndex = 6;
            this.checkLiveRender.Text = "Live Render";
            this.checkLiveRender.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnDraw;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.progStatus);
            this.Controls.Add(this.grpView);
            this.Controls.Add(this.grpDrawing);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Mandelbrot Designer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpDrawing.ResumeLayout(false);
            this.grpDrawing.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpView.ResumeLayout(false);
            this.grpView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.ComboBox cbColors;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label txtColor;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnNewColor;
        private System.Windows.Forms.GroupBox grpDrawing;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXMLAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox grpView;
        public System.Windows.Forms.TextBox txtYmax;
        public System.Windows.Forms.TextBox txtXmax;
        public System.Windows.Forms.TextBox txtYmin;
        public System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtIter;
        private System.Windows.Forms.Label lblIter;
        private System.Windows.Forms.CheckBox checkAxis;
        private System.Windows.Forms.ProgressBar progStatus;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.CheckBox checkLiveRender;
    }
}

