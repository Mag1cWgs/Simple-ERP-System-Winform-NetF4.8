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
using ERP_MODEL;
using ERP_BLL;

namespace SimpleERPSystem.Item
{
    public partial class FrmItem : DockContent
    {
        #region 辅助字段 minor_cd_query / minor_nm_query / str_old / str_new / Query() / HasNoSavedData()

        public static string minor_cd_query, minor_nm_query;
        string str_old, str_new;

        B_item_BLL bll = new B_item_BLL();

        void Query()
        {
            B_item model = new B_item()
            {
                item_nm = this.txtItem_nm.Text.Trim(),
                item_group = this.txtItem_group.Text.Trim()
            };
            DataTable dt = bll.Get_B_Item(model);
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

        #region 窗体函数与事件 FrmItem()
        private void FrmItem_Load(object sender, EventArgs e)
        {
            Query();
        }

        /// <summary>
        ///    窗体构造函数
        /// </summary>
        public FrmItem()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   窗体关闭时，判断是否有未保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmItem_FormClosing(object sender, FormClosingEventArgs e)
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
        ///    单元格点击事件，点击单位、组别、库位时弹出选择窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            string str_old = null;
            // 点击单位时弹出选择窗口
            if (dgView.Columns[e.ColumnIndex].Name == btn_unit.Name)
            {
                str_old = dgView[item_unit.Name, e.RowIndex].Value.ToString();
                B_minor b_Minor = new B_minor();
                b_Minor.major_cd = "1003";
                // 弹出单位选择窗口
                FrmPopMinor frmPopMinor = new FrmPopMinor(b_Minor);
                frmPopMinor.Owner = this;
                frmPopMinor.ShowDialog();
                if (FrmItem.minor_cd_query != "" && FrmItem.minor_nm_query != "")
                {
                    dgView[item_unit.Name, e.RowIndex].Value = FrmItem.minor_cd_query;
                    dgView[item_unit_nm.Name, e.RowIndex].Value = FrmItem.minor_nm_query;
                }
            }
            // 点击组别时弹出选择窗口
            if (dgView.Columns[e.ColumnIndex].Name == btn_group.Name)
            {
                str_old = dgView[sl_cd.Name, e.RowIndex].Value.ToString();
                B_minor b_Minor = new B_minor();
                b_Minor.major_cd = "1004";
                // 弹出单位选择窗口
                FrmPopMinor frmPopMinor = new FrmPopMinor(b_Minor);
                frmPopMinor.Owner = this;
                frmPopMinor.ShowDialog();
                if (FrmItem.minor_cd_query != "" && FrmItem.minor_nm_query != "")
                {
                    dgView[item_group.Name, e.RowIndex].Value = FrmItem.minor_cd_query;
                    dgView[item_group_nm.Name, e.RowIndex].Value = FrmItem.minor_nm_query;
                }
            }
            // 点击库位时，弹出库位选择窗口
            if (dgView.Columns[e.ColumnIndex].Name == btn_sl.Name)
            {
                str_old = dgView[sl_cd.Name, e.RowIndex].Value.ToString();
                B_minor b_Minor = new B_minor();
                b_Minor.major_cd = "1005";
                // 弹出单位选择窗口
                FrmPopMinor frmPopMinor = new FrmPopMinor(b_Minor);
                frmPopMinor.Owner = this;
                frmPopMinor.ShowDialog();
                if (FrmItem.minor_cd_query != "" && FrmItem.minor_nm_query != "")
                {
                    dgView[sl_cd.Name, e.RowIndex].Value = FrmItem.minor_cd_query;
                    dgView[sl_nm.Name, e.RowIndex].Value = FrmItem.minor_nm_query;
                }
            }
            // 校验是否修改了库位，若未修改则不进行操作
            if (str_old != FrmItem.minor_cd_query && dgView.Rows[e.RowIndex].Cells["idu"].ToolTipText == "")
            {

                dgView.Rows[e.RowIndex].Cells["idu"].Value = Properties.Resources.table_edit;
                dgView.Rows[e.RowIndex].Cells["idu"].ToolTipText = "Update";
            }
            // 清空查询结果
            str_old = String.Empty;
            FrmItem.minor_cd_query = null;
            FrmItem.minor_nm_query = null;
        }

