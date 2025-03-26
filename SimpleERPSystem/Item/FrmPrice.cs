using ERP_BLL;
using ERP_MODEL;
using NPOI.OpenXmlFormats.Vml;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using SimpleERPSystem.POP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SimpleERPSystem.Item
{
    public partial class FrmPrice : DockContent
    {
        #region 窗体函数与事件
        public FrmPrice()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   窗体关闭时，判断是否有未保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing
                || e.CloseReason == CloseReason.MdiFormClosing)
            {
                if (HasNoSavedData())  // 存在未保存数据，提示用户是否继续关闭
                {
                    DialogResult dr = B_message_BLL.ShowYesOrNo("2101");
                    if (dr == DialogResult.No) // 用户选择 No 时，取消关闭窗体
                    {
                        e.Cancel = true;  // 取消 FormClosing 事件，默认为 false
                        return;
                    }
                    else  // 用户选择 Yes 时，确认关闭窗体(默认发生)
                    {
                        e.Cancel = false;  // 确认关闭窗体
                        return;
                    }
                }
            }
        }

        #endregion


        #region 辅助字段 minor_cd_query / minor_nm_query / str_old / str_new / Query() / HasNoSavedData()

        public static string minor_cd_query, minor_nm_query, bp_cd_query, bp_nm_query;
        string str_old, str_new;
        public static DataGridViewRow drRow;

        B_item_price_BLL bll = new B_item_price_BLL();

        void Query()
        {
            B_item_price b_Item_Price = new B_item_price()
            {
                bp_cd = this.txtBp_cd.Text.Trim()
            };

            B_item b_item_model = new B_item()
            {
                item_nm = this.txtItem_nm.Text.Trim(),
                item_group = this.txtItem_group.Text.Trim()
            };
            DataTable dt = bll.Get_B_Item_Price(b_Item_Price, b_item_model);
            dgView.DataSource = dt;

            // 设置主代码列为只读，添加进来的新行的主代码列仍可以编辑，需要另外设置
            foreach (DataGridViewRow row in dgView.Rows)
            {
                row.Cells[item_cd.Name].ReadOnly = true;
            }

            // 先绑定数据源，再判断是否有数据
            if (dt.Rows.Count == 0)
            {
                B_message_BLL.ShowConfirm("1002");
            }
        }

        /// <summary>
        /// 判断当前 DataGridView 是否有尚未保存的数据
        /// <para>
        ///     存在未保存数据但要刷新或关闭表格时，会弹出提示框，提示用户是否继续操作。
        /// </para>
        /// </summary>
        /// <returns>
        ///     返回 <c>True</c> 说明存在未保存数据，需要进一步处理；
        ///     返回 <c>False</c> 不存在未保存数据，可以直接查询或关闭窗体。
        /// </returns>
        private bool HasNoSavedData()
        {
            foreach (DataGridViewRow row in dgView.Rows)
            {   // 如果有未保存的数据，直接返回 true
                if (row.Cells["idu"].ToolTipText != "")
                    return true;
            }
            return false;
        }
        #endregion

        #region dgView编辑事件 dgView_CellBeginEdit dgView_CellEndEdit dgView_CellClick

        /// <summary>
        ///    修改表格内容时，记录修改前的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            str_old = String.Empty;
            // 获取当前单元格的值，如果为空则赋值为空字符串
            str_old = dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null
                ? "" : dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            // 实际可优化 dgView[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        /// <summary>
        ///     修改表格内容时，记录修改后的值，并标记为Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            str_new = String.Empty;
            str_new = dgView[e.ColumnIndex, e.RowIndex].Value == null
                ? "" : dgView[e.ColumnIndex, e.RowIndex].Value.ToString();
            /* 如果前后的值不一样，且当前行没有标记，则标记为Update
             * 对查询结果：修改值后标记为Update，已标记删除的行仍为Delete，后续追加删除仍会覆盖为Delete
             * 对新增行：默认有Insert标记，不标记为Update               */
            if (str_old != str_new && dgView.Rows[e.RowIndex].Cells["idu"].ToolTipText == "")
            {
                dgView.Rows[e.RowIndex].Cells["idu"].Value = Properties.Resources.table_edit;
                dgView.Rows[e.RowIndex].Cells["idu"].ToolTipText = "Update";
            }
        }


        /// <summary>
        ///    单元格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            string str_old = null;
            // 点击单位时弹出选择窗口
            if (dgView.Columns[e.ColumnIndex].Name == btn_item.Name)
            {
                // 实例化一个单位对象
                B_partner b_Partner = new B_partner()
                {
                    bp_cd = txtBp_cd.Text.Trim(),
                    bp_nm = txtBp_nm.Text.Trim()
                };
                // 弹出单位选择窗口
                FrmPopItem frmPopItem = new FrmPopItem(b_Partner);
                frmPopItem.Owner = this;
                frmPopItem.ShowDialog();
                // 若选择了单位，则将选择的单位填入表格
                if (FrmPrice.drRow != null)
                {
                    dgView[item_cd.Name, e.RowIndex].Value = drRow.Cells[item_cd.Name].Value;
                    dgView[item_nm.Name, e.RowIndex].Value = drRow.Cells[item_nm.Name].Value;
                    dgView[item_spec.Name, e.RowIndex].Value = drRow.Cells[item_spec.Name].Value;
                    dgView[item_price.Name, e.RowIndex].Value = drRow.Cells[item_price.Name].Value;
                    dgView[item_group_nm.Name, e.RowIndex].Value = drRow.Cells[item_group_nm.Name].Value;
                    dgView[item_unit_nm.Name, e.RowIndex].Value = drRow.Cells[item_unit_nm.Name].Value;
                }
                drRow = null;
            }
        }

        #endregion


        #region 表格加行/删行按钮
        /// <summary>
        ///     加行按钮，添加一行空白行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="2000: 缺少必填信息"/>
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            // 判断是否输入了 往来单位代码 和 往来单位名称
            if (string.IsNullOrEmpty(txtBp_cd.Text.Trim()) || string.IsNullOrEmpty(txtBp_nm.Text.Trim()))
            {
                B_message_BLL.ShowConfirm("2000");
                return;
            }

            if (dgView.DataSource == null)
            {
                dgView.Rows.Add(); // 直接添加行
            }
            else
            {
                ((DataTable)dgView.DataSource).Rows.Add();
            }

            dgView.Rows[dgView.Rows.Count - 1].Cells["bp_cd"].Value = txtBp_cd.Text.Trim();
            dgView.Rows[dgView.Rows.Count - 1].Cells["bp_nm"].Value = txtBp_nm.Text.Trim();

            dgView.Rows[dgView.Rows.Count - 1].Cells["idu"].Value = Properties.Resources.table_row_insert;
            dgView.Rows[dgView.Rows.Count - 1].Cells["idu"].ToolTipText = "Insert";
        }

        /// <summary>
        ///     删除行按钮，删除选中行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgView.SelectedRows)
            {
                if (row.Cells["idu"].ToolTipText == "Insert")
                {   // 删除新增行
                    dgView.Rows.Remove(row);
                }
                else
                {   // 对原有行进行标记
                    row.Cells["idu"].Value = Properties.Resources.table_row_delete;
                    row.Cells["idu"].ToolTipText = "Delete";
                }
            }
        }

        #endregion

        #region 保存按钮 btnSave_Click / 查询按钮 btnSearch_Click / 查询分类按钮 btnSearchMajor_cd_Click
        /// <summary>
        ///   查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="2000: 缺少必填信息"/>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBp_cd.Text.Trim()))
            {
                B_message_BLL.ShowConfirm("2000");
                return;
            }
            if (HasNoSavedData())
            {
                DialogResult result = B_message_BLL.ShowYesOrNo("2101");
                if (result == DialogResult.Yes)
                    Query();
            }
            else
            {
                Query();
            }

        }

        /// <summary>
        ///    保存按钮，保存表格内容。
        ///    若操作成功会触发保存成功提示框 (<c>0001</c>)。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        ///     若保存失败会触发两次提示框：一是失败原因，二是具体失败的操作(插入/删除/更新)。
        /// </remarks>
        /// <exception cref="1003: 未找到要插入的数据"/>
        /// <exception cref="1004: 未找到要删除的数据"/>
        /// <exception cref="1005: 未找到要更新的数据"/>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 数据封装
            B_item_price model = new B_item_price();
            // 数据保存
            foreach (DataGridViewRow row in dgView.Rows)
            {
                model.bp_cd = (row.Cells[bp_cd.Name].Value == null)
                                ? "" : row.Cells[bp_cd.Name].Value.ToString();
                model.item_cd = (row.Cells[item_cd.Name].Value == null)
                                ? "" : row.Cells[item_cd.Name].Value.ToString();
                if (row.Cells[item_price.Name].Value == null || row.Cells[item_price.Name].Value.ToString() == "")
                    model.item_price = null;
                else
                    model.item_price = Convert.ToDecimal(row.Cells[item_price.Name].Value);
                model.remark = (row.Cells[remark.Name].Value == null)
                                ? "" : row.Cells[remark.Name].Value.ToString();
                model.user_cd = FrmMain.user_id;

                // 根据标记进行增删改操作
                bool hasException = false;
                switch (row.Cells["idu"].ToolTipText)
                {
                    case "":    // 无标记
                        break;
                    case "Insert":  // 新增操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Insert_B_Item_Price(model))
                        {
                            B_message_BLL.ShowConfirm("1003");
                            hasException = true;
                        }
                        break;
                    case "Update":  // 修改操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Update_B_Item_Price(model))
                        {
                            B_message_BLL.ShowConfirm("1005");
                            hasException = true;
                        }
                        break;
                    case "Delete":  // 删除操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Delete_B_Item_Price(model))
                        {
                            B_message_BLL.ShowConfirm("1004");
                            hasException = true;
                        }
                        break;
                }
                if (hasException)
                    return;
                // 数据库操作成功后，将需操作标记改为无标记
                row.Cells["idu"].Value = Properties.Resources.table;
                row.Cells["idu"].ToolTipText = "";
            }
            // 使用查询函数刷新数据，避免因为原 Delete 操作中对行直接删除导致的索引错误
            Query();
            B_message_BLL.ShowConfirm("0001");  // 查询后提示保存成功
        }

        /// <summary>
        ///   查询分类按钮，弹出分类选择窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchItem_cd_Click(object sender, EventArgs e)
        {
            B_minor b_Minor = new B_minor();
            b_Minor.major_cd = "1004";
            // 弹出单位选择窗口
            FrmPopMinor frmPopMinor = new FrmPopMinor(b_Minor, "FrmPrice");
            frmPopMinor.Owner = this;
            frmPopMinor.ShowDialog();
            if (FrmPrice.minor_cd_query != "" && FrmPrice.minor_nm_query != "")
            {
                txtItem_group.Text = FrmPrice.minor_cd_query;
                txtItem_group_nm.Text = FrmPrice.minor_nm_query;
            }
            FrmPrice.minor_cd_query = String.Empty;
            FrmPrice.minor_nm_query = String.Empty;
        }


        /// <summary>
        ///   查询往来单位按钮，弹出往来单位选择窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBp_cd_Query_Click(object sender, EventArgs e)
        {
            // 弹出单位选择窗口
            FrmPopPartner frmPopPartner = new FrmPopPartner("FrmPrice");
            frmPopPartner.Owner = this;
            frmPopPartner.ShowDialog();
            if (FrmPrice.bp_cd_query != "" && FrmPrice.bp_nm_query != "")
            {
                txtBp_cd.Text = FrmPrice.bp_cd_query;
                txtBp_nm.Text = FrmPrice.bp_nm_query;
            }
            FrmPrice.bp_cd_query = String.Empty;
            FrmPrice.bp_nm_query = String.Empty;
            Query();
        }

        #endregion


    }
}
