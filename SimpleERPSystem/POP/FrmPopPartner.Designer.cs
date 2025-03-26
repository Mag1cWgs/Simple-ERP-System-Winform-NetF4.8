namespace SimpleERPSystem.POP
{
    partial class FrmPopPartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopPartner));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBp_nm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtBp_nm = new ERP_CL.ERP_TextBox();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.bp_cd = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bp_full_nm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.bp_nm = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.remark = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblBp_nm, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBp_nm, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(618, 54);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblBp_nm
            // 
            this.lblBp_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBp_nm.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBp_nm.Location = new System.Drawing.Point(13, 17);
            this.lblBp_nm.Name = "lblBp_nm";
            this.lblBp_nm.Size = new System.Drawing.Size(62, 20);
            this.lblBp_nm.TabIndex = 0;
            this.lblBp_nm.Values.Text = "往来名称";
            // 
            // txtBp_nm
            // 
            this.txtBp_nm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBp_nm.Location = new System.Drawing.Point(81, 14);
            this.txtBp_nm.Name = "txtBp_nm";
            this.txtBp_nm.Size = new System.Drawing.Size(160, 26);
            this.txtBp_nm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBp_nm.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txtBp_nm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBp_nm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.txtBp_nm.TabIndex = 4;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader2.Location = new System.Drawing.Point(3, 115);
            this.kryptonHeader2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(618, 40);
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
            this.btnSearch});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader1.Location = new System.Drawing.Point(3, 3);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(618, 46);
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
            // btnSearch
            // 
            this.btnSearch.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::SimpleERPSystem.Properties.Resources.table_tab_search1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UniqueName = "E71D77C7579343E5759C571694F484BB";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 441);
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
            this.remark});
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgView.Location = new System.Drawing.Point(3, 158);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.RowHeadersWidth = 70;
            this.dgView.RowTemplate.Height = 30;
            this.dgView.Size = new System.Drawing.Size(618, 280);
            this.dgView.TabIndex = 6;
            this.dgView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellDoubleClick);
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
            // FrmPopPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPopPartner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "往来单位信息查询";
            this.Load += new System.EventHandler(this.FrmPopPartner_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBp_nm;
        private ERP_CL.ERP_TextBox txtBp_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgView;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_cd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_full_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn bp_nm;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn remark;
    }
}