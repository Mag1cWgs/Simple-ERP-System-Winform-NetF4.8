﻿namespace SimpleERPSystem.Base
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
            this.tbMajor_cd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnDelTbText = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader2.Location = new System.Drawing.Point(3, 149);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(794, 40);
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
            this.kryptonHeader2.Values.Image = global::SimpleERPSystem.Properties.Resources.table;
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
            this.kryptonHeader1.Size = new System.Drawing.Size(794, 46);
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
            this.btnDelRow.Image = global::SimpleERPSystem.Properties.Resources.table_row_delete;
            this.btnDelRow.Text = "删除行";
            this.btnDelRow.UniqueName = "640999D05B8443CBFCAAD82EFA7B1CCA";
            // 
            // btnAddRow
            // 
            this.btnAddRow.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnAddRow.Image = global::SimpleERPSystem.Properties.Resources.table_row_insert;
            this.btnAddRow.Text = "添加行";
            this.btnAddRow.UniqueName = "E60FBF8FD534468531B932B1EE9E31C5";
            // 
            // btnSave
            // 
            this.btnSave.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSave.Image = global::SimpleERPSystem.Properties.Resources.table_save;
            this.btnSave.Text = "保存";
            this.btnSave.UniqueName = "96E47CDE5C0C4AE45CAE8240EB0581C7";
            // 
            // btnSearch
            // 
            this.btnSearch.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::SimpleERPSystem.Properties.Resources.table_tab_search;
            this.btnSearch.Text = "查询";
            this.btnSearch.UniqueName = "E71D77C7579343E5759C571694F484BB";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblMajor_cd, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbMajor_cd, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 88);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblMajor_cd
            // 
            this.lblMajor_cd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMajor_cd.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblMajor_cd.Location = new System.Drawing.Point(13, 17);
            this.lblMajor_cd.Name = "lblMajor_cd";
            this.lblMajor_cd.Size = new System.Drawing.Size(49, 20);
            this.lblMajor_cd.TabIndex = 0;
            this.lblMajor_cd.Values.Text = "主代码";
            // 
            // tbMajor_cd
            // 
            this.tbMajor_cd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbMajor_cd.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDelTbText});
            this.tbMajor_cd.Location = new System.Drawing.Point(68, 14);
            this.tbMajor_cd.Name = "tbMajor_cd";
            this.tbMajor_cd.Size = new System.Drawing.Size(162, 26);
            this.tbMajor_cd.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.tbMajor_cd.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.tbMajor_cd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbMajor_cd.StateCommon.Content.Padding = new System.Windows.Forms.Padding(4);
            this.tbMajor_cd.TabIndex = 1;
            // 
            // btnDelTbText
            // 
            this.btnDelTbText.Image = global::SimpleERPSystem.Properties.Resources.bin_closed;
            this.btnDelTbText.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.btnDelTbText.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.btnDelTbText.UniqueName = "5120F1F90130417A42A423F2264257A5";
            // 
            // FrmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMajor";
            this.Text = "主代码";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbMajor_cd;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnDelTbText;
    }
}