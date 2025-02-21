namespace SimpleERPSystem
{
    partial class FrmMenu
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
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPagePO = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPageSO = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPageItem = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPageBase = new ComponentFactory.Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPagePO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageBase)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Header.HeaderValuesPrimary.MapHeading = ComponentFactory.Krypton.Navigator.MapKryptonPageText.Text;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.OutlookFull;
            this.kryptonNavigator1.Outlook.ShowDropDownButton = false;
            this.kryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPagePO,
            this.kryptonPageSO,
            this.kryptonPageItem,
            this.kryptonPageBase});
            this.kryptonNavigator1.SelectedIndex = 3;
            this.kryptonNavigator1.Size = new System.Drawing.Size(278, 612);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPagePO
            // 
            this.kryptonPagePO.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPagePO.Flags = 65534;
            this.kryptonPagePO.LastVisibleSet = true;
            this.kryptonPagePO.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPagePO.Name = "kryptonPagePO";
            this.kryptonPagePO.Size = new System.Drawing.Size(276, 411);
            this.kryptonPagePO.Text = "采购管理";
            this.kryptonPagePO.TextDescription = "采购管理";
            this.kryptonPagePO.TextTitle = "采购管理";
            this.kryptonPagePO.ToolTipTitle = "Page ToolTip";
            this.kryptonPagePO.UniqueName = "C341D65D5318433C9FABDC3B976B5E6F";
            // 
            // kryptonPageSO
            // 
            this.kryptonPageSO.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPageSO.Flags = 65534;
            this.kryptonPageSO.LastVisibleSet = true;
            this.kryptonPageSO.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPageSO.Name = "kryptonPageSO";
            this.kryptonPageSO.Size = new System.Drawing.Size(276, 425);
            this.kryptonPageSO.Text = "销售管理/营业管理";
            this.kryptonPageSO.TextDescription = "销售管理/营业管理";
            this.kryptonPageSO.TextTitle = "销售管理/营业管理";
            this.kryptonPageSO.ToolTipTitle = "Page ToolTip";
            this.kryptonPageSO.UniqueName = "CD4D6110C8DA47FE06A8DD195237221A";
            // 
            // kryptonPageItem
            // 
            this.kryptonPageItem.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPageItem.Flags = 65534;
            this.kryptonPageItem.LastVisibleSet = true;
            this.kryptonPageItem.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPageItem.Name = "kryptonPageItem";
            this.kryptonPageItem.Size = new System.Drawing.Size(276, 439);
            this.kryptonPageItem.Text = "商品管理";
            this.kryptonPageItem.TextDescription = "商品管理";
            this.kryptonPageItem.TextTitle = "商品管理";
            this.kryptonPageItem.ToolTipTitle = "Page ToolTip";
            this.kryptonPageItem.UniqueName = "306A8E4F1A604615A09D6E1B9F00AAC6";
            // 
            // kryptonPageBase
            // 
            this.kryptonPageBase.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPageBase.Flags = 65534;
            this.kryptonPageBase.LastVisibleSet = true;
            this.kryptonPageBase.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPageBase.Name = "kryptonPageBase";
            this.kryptonPageBase.Size = new System.Drawing.Size(276, 453);
            this.kryptonPageBase.Text = "基础信息管理";
            this.kryptonPageBase.TextDescription = "基础信息管理";
            this.kryptonPageBase.TextTitle = "基础信息管理";
            this.kryptonPageBase.ToolTipTitle = "Page ToolTip";
            this.kryptonPageBase.UniqueName = "1F1B6BD8B1D341A054898A7B7C6BF4DB";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 612);
            this.Controls.Add(this.kryptonNavigator1);
            this.Name = "FrmMenu";
            this.Text = "用户菜单栏";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPagePO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPagePO;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPageSO;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPageItem;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPageBase;
    }
}