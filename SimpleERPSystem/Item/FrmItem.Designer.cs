namespace SimpleERPSystem.Item
{
    partial class FrmItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItem));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnDelRow = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnAddRow = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblItem_nm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtItem_nm = new ERP_CL.ERP_TextBox();
            this.txtItem_group = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSearchMajor_cd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lblItem_group = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtItem_group_nm = new ERP_CL.ERP_TextBox();
            this.dgView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idu = new System.Windows.Forms.DataGridViewImageColumn();
            this.item_cd = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.item_nm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.item_spec = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.item_price = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.item_unit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.btn_unit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.item_unit_nm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.item_group = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.btn_group = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.item_group_nm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.sl_cd = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.btn_sl = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.sl_nm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.remark = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgView, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1384, 861);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader2.Location = new System.Drawing.Point(3, 115);
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
            this.kryptonHeader2.TabIndex = 1;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "查询结果";
            this.kryptonHeader2.Values.Image = global::SimpleERPSystem.Properties.Resources.table1;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDelRow,
            this.btnAddRow,
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
            this.kryptonHeader1.TabIndex = 3;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "";
            this.kryptonHeader1.Values.Image = null;
            // 
            // btnDelRow
            // 
            this.btnDelRow.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnDelRow.Image = global::SimpleERPSystem.Properties.Resources.table_row_delete1;
            this.btnDelRow.Text = "删除行";
            this.btnDelRow.UniqueName = "640999D05B8443CBFCAAD82EFA7B1CCA";
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnAddRow.Image = global::SimpleERPSystem.Properties.Resources.table_row_insert1;
            this.btnAddRow.Text = "添加行";
            this.btnAddRow.UniqueName = "E60FBF8FD534468531B932B1EE9E31C5";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSave.Image = global::SimpleERPSystem.Properties.Resources.table_save1;
            this.btnSave.Text = "保存";
            this.btnSave.UniqueName = "96E47CDE5C0C4AE45CAE8240EB0581C7";
            // 
            // btnSearch
            // 
            this.btnSearch.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::SimpleERPSystem.Properties.Resources.table_tab_search1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UniqueName = "E71D77C7579343E5759C571694F484BB";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblItem_nm, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtItem_nm, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtItem_group, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblItem_group, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtItem_group_nm, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1378, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblItem_nm
            // 
            this.lblItem_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItem_nm.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblItem_nm.Location = new System.Drawing.Point(13, 17);
            this.lblItem_nm.Name = "lblItem_nm";
            this.lblItem_nm.Size = new System.Drawing.Size(62, 20);
            this.lblItem_nm.TabIndex = 0;
            this.lblItem_nm.Values.Text = "商品名称";
            // 
            // txtItem_nm
            // 
            this.txtItem_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItem_nm.Location = new System.Drawing.Point(81, 14);
            this.txtItem_nm.Name = "txtItem_nm";
            this.txtItem_nm.Size = new System.Drawing.Size(200, 26);
            this.txtItem_nm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtItem_nm.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txtItem_nm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtItem_nm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txtItem_nm.TabIndex = 1;
            this.txtItem_nm.Text = "txtItem_nm";
            // 
            // txtItem_group
            // 
            this.txtItem_group.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItem_group.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnSearchMajor_cd});
            this.txtItem_group.Location = new System.Drawing.Point(355, 14);
            this.txtItem_group.Name = "txtItem_group";
            this.txtItem_group.ReadOnly = true;
            this.txtItem_group.Size = new System.Drawing.Size(150, 26);
            this.txtItem_group.StateCommon.Back.Color1 = System.Drawing.Color.Snow;
            this.txtItem_group.StateCommon.Border.Color1 = System.Drawing.Color.OrangeRed;
            this.txtItem_group.StateCommon.Border.Color2 = System.Drawing.Color.MistyRose;
            this.txtItem_group.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtItem_group.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txtItem_group.TabIndex = 3;
            // 
            // btnSearchMajor_cd
            // 
            this.btnSearchMajor_cd.Image = global::SimpleERPSystem.Properties.Resources.bullet_magnify;
            this.btnSearchMajor_cd.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.btnSearchMajor_cd.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.btnSearchMajor_cd.UniqueName = "5120F1F90130417A42A423F2264257A5";
            // 
            // lblItem_group
            // 
            this.lblItem_group.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItem_group.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblItem_group.Location = new System.Drawing.Point(287, 17);
            this.lblItem_group.Name = "lblItem_group";
            this.lblItem_group.Size = new System.Drawing.Size(62, 20);
            this.lblItem_group.TabIndex = 2;
            this.lblItem_group.Values.Text = "商品分类";
            // 
            // txtItem_group_nm
            // 
            this.txtItem_group_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItem_group_nm.Location = new System.Drawing.Point(511, 14);
            this.txtItem_group_nm.Name = "txtItem_group_nm";
            this.txtItem_group_nm.Size = new System.Drawing.Size(200, 26);
            this.txtItem_group_nm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtItem_group_nm.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txtItem_group_nm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtItem_group_nm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txtItem_group_nm.TabIndex = 4;
            this.txtItem_group_nm.Text = "txtItem_group_nm";
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.AllowUserToResizeRows = false;
            this.dgView.ColumnHeadersHeight = 40;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idu,
            this.item_cd,
            this.item_nm,
            this.item_spec,
            this.item_price,
            this.item_unit,
            this.btn_unit,
            this.item_unit_nm,
            this.item_group,
            this.btn_group,
            this.item_group_nm,
            this.sl_cd,
            this.btn_sl,
            this.sl_nm,
            this.remark});
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgView.Location = new System.Drawing.Point(3, 158);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 70;
            this.dgView.RowTemplate.Height = 30;
            this.dgView.Size = new System.Drawing.Size(1378, 700);
            this.dgView.TabIndex = 2;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // idu
            // 
            this.idu.HeaderText = "";
            this.idu.Image = global::SimpleERPSystem.Properties.Resources.table;
            this.idu.Name = "idu";
            this.idu.ReadOnly = true;
            this.idu.Width = 30;
            // 
            // item_cd
            // 
            this.item_cd.DataPropertyName = "item_cd";
            this.item_cd.HeaderText = "商品编号";
            this.item_cd.Name = "item_cd";
            this.item_cd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_cd.ToolTipText = "商品编号";
            this.item_cd.Width = 100;
            // 
            // item_nm
            // 
            this.item_nm.DataPropertyName = "item_nm";
            this.item_nm.HeaderText = "商品名称";
            this.item_nm.Name = "item_nm";
            this.item_nm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_nm.ToolTipText = "商品名称";
            this.item_nm.Width = 150;
            // 
            // item_spec
            // 
            this.item_spec.DataPropertyName = "item_spec";
            this.item_spec.HeaderText = "规格";
            this.item_spec.Name = "item_spec";
            this.item_spec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_spec.ToolTipText = "规格";
            this.item_spec.Width = 150;
            // 
            // item_price
            // 
            this.item_price.DataPropertyName = "item_price";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N4";
            dataGridViewCellStyle1.NullValue = null;
            this.item_price.DefaultCellStyle = dataGridViewCellStyle1;
            this.item_price.HeaderText = "参照单价";
            this.item_price.Name = "item_price";
            this.item_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_price.ToolTipText = "参照单价";
            this.item_price.Width = 100;
            // 
            // item_unit
            // 
            this.item_unit.DataPropertyName = "item_unit";
            this.item_unit.HeaderText = "计量单位";
            this.item_unit.Name = "item_unit";
            this.item_unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_unit.ToolTipText = "计量单位";
            this.item_unit.Width = 60;
            // 
            // btn_unit
            // 
            this.btn_unit.HeaderText = "";
            this.btn_unit.Name = "btn_unit";
            this.btn_unit.Width = 30;
            // 
            // item_unit_nm
            // 
            this.item_unit_nm.HeaderText = "单位名称";
            this.item_unit_nm.Name = "item_unit_nm";
            this.item_unit_nm.ReadOnly = true;
            this.item_unit_nm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_unit_nm.Width = 60;
            // 
            // item_group
            // 
            this.item_group.DataPropertyName = "item_group";
            this.item_group.HeaderText = "商品分类";
            this.item_group.Name = "item_group";
            this.item_group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_group.ToolTipText = "商品分类";
            this.item_group.Width = 100;
            // 
            // btn_group
            // 
            this.btn_group.HeaderText = "";
            this.btn_group.Name = "btn_group";
            this.btn_group.Width = 30;
            // 
            // item_group_nm
            // 
            this.item_group_nm.HeaderText = "分类名称";
            this.item_group_nm.Name = "item_group_nm";
            this.item_group_nm.ReadOnly = true;
            this.item_group_nm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_group_nm.Width = 60;
            // 
            // sl_cd
            // 
            this.sl_cd.DataPropertyName = "sl_cd";
            this.sl_cd.HeaderText = "商品仓库";
            this.sl_cd.Name = "sl_cd";
            this.sl_cd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sl_cd.ToolTipText = "商品仓库";
            this.sl_cd.Width = 150;
            // 
            // btn_sl
            // 
            this.btn_sl.HeaderText = "";
            this.btn_sl.Name = "btn_sl";
            this.btn_sl.Width = 30;
            // 
            // sl_nm
            // 
            this.sl_nm.HeaderText = "仓库名称";
            this.sl_nm.Name = "sl_nm";
            this.sl_nm.ReadOnly = true;
            this.sl_nm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sl_nm.Width = 60;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注信息";
            this.remark.Name = "remark";
            this.remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.remark.ToolTipText = "备注信息";
            this.remark.Width = 200;
            // 
            // FrmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmItem";
            this.Text = "商品信息";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelRow;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnAddRow;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSave;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblItem_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtItem_group;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSearchMajor_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgView;
        private ERP_CL.ERP_TextBox txtItem_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblItem_group;
        private ERP_CL.ERP_TextBox txtItem_group_nm;
        private System.Windows.Forms.DataGridViewImageColumn idu;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn item_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn item_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn item_spec;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn item_price;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn item_unit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn btn_unit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn item_unit_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn item_group;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn btn_group;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn item_group_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn sl_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn btn_sl;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn sl_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn remark;
    }
}