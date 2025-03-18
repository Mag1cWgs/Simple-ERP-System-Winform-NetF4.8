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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPagePO = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPageSO = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPageItem = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblItem = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPrice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPageBase = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblMajor = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblMinor = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPartner = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTax = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblUser = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPagePO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageItem)).BeginInit();
            this.kryptonPageItem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageBase)).BeginInit();
            this.kryptonPageBase.SuspendLayout();
            this.tlpBase.SuspendLayout();
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
            this.kryptonNavigator1.SelectedIndex = 2;
            this.kryptonNavigator1.Size = new System.Drawing.Size(184, 611);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPagePO
            // 
            this.kryptonPagePO.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPagePO.Flags = 65534;
            this.kryptonPagePO.ImageMedium = global::SimpleERPSystem.Properties.Resources.account_balances;
            this.kryptonPagePO.ImageSmall = global::SimpleERPSystem.Properties.Resources.account_balances;
            this.kryptonPagePO.LastVisibleSet = true;
            this.kryptonPagePO.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPagePO.Name = "kryptonPagePO";
            this.kryptonPagePO.Size = new System.Drawing.Size(182, 448);
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
            this.kryptonPageSO.ImageMedium = global::SimpleERPSystem.Properties.Resources.cart;
            this.kryptonPageSO.ImageSmall = global::SimpleERPSystem.Properties.Resources.cart;
            this.kryptonPageSO.LastVisibleSet = true;
            this.kryptonPageSO.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPageSO.Name = "kryptonPageSO";
            this.kryptonPageSO.Size = new System.Drawing.Size(182, 448);
            this.kryptonPageSO.Text = "销售管理";
            this.kryptonPageSO.TextDescription = "销售管理";
            this.kryptonPageSO.TextTitle = "销售管理";
            this.kryptonPageSO.ToolTipTitle = "Page ToolTip";
            this.kryptonPageSO.UniqueName = "CD4D6110C8DA47FE06A8DD195237221A";
            // 
            // kryptonPageItem
            // 
            this.kryptonPageItem.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPageItem.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPageItem.Flags = 65534;
            this.kryptonPageItem.ImageMedium = global::SimpleERPSystem.Properties.Resources.pencil;
            this.kryptonPageItem.ImageSmall = global::SimpleERPSystem.Properties.Resources.pencil;
            this.kryptonPageItem.LastVisibleSet = true;
            this.kryptonPageItem.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPageItem.Name = "kryptonPageItem";
            this.kryptonPageItem.Size = new System.Drawing.Size(182, 448);
            this.kryptonPageItem.Text = "商品管理";
            this.kryptonPageItem.TextDescription = "商品管理";
            this.kryptonPageItem.TextTitle = "商品管理";
            this.kryptonPageItem.ToolTipTitle = "Page ToolTip";
            this.kryptonPageItem.UniqueName = "306A8E4F1A604615A09D6E1B9F00AAC6";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblItem, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(182, 448);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblItem
            // 
            this.lblItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItem.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblItem.Location = new System.Drawing.Point(54, 23);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(74, 74);
            this.lblItem.StateCommon.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItem.StateCommon.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItem.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItem.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblItem.TabIndex = 0;
            this.lblItem.Values.Image = global::SimpleERPSystem.Properties.Resources.pencil1;
            this.lblItem.Values.Text = "商品信息";
            this.lblItem.Click += new System.EventHandler(this.lblItem_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblPrice.Location = new System.Drawing.Point(54, 103);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 74);
            this.lblPrice.StateCommon.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPrice.StateCommon.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPrice.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPrice.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Values.Image = global::SimpleERPSystem.Properties.Resources.money1;
            this.lblPrice.Values.Text = "往来单价";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // kryptonPageBase
            // 
            this.kryptonPageBase.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPageBase.Controls.Add(this.tlpBase);
            this.kryptonPageBase.Flags = 65534;
            this.kryptonPageBase.ImageMedium = global::SimpleERPSystem.Properties.Resources.cog;
            this.kryptonPageBase.ImageSmall = global::SimpleERPSystem.Properties.Resources.cog;
            this.kryptonPageBase.LastVisibleSet = true;
            this.kryptonPageBase.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPageBase.Name = "kryptonPageBase";
            this.kryptonPageBase.Size = new System.Drawing.Size(182, 448);
            this.kryptonPageBase.Text = "基础信息管理";
            this.kryptonPageBase.TextDescription = "基础信息管理";
            this.kryptonPageBase.TextTitle = "基础信息管理";
            this.kryptonPageBase.ToolTipTitle = "Page ToolTip";
            this.kryptonPageBase.UniqueName = "1F1B6BD8B1D341A054898A7B7C6BF4DB";
            // 
            // tlpBase
            // 
            this.tlpBase.AutoScroll = true;
            this.tlpBase.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpBase.ColumnCount = 3;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.Controls.Add(this.lblMajor, 1, 1);
            this.tlpBase.Controls.Add(this.lblMinor, 1, 2);
            this.tlpBase.Controls.Add(this.lblPartner, 1, 3);
            this.tlpBase.Controls.Add(this.lblTax, 1, 4);
            this.tlpBase.Controls.Add(this.lblUser, 1, 5);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 7;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Size = new System.Drawing.Size(182, 448);
            this.tlpBase.TabIndex = 0;
            // 
            // lblMajor
            // 
            this.lblMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMajor.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblMajor.Location = new System.Drawing.Point(54, 23);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(74, 74);
            this.lblMajor.StateCommon.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMajor.StateCommon.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMajor.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMajor.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblMajor.TabIndex = 0;
            this.lblMajor.Values.Image = global::SimpleERPSystem.Properties.Resources.category1;
            this.lblMajor.Values.Text = "主代码";
            this.lblMajor.Click += new System.EventHandler(this.lblMajor_Click);
            // 
            // lblMinor
            // 
            this.lblMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinor.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblMinor.Location = new System.Drawing.Point(54, 103);
            this.lblMinor.Name = "lblMinor";
            this.lblMinor.Size = new System.Drawing.Size(74, 74);
            this.lblMinor.StateCommon.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMinor.StateCommon.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMinor.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMinor.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblMinor.TabIndex = 1;
            this.lblMinor.Values.Image = global::SimpleERPSystem.Properties.Resources.categories1;
            this.lblMinor.Values.Text = "子代码";
            this.lblMinor.Click += new System.EventHandler(this.lblMinor_Click);
            // 
            // lblPartner
            // 
            this.lblPartner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPartner.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblPartner.Location = new System.Drawing.Point(54, 183);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(74, 74);
            this.lblPartner.StateCommon.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPartner.StateCommon.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPartner.StateCommon.ShortText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.lblPartner.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblPartner.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblPartner.TabIndex = 2;
            this.lblPartner.Values.Image = global::SimpleERPSystem.Properties.Resources.lorry_link1;
            this.lblPartner.Values.Text = "往来单位";
            this.lblPartner.Click += new System.EventHandler(this.lblPartner_Click);
            // 
            // lblTax
            // 
            this.lblTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTax.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblTax.Location = new System.Drawing.Point(54, 263);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(74, 74);
            this.lblTax.StateCommon.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTax.StateCommon.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTax.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTax.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblTax.TabIndex = 3;
            this.lblTax.Values.Image = global::SimpleERPSystem.Properties.Resources.decimal_less1;
            this.lblTax.Values.Text = "税率";
            this.lblTax.Click += new System.EventHandler(this.lblTax_Click);
            // 
            // lblUser
            // 
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblUser.Location = new System.Drawing.Point(54, 343);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 74);
            this.lblUser.StateCommon.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblUser.StateCommon.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblUser.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblUser.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblUser.TabIndex = 4;
            this.lblUser.Values.Image = global::SimpleERPSystem.Properties.Resources.cards_bind_address1;
            this.lblUser.Values.Text = "人员信息";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 611);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.kryptonNavigator1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.Text = "用户菜单栏";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPagePO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageItem)).EndInit();
            this.kryptonPageItem.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPageBase)).EndInit();
            this.kryptonPageBase.ResumeLayout(false);
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPagePO;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPageSO;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPageItem;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPageBase;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMajor;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMinor;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPartner;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTax;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblItem;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPrice;
    }
}