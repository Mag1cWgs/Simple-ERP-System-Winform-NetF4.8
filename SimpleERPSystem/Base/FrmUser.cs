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
    public partial class FrmUser : DockContent
    {
        #region 窗体事件与函数
        public FrmUser()
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
        private void FrmUser_FormClosing(object sender, FormClosingEventArgs e)
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

        #region 辅助函数
        /// <summary>
        /// 实例化人员信息业务处理层，用于数据库操作
        /// </summary>
        B_user_BLL bll = new B_user_BLL();

        /// <summary>
        ///     查询函数，为方便调用而设置
        /// </summary>
        /// <exception cref="1002:未找到所要操作数据，请确认查找条件是否正确" />
        private void Query()
        {
            // 数据封装
            B_user model = new B_user()
            {
                user_nm = txtUser_nm.Text.Trim()
            };
            DataTable dt = bll.Get_B_User(model);
            dgView.DataSource = dt;

            // 设置主代码列为只读，添加进来的新行的主代码列仍可以编辑，需要另外设置
            foreach (DataGridViewRow row in dgView.Rows)
            {
                row.Cells[user_cd.Name].ReadOnly = true;
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

        #region 增删改查功能
        /// <summary>
        ///     搜索按钮，根据输入条件查询人员信息表。
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

        #region dgView编辑事件 dgView_CellBeginEdit dgView_CellEndEdit
        // 存储表格内容
        string str_old, str_new;
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
            B_user model = new B_user();
            // 数据保存
            foreach (DataGridViewRow row in dgView.Rows)
            {
                model.user_cd = (row.Cells[user_cd.Name].Value == null)
                                ? "" : row.Cells[user_cd.Name].Value.ToString();
                model.user_nm = (row.Cells[user_nm.Name].Value == null)
                                ? "" : row.Cells[user_nm.Name].Value.ToString();
                model.tel_no = (row.Cells[tel_no.Name].Value == null)
                                ? "" : row.Cells[tel_no.Name].Value.ToString();
                model.dept_nm = (row.Cells[dept_nm.Name].Value == null)
                                ? "" : row.Cells[dept_nm.Name].Value.ToString();
                model.remark = (row.Cells[remark.Name].Value == null)
                                ? "" : row.Cells[remark.Name].Value.ToString();
                model.user_using_cd = FrmMain.user_id;

                // 根据标记进行增删改操作
                switch (row.Cells["idu"].ToolTipText)
                {
                    case "":    // 无标记
                        break;
                    case "Insert":  // 新增操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Insert_B_User(model))
                        {
                            B_message_BLL.ShowConfirm("1003");
                            return;
                        }
                        break;
                    case "Update":  // 修改操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Update_B_User(model))
                        {
                            B_message_BLL.ShowConfirm("1005");
                            return;
                        }
                        break;
                    case "Delete":  // 删除操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Delete_B_User(model))
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

        #endregion

    }
}
