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
            this.dockPanelMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
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
            this.dockPanelMain.Size = new System.Drawing.Size(1184, 681);
            this.dockPanelMain.TabIndex = 1;
            this.dockPanelMain.Theme = this.vS2015LightTheme1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.dockPanelMain);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "进销存管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        public WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelMain;
    }
}