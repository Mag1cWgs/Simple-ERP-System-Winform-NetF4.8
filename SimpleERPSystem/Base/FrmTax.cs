using ERP_BLL;
using ERP_MODEL;
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

namespace SimpleERPSystem.Base
{
    public partial class FrmTax : DockContent
    {
        #region 窗体事件
        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmTax()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体关闭事件
        /// <para>
        /// 当窗体关闭原因为用户关闭 (<c>UserClosing</c>) 时，
        /// 判断是否有未保存数据，弹出是否继续关闭的提示框。
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="2101: 存在未保存数据，确认以继续操作"/>
        private void FrmTax_FormClosing(object sender, FormClosingEventArgs e)
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

        #region 辅助字段、函数
        /// <summary>
        /// 作为编辑时存储表格内容的辅助字段
        /// </summary>
        string str_old, str_new;

        /// <summary>
        /// BLL 层的辅助实体，方便调用函数。
        /// </summary>
        B_tax_BLL bll = new B_tax_BLL();

        /// <summary>
        ///     查询函数，为方便调用而设置
        /// </summary>
        /// <exception cref="1002:未找到所要操作数据，请确认查找条件是否正确" />
        private void Query()
        {
            DataTable dt = bll.Get_B_Tax();
            dgView.DataSource = dt;

            // 设置主代码列为只读，添加进来的新行的主代码列仍可以编辑，需要另外设置
            foreach (DataGridViewRow row in dgView.Rows)
            {
                row.Cells[tax_cd.Name].ReadOnly = true;
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


        #region dgView编辑事件 dgView_CellBeginEdit / dgView_CellEndEdit
        /// <summary>
        /// 修改后数据错误事件，弹窗提示并清除错误位置数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="1007: 输入的数据类型不正确，在要求数字类型的位置输入了文本。" />
        private void dgView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            B_message_BLL.ShowConfirm("1007");
            dgView[e.ColumnIndex, e.RowIndex].Value = 0;
        }

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
        #endregion


        #region 增删改查功能

        /// <summary>
        ///     搜索按钮，根据输入条件查询主代码表。
        /// <para>
        ///     如果有已经标记但未保存的数据，会弹出提示框
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="2101: 存在未保存数据，确认以继续操作"/>
        private void btnSearch_Click(object sender, EventArgs e)
        {   // 存在未保存数据，提示是否继续查询
            if (HasNoSavedData())
            {
                DialogResult dr = B_message_BLL.ShowYesOrNo("2101");
                if (dr == DialogResult.No)
                    return;
            }
            // 不存在未保存数据，直接查询
            Query();
        }

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
            B_tax model = new B_tax();
            // 数据保存
            foreach (DataGridViewRow row in dgView.Rows)
            { 
                // 绑定数据
                {
                model.tax_cd = (row.Cells[tax_cd.Name].Value == null)
                                ? "" : row.Cells[tax_cd.Name].Value.ToString();
                model.tax_nm = (row.Cells[tax_nm.Name].Value == null)
                                ? "" : row.Cells[tax_nm.Name].Value.ToString();

                // 先判断是否空绑定，再或判断是否是空值，避免 null.ToString() 抛出异常
                if (row.Cells[tax_rate.Name].Value == null
                    || row.Cells[tax_rate.Name].Value.ToString() == "")
                    model.tax_rate = null; // 会在 bll.Insert_B_Tax() 中弹 2008 窗口
                else // 正常有值时，使用转换函数将 object => decimal
                    model.tax_rate = Convert.ToDecimal(row.Cells[tax_rate.Name].Value);

                model.remark = (row.Cells[remark.Name].Value == null)
                                ? "" : row.Cells[remark.Name].Value.ToString();
                model.user_cd = FrmMain.user_id;
                }
                // 根据标记进行增删改操作
                switch (row.Cells["idu"].ToolTipText)
                {
                    case "":    // 无标记
                        break;
                    case "Insert":  // 新增操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Insert_B_Tax(model))
                        {
                            /// <remarks>
                            /// 在插入失败时会弹出两次提示框，
                            /// 一次是插入自身的不合法提示(<c>1001/2001/2002</c>)
                            /// 一次是插入失败(<c>1003</c>)
                            /// </remarks>
                            B_message_BLL.ShowConfirm("1003");
                            return;
                        }
                        break;
                    case "Update":  // 修改操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Update_B_Tax(model))
                        {
                            /// <remarks>
                            /// 在更新失败时会弹出两次提示框，
                            /// 一次是插入自身的不合法提示(<c>1005/2002</c>)
                            /// 一次是插入失败(<c>1005</c>)
                            /// </remarks>
                            B_message_BLL.ShowConfirm("1005");
                            return;
                        }
                        break;
                    case "Delete":  // 删除操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Delete_B_Tax(model))
                        {
                            /// <remarks>
                            /// 在插入失败时会弹出两次提示框，
                            /// 一次是插入自身的不合法提示(<c>1004</c>)
                            /// 一次是插入失败(<c>1004</c>)
                            /// </remarks>
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

        #endregion
    }
}