        #endregion

        #region 表格加行/删行按钮
        /// <summary>
        ///     加行按钮，添加一行空白行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRow_Click(object sender, EventArgs e)
        {   
            if (dgView.DataSource == null)
            {
                dgView.Rows.Add(); // 直接添加行
            }
            else
            {  
                ((DataTable)dgView.DataSource).Rows.Add();
            }

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
        ///   保存按钮，保存表格内容。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
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
            B_item model = new B_item();
            // 数据保存
            foreach (DataGridViewRow row in dgView.Rows)
            {
                model.item_cd = (row.Cells[item_cd.Name].Value == null)
                                ? "" : row.Cells[item_cd.Name].Value.ToString();
                model.item_nm = (row.Cells[item_nm.Name].Value == null)
                                ? "" : row.Cells[item_nm.Name].Value.ToString();
                model.item_spec = (row.Cells[item_spec.Name].Value == null) 
                                ? "" : row.Cells[item_spec.Name].Value.ToString();
                if (row.Cells[item_price.Name].Value == null || row.Cells[item_price.Name].Value.ToString() == "")
                    model.item_price = null;
                else
                    model.item_price = Convert.ToDecimal(row.Cells[item_price.Name].Value);
                model.item_unit = (row.Cells[item_unit.Name].Value == null)
                                ? "" : row.Cells[item_unit.Name].Value.ToString();
                model.item_group = (row.Cells[item_group.Name].Value == null)
                                ? "" : row.Cells[item_group.Name].Value.ToString(); 
                model.sl_cd = (row.Cells[sl_cd.Name].Value == null)
                                ? "" : row.Cells[sl_cd.Name].Value.ToString();
                model.remark = (row.Cells[remark.Name].Value == null)
                                ? "" : row.Cells[remark.Name].Value.ToString();
                model.user_cd = FrmMain.user_id;

                // 根据标记进行增删改操作
                switch (row.Cells["idu"].ToolTipText)
                {
                    case "":    // 无标记
                        break;
                    case "Insert":  // 新增操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Insert_B_Item(model))
                        {
                            B_message_BLL.ShowConfirm("1003");
                            return;
                        }
                        break;
                    case "Update":  // 修改操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Update_B_Item(model))
                        {
                            B_message_BLL.ShowConfirm("1005");
                            return;
                        }
                        break;
                    case "Delete":  // 删除操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Delete_B_Item(model))
                        {
                            B_message_BLL.ShowConfirm("1004");
                            return;
                        }
                        break;
                }
                // 数据库操作成功后，将需操作标记改为无标记
                row.Cells["idu"].Value = Properties.Resources.table;
                row.Cells["idu"].ToolTipText = "";
            }
            // 使用查询函数刷新数据，避免因为原 Delete 操作中对行直接删除导致的索引错误
            Query();
            B_message_BLL.ShowConfirm("0001");  // 查询后提示保存成功
        }

        private void btnSearchItem_cd_Click(object sender, EventArgs e)
        {
            B_minor b_Minor = new B_minor();
            b_Minor.major_cd = "1004";
            // 弹出单位选择窗口
            FrmPopMinor frmPopMinor = new FrmPopMinor(b_Minor);
            frmPopMinor.Owner = this;
            frmPopMinor.ShowDialog();
            if (FrmItem.minor_cd_query != "" && FrmItem.minor_nm_query != "")
            {
                txtItem_group.Text  = FrmItem.minor_cd_query;
                txtItem_group_nm.Text = FrmItem.minor_nm_query;
            }
            FrmItem.minor_cd_query = null;
            FrmItem.minor_nm_query = null;
        }

        #endregion
    }
}
