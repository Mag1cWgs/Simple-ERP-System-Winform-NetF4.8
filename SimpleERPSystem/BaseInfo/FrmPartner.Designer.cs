namespace SimpleERPSystem.BaseInfo
{
    partial class FrmPartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartner));
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lblBp_cd = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeader3 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnDel = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lblBp_full_nm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_bp_full_nm = new ERP_CL.ERP_TextBox();
            this.lblBp_addr = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_bp_addr = new ERP_CL.ERP_TextBox();
            this.txt_bp_tax = new ERP_CL.ERP_TextBox();
            this.lblBp_tax = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_remark = new ERP_CL.ERP_TextBox();
            this.cb_so_flag = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lblRemark = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_bp_email = new ERP_CL.ERP_TextBox();
            this.lblBp_repre = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_bp_repre = new ERP_CL.ERP_TextBox();
            this.lblBp_nm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_bp_nm = new ERP_CL.ERP_TextBox();
            this.lblBp_type = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cb_po_flag = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuery_bp_type = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblQuery_bp_full_nm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblQuery_bp_repre = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_query_bp_full_nm = new ERP_CL.ERP_TextBox();
            this.txt_query_bp_repre = new ERP_CL.ERP_TextBox();
            this.rbtn_query_so = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rbtn_query_po = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rbtn_query_all = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.lblBp_email = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_bank_acct_no = new ERP_CL.ERP_TextBox();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lblPay_type = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbb_pay_type = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lblBank_acct_no = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblBank_cd = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbb_bank_cd = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pnl_partner_info = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBp_tel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_bp_tel = new ERP_CL.ERP_TextBox();
            this.txt_bp_cd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bp_cd = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bp_full_nm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bp_nm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bp_addr = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bp_repre = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bp_email = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bp_tel = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.so_flag = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.po_flag = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bp_tax = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.pay_type = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.pay_type_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank_cd = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bank_cd_nm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bank_acct_no = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.remark = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_pay_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_bank_cd)).BeginInit();
            this.pnl_partner_info.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::SimpleERPSystem.Properties.Resources.table_tab_search1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UniqueName = "E71D77C7579343E5759C571694F484BB";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBp_cd
            // 
            this.lblBp_cd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBp_cd.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBp_cd.Location = new System.Drawing.Point(13, 16);
            this.lblBp_cd.Name = "lblBp_cd";
            this.lblBp_cd.Size = new System.Drawing.Size(62, 20);
            this.lblBp_cd.TabIndex = 0;
            this.lblBp_cd.TabStop = false;
            this.lblBp_cd.Values.Text = "单位编号";
            // 
            // btnSave
            // 
            this.btnSave.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSave.Image = global::SimpleERPSystem.Properties.Resources.table_save1;
            this.btnSave.Text = "保存";
            this.btnSave.UniqueName = "96E47CDE5C0C4AE45CAE8240EB0581C7";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnAdd.Image = global::SimpleERPSystem.Properties.Resources.page_add1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UniqueName = "E60FBF8FD534468531B932B1EE9E31C5";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // kryptonHeader3
            // 
            this.kryptonHeader3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader3.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader3.Location = new System.Drawing.Point(3, 115);
            this.kryptonHeader3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.kryptonHeader3.Name = "kryptonHeader3";
            this.kryptonHeader3.Size = new System.Drawing.Size(1378, 40);
            this.kryptonHeader3.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonHeader3.StateNormal.Back.Color1 = System.Drawing.Color.LightCyan;
            this.kryptonHeader3.StateNormal.Back.Color2 = System.Drawing.Color.Azure;
            this.kryptonHeader3.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.kryptonHeader3.StateNormal.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonHeader3.StateNormal.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.kryptonHeader3.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeader3.TabIndex = 2;
            this.kryptonHeader3.Values.Description = "";
            this.kryptonHeader3.Values.Heading = "往来单位信息";
            this.kryptonHeader3.Values.Image = global::SimpleERPSystem.Properties.Resources.account_balances1;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader2.Location = new System.Drawing.Point(3, 319);
            this.kryptonHeader2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(1378, 40);
            this.kryptonHeader2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonHeader2.StateNormal.Back.Color1 = System.Drawing.Color.LightCyan;
            this.kryptonHeader2.StateNormal.Back.Color2 = System.Drawing.Color.Azure;
            this.kryptonHeader2.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.kryptonHeader2.StateNormal.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonHeader2.StateNormal.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.kryptonHeader2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeader2.TabIndex = 4;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "查询结果";
            this.kryptonHeader2.Values.Image = global::SimpleERPSystem.Properties.Resources.table1;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDel,
            this.btnAdd,
            this.btnSave,
            this.btnSearch});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader1.Location = new System.Drawing.Point(3, 3);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(1378, 46);
            this.kryptonHeader1.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.kryptonHeader1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonHeader1.StateNormal.Back.Color1 = System.Drawing.Color.LightCyan;
            this.kryptonHeader1.StateNormal.Back.Color2 = System.Drawing.Color.Azure;
            this.kryptonHeader1.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.kryptonHeader1.StateNormal.Border.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.kryptonHeader1.StateNormal.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.kryptonHeader1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeader1.TabIndex = 0;
            this.kryptonHeader1.TabStop = false;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "";
            this.kryptonHeader1.Values.Image = null;
            // 
            // btnDel
            // 
            this.btnDel.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnDel.Image = global::SimpleERPSystem.Properties.Resources.page_delete1;
            this.btnDel.Text = "删除";
            this.btnDel.UniqueName = "640999D05B8443CBFCAAD82EFA7B1CCA";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblBp_full_nm
            // 
            this.lblBp_full_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBp_full_nm.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBp_full_nm.Location = new System.Drawing.Point(247, 16);
            this.lblBp_full_nm.Name = "lblBp_full_nm";
            this.lblBp_full_nm.Size = new System.Drawing.Size(62, 20);
            this.lblBp_full_nm.TabIndex = 2;
            this.lblBp_full_nm.TabStop = false;
            this.lblBp_full_nm.Values.Text = "单位全称";
            // 
            // txt_bp_full_nm
            // 
            this.txt_bp_full_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_bp_full_nm.Location = new System.Drawing.Point(315, 13);
            this.txt_bp_full_nm.Name = "txt_bp_full_nm";
            this.txt_bp_full_nm.Size = new System.Drawing.Size(280, 26);
            this.txt_bp_full_nm.StateCommon.Back.Color1 = System.Drawing.Color.LightBlue;
            this.txt_bp_full_nm.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txt_bp_full_nm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bp_full_nm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_bp_full_nm.TabIndex = 3;
            // 
            // lblBp_addr
            // 
            this.lblBp_addr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBp_addr.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBp_addr.Location = new System.Drawing.Point(247, 50);
            this.lblBp_addr.Name = "lblBp_addr";
            this.lblBp_addr.Size = new System.Drawing.Size(62, 20);
            this.lblBp_addr.TabIndex = 6;
            this.lblBp_addr.TabStop = false;
            this.lblBp_addr.Values.Text = "单位地址";
            // 
            // txt_bp_addr
            // 
            this.txt_bp_addr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_bp_addr.Location = new System.Drawing.Point(315, 47);
            this.txt_bp_addr.Name = "txt_bp_addr";
            this.txt_bp_addr.Size = new System.Drawing.Size(280, 26);
            this.txt_bp_addr.StateCommon.Back.Color1 = System.Drawing.Color.LightBlue;
            this.txt_bp_addr.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txt_bp_addr.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bp_addr.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_bp_addr.TabIndex = 7;
            // 
            // txt_bp_tax
            // 
            this.txt_bp_tax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_bp_tax.Location = new System.Drawing.Point(315, 115);
            this.txt_bp_tax.Name = "txt_bp_tax";
            this.txt_bp_tax.Size = new System.Drawing.Size(280, 26);
            this.txt_bp_tax.StateCommon.Back.Color1 = System.Drawing.Color.LightBlue;
            this.txt_bp_tax.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txt_bp_tax.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bp_tax.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_bp_tax.TabIndex = 15;
            // 
            // lblBp_tax
            // 
            this.lblBp_tax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBp_tax.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBp_tax.Location = new System.Drawing.Point(247, 118);
            this.lblBp_tax.Name = "lblBp_tax";
            this.lblBp_tax.Size = new System.Drawing.Size(36, 20);
            this.lblBp_tax.TabIndex = 14;
            this.lblBp_tax.TabStop = false;
            this.lblBp_tax.Values.Text = "税号";
            // 
            // txt_remark
            // 
            this.txt_remark.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnl_partner_info.SetColumnSpan(this.txt_remark, 2);
            this.txt_remark.Location = new System.Drawing.Point(721, 115);
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(334, 26);
            this.txt_remark.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_remark.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_remark.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_remark.TabIndex = 24;
            // 
            // cb_so_flag
            // 
            this.cb_so_flag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_so_flag.Location = new System.Drawing.Point(3, 3);
            this.cb_so_flag.Name = "cb_so_flag";
            this.cb_so_flag.Size = new System.Drawing.Size(88, 25);
            this.cb_so_flag.TabIndex = 0;
            this.cb_so_flag.Values.Text = "上游销售方";
            // 
            // lblRemark
            // 
            this.lblRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRemark.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblRemark.Location = new System.Drawing.Point(637, 114);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(62, 28);
            this.lblRemark.TabIndex = 23;
            this.lblRemark.TabStop = false;
            this.lblRemark.Values.Text = "备注信息";
            // 
            // txt_bp_email
            // 
            this.txt_bp_email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_bp_email.Location = new System.Drawing.Point(315, 81);
            this.txt_bp_email.Name = "txt_bp_email";
            this.txt_bp_email.Size = new System.Drawing.Size(280, 26);
            this.txt_bp_email.StateCommon.Back.Color1 = System.Drawing.Color.LightBlue;
            this.txt_bp_email.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txt_bp_email.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bp_email.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_bp_email.TabIndex = 13;
            // 
            // lblBp_repre
            // 
            this.lblBp_repre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBp_repre.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBp_repre.Location = new System.Drawing.Point(13, 84);
            this.lblBp_repre.Name = "lblBp_repre";
            this.lblBp_repre.Size = new System.Drawing.Size(49, 20);
            this.lblBp_repre.TabIndex = 8;
            this.lblBp_repre.TabStop = false;
            this.lblBp_repre.Values.Text = "联系人";
            // 
            // txt_bp_repre
            // 
            this.txt_bp_repre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_bp_repre.Location = new System.Drawing.Point(81, 81);
            this.txt_bp_repre.Name = "txt_bp_repre";
            this.txt_bp_repre.Size = new System.Drawing.Size(160, 26);
            this.txt_bp_repre.StateCommon.Back.Color1 = System.Drawing.Color.LightBlue;
            this.txt_bp_repre.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txt_bp_repre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bp_repre.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_bp_repre.TabIndex = 9;
            // 
            // lblBp_nm
            // 
            this.lblBp_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBp_nm.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBp_nm.Location = new System.Drawing.Point(13, 50);
            this.lblBp_nm.Name = "lblBp_nm";
            this.lblBp_nm.Size = new System.Drawing.Size(62, 20);
            this.lblBp_nm.TabIndex = 4;
            this.lblBp_nm.TabStop = false;
            this.lblBp_nm.Values.Text = "单位简称";
            // 
            // txt_bp_nm
            // 
            this.txt_bp_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_bp_nm.Location = new System.Drawing.Point(81, 47);
            this.txt_bp_nm.Name = "txt_bp_nm";
            this.txt_bp_nm.Size = new System.Drawing.Size(160, 26);
            this.txt_bp_nm.StateCommon.Back.Color1 = System.Drawing.Color.LightBlue;
            this.txt_bp_nm.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txt_bp_nm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bp_nm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_bp_nm.TabIndex = 5;
            // 
            // lblBp_type
            // 
            this.lblBp_type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBp_type.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBp_type.Location = new System.Drawing.Point(621, 13);
            this.lblBp_type.Name = "lblBp_type";
            this.lblBp_type.Size = new System.Drawing.Size(94, 27);
            this.lblBp_type.TabIndex = 16;
            this.lblBp_type.TabStop = false;
            this.lblBp_type.Values.Text = "往来单位类型";
            // 
            // cb_po_flag
            // 
            this.cb_po_flag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_po_flag.Location = new System.Drawing.Point(3, 34);
            this.cb_po_flag.Name = "cb_po_flag";
            this.cb_po_flag.Size = new System.Drawing.Size(88, 25);
            this.cb_po_flag.TabIndex = 1;
            this.cb_po_flag.Values.Text = "下游采购方";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblQuery_bp_type, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblQuery_bp_full_nm, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblQuery_bp_repre, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_query_bp_full_nm, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_query_bp_repre, 10, 1);
            this.tableLayoutPanel2.Controls.Add(this.rbtn_query_so, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.rbtn_query_po, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.rbtn_query_all, 6, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1378, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblQuery_bp_type
            // 
            this.lblQuery_bp_type.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuery_bp_type.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblQuery_bp_type.Location = new System.Drawing.Point(13, 17);
            this.lblQuery_bp_type.Name = "lblQuery_bp_type";
            this.lblQuery_bp_type.Size = new System.Drawing.Size(88, 20);
            this.lblQuery_bp_type.TabIndex = 0;
            this.lblQuery_bp_type.TabStop = false;
            this.lblQuery_bp_type.Values.Text = "往来单位类型";
            // 
            // lblQuery_bp_full_nm
            // 
            this.lblQuery_bp_full_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuery_bp_full_nm.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblQuery_bp_full_nm.Location = new System.Drawing.Point(347, 17);
            this.lblQuery_bp_full_nm.Name = "lblQuery_bp_full_nm";
            this.lblQuery_bp_full_nm.Size = new System.Drawing.Size(62, 20);
            this.lblQuery_bp_full_nm.TabIndex = 4;
            this.lblQuery_bp_full_nm.Values.Text = "单位名称";
            // 
            // lblQuery_bp_repre
            // 
            this.lblQuery_bp_repre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuery_bp_repre.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblQuery_bp_repre.Location = new System.Drawing.Point(701, 17);
            this.lblQuery_bp_repre.Name = "lblQuery_bp_repre";
            this.lblQuery_bp_repre.Size = new System.Drawing.Size(49, 20);
            this.lblQuery_bp_repre.TabIndex = 6;
            this.lblQuery_bp_repre.Values.Text = "联系人";
            // 
            // txt_query_bp_full_nm
            // 
            this.txt_query_bp_full_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_query_bp_full_nm.Location = new System.Drawing.Point(415, 14);
            this.txt_query_bp_full_nm.Name = "txt_query_bp_full_nm";
            this.txt_query_bp_full_nm.Size = new System.Drawing.Size(280, 26);
            this.txt_query_bp_full_nm.StateCommon.Back.Color1 = System.Drawing.Color.Snow;
            this.txt_query_bp_full_nm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_query_bp_full_nm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_query_bp_full_nm.TabIndex = 5;
            // 
            // txt_query_bp_repre
            // 
            this.txt_query_bp_repre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_query_bp_repre.Location = new System.Drawing.Point(756, 14);
            this.txt_query_bp_repre.Name = "txt_query_bp_repre";
            this.txt_query_bp_repre.Size = new System.Drawing.Size(160, 26);
            this.txt_query_bp_repre.StateCommon.Back.Color1 = System.Drawing.Color.Snow;
            this.txt_query_bp_repre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_query_bp_repre.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_query_bp_repre.TabIndex = 7;
            // 
            // rbtn_query_so
            // 
            this.rbtn_query_so.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtn_query_so.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.rbtn_query_so.Location = new System.Drawing.Point(107, 17);
            this.rbtn_query_so.Name = "rbtn_query_so";
            this.rbtn_query_so.Size = new System.Drawing.Size(87, 20);
            this.rbtn_query_so.TabIndex = 1;
            this.rbtn_query_so.Values.Text = "上游销售方";
            // 
            // rbtn_query_po
            // 
            this.rbtn_query_po.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtn_query_po.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.rbtn_query_po.Location = new System.Drawing.Point(200, 17);
            this.rbtn_query_po.Name = "rbtn_query_po";
            this.rbtn_query_po.Size = new System.Drawing.Size(87, 20);
            this.rbtn_query_po.TabIndex = 2;
            this.rbtn_query_po.Values.Text = "下游采购方";
            // 
            // rbtn_query_all
            // 
            this.rbtn_query_all.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtn_query_all.Checked = true;
            this.rbtn_query_all.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.rbtn_query_all.Location = new System.Drawing.Point(293, 17);
            this.rbtn_query_all.Name = "rbtn_query_all";
            this.rbtn_query_all.Size = new System.Drawing.Size(48, 20);
            this.rbtn_query_all.TabIndex = 3;
            this.rbtn_query_all.Values.Text = "全部";
            // 
            // lblBp_email
            // 
            this.lblBp_email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBp_email.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBp_email.Location = new System.Drawing.Point(247, 84);
            this.lblBp_email.Name = "lblBp_email";
            this.lblBp_email.Size = new System.Drawing.Size(62, 20);
            this.lblBp_email.TabIndex = 12;
            this.lblBp_email.Values.Text = "邮箱地址";
            // 
            // txt_bank_acct_no
            // 
            this.txt_bank_acct_no.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_bank_acct_no.Location = new System.Drawing.Point(815, 81);
            this.txt_bank_acct_no.Name = "txt_bank_acct_no";
            this.txt_bank_acct_no.Size = new System.Drawing.Size(240, 26);
            this.txt_bank_acct_no.StateCommon.Back.Color1 = System.Drawing.Color.LightBlue;
            this.txt_bank_acct_no.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txt_bank_acct_no.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bank_acct_no.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_bank_acct_no.TabIndex = 22;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.buttonSpecAny2.Image = global::SimpleERPSystem.Properties.Resources.bin_closed;
            this.buttonSpecAny2.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Command;
            this.buttonSpecAny2.UniqueName = "05D36F1A8E914D6EFB8AC7CF4400DC34";
            // 
            // lblPay_type
            // 
            this.lblPay_type.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPay_type.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblPay_type.Location = new System.Drawing.Point(721, 16);
            this.lblPay_type.Name = "lblPay_type";
            this.lblPay_type.Size = new System.Drawing.Size(88, 20);
            this.lblPay_type.TabIndex = 18;
            this.lblPay_type.Values.Text = "默认付款方式";
            // 
            // cbb_pay_type
            // 
            this.cbb_pay_type.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_pay_type.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.cbb_pay_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_pay_type.DropDownWidth = 127;
            this.cbb_pay_type.Location = new System.Drawing.Point(815, 13);
            this.cbb_pay_type.Name = "cbb_pay_type";
            this.cbb_pay_type.Size = new System.Drawing.Size(240, 26);
            this.cbb_pay_type.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightBlue;
            this.cbb_pay_type.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray;
            this.cbb_pay_type.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbb_pay_type.TabIndex = 19;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.buttonSpecAny1.Image = global::SimpleERPSystem.Properties.Resources.bin_closed;
            this.buttonSpecAny1.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Command;
            this.buttonSpecAny1.UniqueName = "B4BDF5BCA2E64FABAB962525C5B4AE52";
            // 
            // lblBank_acct_no
            // 
            this.lblBank_acct_no.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBank_acct_no.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBank_acct_no.Location = new System.Drawing.Point(721, 84);
            this.lblBank_acct_no.Name = "lblBank_acct_no";
            this.lblBank_acct_no.Size = new System.Drawing.Size(62, 20);
            this.lblBank_acct_no.TabIndex = 21;
            this.lblBank_acct_no.Values.Text = "银行账户";
            // 
            // lblBank_cd
            // 
            this.lblBank_cd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBank_cd.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBank_cd.Location = new System.Drawing.Point(721, 50);
            this.lblBank_cd.Name = "lblBank_cd";
            this.lblBank_cd.Size = new System.Drawing.Size(62, 20);
            this.lblBank_cd.TabIndex = 19;
            this.lblBank_cd.Values.Text = "银行编号";
            // 
            // cbb_bank_cd
            // 
            this.cbb_bank_cd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_bank_cd.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.cbb_bank_cd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_bank_cd.DropDownWidth = 127;
            this.cbb_bank_cd.Location = new System.Drawing.Point(815, 47);
            this.cbb_bank_cd.Name = "cbb_bank_cd";
            this.cbb_bank_cd.Size = new System.Drawing.Size(240, 26);
            this.cbb_bank_cd.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.LightBlue;
            this.cbb_bank_cd.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray;
            this.cbb_bank_cd.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbb_bank_cd.TabIndex = 20;
            // 
            // pnl_partner_info
            // 
            this.pnl_partner_info.AutoScroll = true;
            this.pnl_partner_info.AutoSize = true;
            this.pnl_partner_info.ColumnCount = 9;
            this.pnl_partner_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnl_partner_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl_partner_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl_partner_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl_partner_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl_partner_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_partner_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.pnl_partner_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl_partner_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnl_partner_info.Controls.Add(this.lblBp_cd, 1, 1);
            this.pnl_partner_info.Controls.Add(this.lblBp_full_nm, 3, 1);
            this.pnl_partner_info.Controls.Add(this.txt_bp_full_nm, 4, 1);
            this.pnl_partner_info.Controls.Add(this.txt_bp_addr, 4, 2);
            this.pnl_partner_info.Controls.Add(this.lblBp_repre, 1, 3);
            this.pnl_partner_info.Controls.Add(this.txt_bp_repre, 2, 3);
            this.pnl_partner_info.Controls.Add(this.lblBp_nm, 1, 2);
            this.pnl_partner_info.Controls.Add(this.txt_bp_nm, 2, 2);
            this.pnl_partner_info.Controls.Add(this.lblBp_type, 6, 1);
            this.pnl_partner_info.Controls.Add(this.txt_bank_acct_no, 8, 3);
            this.pnl_partner_info.Controls.Add(this.lblBank_acct_no, 7, 3);
            this.pnl_partner_info.Controls.Add(this.lblBank_cd, 7, 2);
            this.pnl_partner_info.Controls.Add(this.cbb_bank_cd, 8, 2);
            this.pnl_partner_info.Controls.Add(this.lblPay_type, 7, 1);
            this.pnl_partner_info.Controls.Add(this.cbb_pay_type, 8, 1);
            this.pnl_partner_info.Controls.Add(this.tableLayoutPanel4, 6, 2);
            this.pnl_partner_info.Controls.Add(this.lblBp_addr, 3, 2);
            this.pnl_partner_info.Controls.Add(this.lblBp_tel, 1, 4);
            this.pnl_partner_info.Controls.Add(this.txt_bp_tel, 2, 4);
            this.pnl_partner_info.Controls.Add(this.lblRemark, 6, 4);
            this.pnl_partner_info.Controls.Add(this.txt_remark, 7, 4);
            this.pnl_partner_info.Controls.Add(this.txt_bp_email, 4, 3);
            this.pnl_partner_info.Controls.Add(this.lblBp_email, 3, 3);
            this.pnl_partner_info.Controls.Add(this.lblBp_tax, 3, 4);
            this.pnl_partner_info.Controls.Add(this.txt_bp_tax, 4, 4);
            this.pnl_partner_info.Controls.Add(this.txt_bp_cd, 2, 1);
            this.pnl_partner_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_partner_info.Location = new System.Drawing.Point(3, 158);
            this.pnl_partner_info.Name = "pnl_partner_info";
            this.pnl_partner_info.RowCount = 6;
            this.pnl_partner_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnl_partner_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.pnl_partner_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnl_partner_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnl_partner_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.pnl_partner_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnl_partner_info.Size = new System.Drawing.Size(1378, 155);
            this.pnl_partner_info.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.cb_so_flag, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cb_po_flag, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(621, 46);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.pnl_partner_info.SetRowSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(94, 62);
            this.tableLayoutPanel4.TabIndex = 17;
            // 
            // lblBp_tel
            // 
            this.lblBp_tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBp_tel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBp_tel.Location = new System.Drawing.Point(13, 118);
            this.lblBp_tel.Name = "lblBp_tel";
            this.lblBp_tel.Size = new System.Drawing.Size(62, 20);
            this.lblBp_tel.TabIndex = 10;
            this.lblBp_tel.TabStop = false;
            this.lblBp_tel.Values.Text = "联系电话";
            // 
            // txt_bp_tel
            // 
            this.txt_bp_tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_bp_tel.Location = new System.Drawing.Point(81, 115);
            this.txt_bp_tel.Name = "txt_bp_tel";
            this.txt_bp_tel.Size = new System.Drawing.Size(160, 26);
            this.txt_bp_tel.StateCommon.Back.Color1 = System.Drawing.Color.LightBlue;
            this.txt_bp_tel.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txt_bp_tel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bp_tel.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_bp_tel.TabIndex = 11;
            // 
            // txt_bp_cd
            // 
            this.txt_bp_cd.Location = new System.Drawing.Point(81, 13);
            this.txt_bp_cd.Name = "txt_bp_cd";
            this.txt_bp_cd.Size = new System.Drawing.Size(160, 26);
            this.txt_bp_cd.StateCommon.Back.Color1 = System.Drawing.Color.LightBlue;
            this.txt_bp_cd.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txt_bp_cd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bp_cd.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txt_bp_cd.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_partner_info, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgView, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 861);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToResizeRows = false;
            this.dgView.ColumnHeadersHeight = 40;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bp_cd,
            this.bp_full_nm,
            this.bp_nm,
            this.bp_addr,
            this.bp_repre,
            this.bp_email,
            this.bp_tel,
            this.so_flag,
            this.po_flag,
            this.bp_tax,
            this.pay_type,
            this.pay_type_nm,
            this.bank_cd,
            this.bank_cd_nm,
            this.bank_acct_no,
            this.remark});
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgView.Location = new System.Drawing.Point(3, 362);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersWidth = 70;
            this.dgView.RowTemplate.Height = 30;
            this.dgView.Size = new System.Drawing.Size(1378, 496);
            this.dgView.TabIndex = 5;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // bp_cd
            // 
            this.bp_cd.DataPropertyName = "bp_cd";
            this.bp_cd.HeaderText = "单位编号";
            this.bp_cd.Name = "bp_cd";
            this.bp_cd.ReadOnly = true;
            this.bp_cd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bp_cd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bp_cd.ToolTipText = "单位编号";
            this.bp_cd.Width = 60;
            // 
            // bp_full_nm
            // 
            this.bp_full_nm.DataPropertyName = "bp_full_nm";
            this.bp_full_nm.HeaderText = "单位全称";
            this.bp_full_nm.Name = "bp_full_nm";
            this.bp_full_nm.ReadOnly = true;
            this.bp_full_nm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bp_full_nm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bp_full_nm.ToolTipText = "单位全称";
            this.bp_full_nm.Width = 200;
            // 
            // bp_nm
            // 
            this.bp_nm.DataPropertyName = "bp_nm";
            this.bp_nm.HeaderText = "单位简称";
            this.bp_nm.Name = "bp_nm";
            this.bp_nm.ReadOnly = true;
            this.bp_nm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bp_nm.ToolTipText = "单位简称";
            this.bp_nm.Width = 100;
            // 
            // bp_addr
            // 
            this.bp_addr.DataPropertyName = "bp_addr";
            this.bp_addr.HeaderText = "单位地址";
            this.bp_addr.Name = "bp_addr";
            this.bp_addr.ReadOnly = true;
            this.bp_addr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bp_addr.ToolTipText = "单位地址";
            this.bp_addr.Width = 200;
            // 
            // bp_repre
            // 
            this.bp_repre.DataPropertyName = "bp_repre";
            this.bp_repre.HeaderText = "联系人";
            this.bp_repre.Name = "bp_repre";
            this.bp_repre.ReadOnly = true;
            this.bp_repre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bp_repre.ToolTipText = "联系人";
            this.bp_repre.Width = 60;
            // 
            // bp_email
            // 
            this.bp_email.DataPropertyName = "bp_email";
            this.bp_email.HeaderText = "邮箱地址";
            this.bp_email.Name = "bp_email";
            this.bp_email.ReadOnly = true;
            this.bp_email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bp_email.ToolTipText = "邮箱地址";
            this.bp_email.Width = 100;
            // 
            // bp_tel
            // 
            this.bp_tel.DataPropertyName = "bp_tel";
            this.bp_tel.HeaderText = "联系电话";
            this.bp_tel.Name = "bp_tel";
            this.bp_tel.ReadOnly = true;
            this.bp_tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bp_tel.ToolTipText = "联系电话";
            this.bp_tel.Width = 100;
            // 
            // so_flag
            // 
            this.so_flag.DataPropertyName = "so_flag";
            this.so_flag.HeaderText = "上游销售方";
            this.so_flag.Name = "so_flag";
            this.so_flag.ReadOnly = true;
            this.so_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.so_flag.ToolTipText = "上游销售方";
            this.so_flag.Width = 80;
            // 
            // po_flag
            // 
            this.po_flag.DataPropertyName = "po_flag";
            this.po_flag.HeaderText = "下游采购方";
            this.po_flag.Name = "po_flag";
            this.po_flag.ReadOnly = true;
            this.po_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.po_flag.ToolTipText = "下游采购方";
            this.po_flag.Width = 80;
            // 
            // bp_tax
            // 
            this.bp_tax.DataPropertyName = "bp_tax";
            this.bp_tax.HeaderText = "税号";
            this.bp_tax.Name = "bp_tax";
            this.bp_tax.ReadOnly = true;
            this.bp_tax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bp_tax.Width = 100;
            // 
            // pay_type
            // 
            this.pay_type.DataPropertyName = "pay_type";
            this.pay_type.HeaderText = "付款方式编号";
            this.pay_type.Name = "pay_type";
            this.pay_type.ReadOnly = true;
            this.pay_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pay_type.Width = 100;
            // 
            // pay_type_nm
            // 
            this.pay_type_nm.DataPropertyName = "pay_type_nm";
            this.pay_type_nm.HeaderText = "付款方式名称";
            this.pay_type_nm.Name = "pay_type_nm";
            this.pay_type_nm.ReadOnly = true;
            this.pay_type_nm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pay_type_nm.ToolTipText = "付款方式名称";
            // 
            // bank_cd
            // 
            this.bank_cd.DataPropertyName = "bank_cd";
            this.bank_cd.HeaderText = "银行编号";
            this.bank_cd.Name = "bank_cd";
            this.bank_cd.ReadOnly = true;
            this.bank_cd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bank_cd.ToolTipText = "银行编号";
            this.bank_cd.Width = 60;
            // 
            // bank_cd_nm
            // 
            this.bank_cd_nm.DataPropertyName = "bank_cd_nm";
            this.bank_cd_nm.HeaderText = "银行名称";
            this.bank_cd_nm.Name = "bank_cd_nm";
            this.bank_cd_nm.ReadOnly = true;
            this.bank_cd_nm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bank_cd_nm.ToolTipText = "银行名称";
            this.bank_cd_nm.Width = 80;
            // 
            // bank_acct_no
            // 
            this.bank_acct_no.DataPropertyName = "bank_acct_no";
            this.bank_acct_no.HeaderText = "银行账户";
            this.bank_acct_no.Name = "bank_acct_no";
            this.bank_acct_no.ReadOnly = true;
            this.bank_acct_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bank_acct_no.ToolTipText = "银行账户";
            this.bank_acct_no.Width = 160;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注信息";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.remark.ToolTipText = "备注信息";
            this.remark.Width = 200;
            // 
            // FrmPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPartner";
            this.Text = "往来单位信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPartner_FormClosing);
            this.Load += new System.EventHandler(this.FrmPartner_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_pay_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_bank_cd)).EndInit();
            this.pnl_partner_info.ResumeLayout(false);
            this.pnl_partner_info.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBp_cd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSave;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader3;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBp_full_nm;
        private ERP_CL.ERP_TextBox txt_bp_full_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBp_addr;
        private ERP_CL.ERP_TextBox txt_bp_addr;
        private ERP_CL.ERP_TextBox txt_bp_tax;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBp_tax;
        private ERP_CL.ERP_TextBox txt_remark;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cb_so_flag;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRemark;
        private ERP_CL.ERP_TextBox txt_bp_email;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBp_repre;
        private ERP_CL.ERP_TextBox txt_bp_repre;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBp_nm;
        private ERP_CL.ERP_TextBox txt_bp_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBp_type;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cb_po_flag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblQuery_bp_type;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblQuery_bp_full_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblQuery_bp_repre;
        private ERP_CL.ERP_TextBox txt_query_bp_full_nm;
        private ERP_CL.ERP_TextBox txt_query_bp_repre;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBp_email;
        private ERP_CL.ERP_TextBox txt_bank_acct_no;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPay_type;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_pay_type;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBank_acct_no;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBank_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_bank_cd;
        private System.Windows.Forms.TableLayoutPanel pnl_partner_info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgView;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBp_tel;
        private ERP_CL.ERP_TextBox txt_bp_tel;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbtn_query_so;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbtn_query_po;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rbtn_query_all;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_bp_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_full_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_addr;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_repre;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_email;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_tel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn so_flag;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn po_flag;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_tax;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn pay_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_type_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bank_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bank_cd_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bank_acct_no;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn remark;
    }
}