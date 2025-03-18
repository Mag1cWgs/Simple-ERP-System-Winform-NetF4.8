namespace SimpleERPSystem.BaseInfo
{
    partial class FrmMajor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMajor));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnDelRow = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnAddRow = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMajor_cd = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtMajor_cd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnDelMajor_cd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lblMajor_nm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtMajor_nm = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnDelMajor_nm = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dgView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idu = new System.Windows.Forms.DataGridViewImageColumn();
            this.major_cd = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.major_nm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.kryptonHeader2.TabIndex = 2;
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
            this.kryptonHeader1.TabIndex = 0;
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::SimpleERPSystem.Properties.Resources.table_tab_search1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UniqueName = "E71D77C7579343E5759C571694F484BB";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblMajor_cd, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMajor_cd, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMajor_nm, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMajor_nm, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1378, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblMajor_cd
            // 
            this.lblMajor_cd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMajor_cd.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblMajor_cd.Location = new System.Drawing.Point(13, 17);
            this.lblMajor_cd.Name = "lblMajor_cd";
            this.lblMajor_cd.Size = new System.Drawing.Size(75, 20);
            this.lblMajor_cd.TabIndex = 0;
            this.lblMajor_cd.Values.Text = "主代码编号";
            // 
            // txtMajor_cd
            // 
            this.txtMajor_cd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMajor_cd.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDelMajor_cd});
            this.txtMajor_cd.Location = new System.Drawing.Point(94, 14);
            this.txtMajor_cd.Name = "txtMajor_cd";
            this.txtMajor_cd.Size = new System.Drawing.Size(130, 26);
            this.txtMajor_cd.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txtMajor_cd.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtMajor_cd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMajor_cd.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txtMajor_cd.TabIndex = 1;
            // 
            // btnDelMajor_cd
            // 
            this.btnDelMajor_cd.Image = global::SimpleERPSystem.Properties.Resources.bin_closed;
            this.btnDelMajor_cd.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.btnDelMajor_cd.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.btnDelMajor_cd.UniqueName = "5120F1F90130417A42A423F2264257A5";
            this.btnDelMajor_cd.Click += new System.EventHandler(this.btnDelMajor_cd_Click);
            // 
            // lblMajor_nm
            // 
            this.lblMajor_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMajor_nm.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblMajor_nm.Location = new System.Drawing.Point(230, 17);
            this.lblMajor_nm.Name = "lblMajor_nm";
            this.lblMajor_nm.Size = new System.Drawing.Size(75, 20);
            this.lblMajor_nm.TabIndex = 2;
            this.lblMajor_nm.Values.Text = "主代码名称";
            // 
            // txtMajor_nm
            // 
            this.txtMajor_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMajor_nm.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDelMajor_nm});
            this.txtMajor_nm.Location = new System.Drawing.Point(311, 14);
            this.txtMajor_nm.Name = "txtMajor_nm";
            this.txtMajor_nm.Size = new System.Drawing.Size(130, 26);
            this.txtMajor_nm.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txtMajor_nm.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.txtMajor_nm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMajor_nm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txtMajor_nm.TabIndex = 3;
            // 
            // btnDelMajor_nm
            // 
            this.btnDelMajor_nm.Image = global::SimpleERPSystem.Properties.Resources.bin_closed;
            this.btnDelMajor_nm.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.btnDelMajor_nm.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.btnDelMajor_nm.UniqueName = "5120F1F90130417A42A423F2264257A5";
            this.btnDelMajor_nm.Click += new System.EventHandler(this.btnDelMajor_nm_Click);
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
            this.major_cd,
            this.major_nm,
            this.remark});
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgView.Location = new System.Drawing.Point(3, 158);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 70;
            this.dgView.RowTemplate.Height = 30;
            this.dgView.Size = new System.Drawing.Size(1378, 700);
            this.dgView.TabIndex = 3;
            this.dgView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgView_CellBeginEdit);
            this.dgView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellEndEdit);
            // 
            // idu
            // 
            this.idu.HeaderText = "";
            this.idu.Image = global::SimpleERPSystem.Properties.Resources.table;
            this.idu.Name = "idu";
            this.idu.ReadOnly = true;
            this.idu.Width = 30;
            // 
            // major_cd
            // 
            this.major_cd.DataPropertyName = "major_cd";
            this.major_cd.HeaderText = "主代码编号";
            this.major_cd.Name = "major_cd";
            this.major_cd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.major_cd.ToolTipText = "主代码编号";
            this.major_cd.Width = 100;
            // 
            // major_nm
            // 
            this.major_nm.DataPropertyName = "major_nm";
            this.major_nm.HeaderText = "主代码名称";
            this.major_nm.Name = "major_nm";
            this.major_nm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.major_nm.ToolTipText = "主代码名称";
            this.major_nm.Width = 150;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注信息";
            this.remark.Name = "remark";
            this.remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.remark.ToolTipText = "备注信息";
            this.remark.Width = 300;
            // 
            // FrmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMajor";
            this.Text = "主代码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMajor_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSearch;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSave;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelRow;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnAddRow;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMajor_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMajor_cd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelMajor_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblMajor_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMajor_nm;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelMajor_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgView;
        private System.Windows.Forms.DataGridViewImageColumn idu;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn major_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn major_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn remark;
    }
}