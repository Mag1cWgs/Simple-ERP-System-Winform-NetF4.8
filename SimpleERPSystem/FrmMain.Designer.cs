namespace SimpleERPSystem
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dockPanelMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.dockPanelMain.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.Padding = new System.Windows.Forms.Padding(6);
            this.dockPanelMain.ShowAutoHideContentOnHover = false;
            this.dockPanelMain.ShowDocumentIcon = true;
            this.dockPanelMain.Size = new System.Drawing.Size(1584, 861);
            this.dockPanelMain.TabIndex = 1;
            this.dockPanelMain.Theme = this.vS2015LightTheme1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblUser,
            this.tsslblDate,
            this.tsslblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 835);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1584, 26);
            this.statusStrip1.TabIndex = 4;
            // 
            // tsslblUser
            // 
            this.tsslblUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslblUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslblUser.Name = "tsslblUser";
            this.tsslblUser.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsslblUser.Size = new System.Drawing.Size(187, 21);
            this.tsslblUser.Text = "当前用户：FrmMain.user_id";
            // 
            // tsslblDate
            // 
            this.tsslblDate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslblDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslblDate.Name = "tsslblDate";
            this.tsslblDate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tsslblDate.Size = new System.Drawing.Size(177, 21);
            this.tsslblDate.Text = "当前日期：DateTime.Now";
            // 
            // tsslblVersion
            // 
            this.tsslblVersion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslblVersion.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsslblVersion.Name = "tsslblVersion";
            this.tsslblVersion.Size = new System.Drawing.Size(1205, 21);
            this.tsslblVersion.Spring = true;
            this.tsslblVersion.Text = "版本号：v25.1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dockPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进销存管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        public WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDate;
        private System.Windows.Forms.ToolStripStatusLabel tsslblVersion;
    }
}