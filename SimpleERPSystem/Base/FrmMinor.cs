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
    public partial class FrmMinor : DockContent
    {

        #region 窗体函数与事件
        public FrmMinor()
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
        private void FrmMinor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing
                || e.CloseReason == CloseReason.MdiFormClosing)
            {
                if (HasNoSavedData())  // 存在未保存数据，提示用户是否继续关闭
                {
                    DialogResult dr = B_Message_BLL.ShowYesOrNo("2101");
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

        #region 辅助字段、函数: bll/ model / selectedMajor_cd / Query() / HasNoSavedData()
        /// <summary>
        /// 实例化子代码业务处理层，用于业务操作
        /// </summary>
        B_minor_BLL bll = new B_minor_BLL();
        /// <summary>
        /// 实例化子代码对象，用于数据封装
        /// </summary>
        B_minor model = new B_minor();
        /// <summary>
        /// 用于存储选中的主代码
        /// </summary>
        public static string selectedMajor_cd = String.Empty;

        /// <summary>
        ///     查询函数，为方便调用而设置
        /// </summary>
        /// <exception cref="1002: 查找失败！未找到所要操作数据，请确认查找条件是否正确！"/>
        private void Query()
        {
            // 数据封装
            model.major_cd = txtMajor_cd.Text.Trim();
            // 数据绑定
            DataTable dt = bll.Get_B_Minor(model);
            dgView.DataSource = dt;

            // 设置主代码列为只读，添加进来的新行的主代码列仍可以编辑，需要另外设置
            foreach (DataGridViewRow row in dgView.Rows)
            {
                row.Cells[minor_cd.Name].ReadOnly = true;
            }

            // 先绑定数据源，再判断是否有数据
            if (dt.Rows.Count == 0)
            {
                B_Message_BLL.ShowConfirm("1002");
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

        #region 主代码选取与查询 btnSearchMajor_cd_Click btnSearch_Click

        /// <summary>
        /// 主代码文本框的回车事件，触发查询按钮的点击事件。
        /// <para>
        /// 如果在弹出的参照窗体中选中了主代码，使用 <c>FrmMinor.selectedMajor_cd</c> 
        /// 将主代码赋值给主代码文本框，
        /// 然后清除 <c>FrmMinor.selectedMajor_cd</c> 的值。
        /// </para>
        /// <para>
        /// 如果没有在弹出的参照窗体中选中主代码，不做任何操作，
        /// 也不修改 <c>FrmMinor.selectedMajor_cd</c> 的值。
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchMajor_cd_Click(object sender, EventArgs e)
        {
            POP.FrmPopMajor frm = new POP.FrmPopMajor();
            frm.ShowDialog(); // 使用时阻塞主窗体
            /// <remarks>
            /// 如果在弹出的参照窗体中选中了主代码，则 <c>selectedMajor_cd</c> 不为空，
            /// 此时将 <c>selectedMajor_cd</c> 赋值给主代码文本框，并重置 <c>selectedMajor_cd</c>。
            /// </remarks>
            if (selectedMajor_cd != String.Empty)
            {
                txtMajor_cd.Text = selectedMajor_cd; // 选中的主代码赋值给主代码文本框
                selectedMajor_cd = String.Empty; // 清空选中的主代码
                Query(); // 查询主代码对应的子代码
                ///<remarks>
                /// 当前选用方案中不允许用户直接输入主代码，只能通过参照窗体选取，
                /// 因而不在这里单独设置只读，直接对该控件设置只读
                ///     避免使用保存按钮时主键选取错误。
                /// 如果有单独字段存储查询结果，则可设置控件非只读，此处就应设置若有选取值则只读,即:
                /// <code>string temp = txtMajor_cd.Text.Trim();</code>
                /// 用字段 <c>temp</c> 存储查询结果，在保存时判断 <c>temp</c> 是否有被用户输入修改
                /// 若修改则弹窗让用户选择一个有效结果，若未修改则直接使用 <c>temp</c> 赋值给模型并实例化。
                ///</remarks>
                //txtMajor_cd.ReadOnly = true; // 主代码文本框设置为只读
            }
        }

        /// <summary>
        ///     搜索按钮，根据输入条件查询主代码表。
        /// <para>
        ///     如果有已经标记但未保存的数据，会弹出提示框
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="2101: 存在未保存数据，确认以继续操作"/>
        /// <exception cref="2000: 未填写必需信息，补充后重新操作"/>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMajor_cd.Text.Trim() == "")
            {
                B_Message_BLL.ShowConfirm("2000");
                return;
            }
            if(HasNoSavedData())
            {
                DialogResult dr = B_Message_BLL.ShowYesOrNo("2101");
                if (dr == DialogResult.No)
                    return;
            }
            Query();
        }

        #endregion

        #region 增删改按钮 btnSave_Click btnAddRow_Click btnDelRow_Click
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
        {   /*
             * ERROR: “未将对象引用设置到对象的实例。”
             * Analysis: 该语句原理是为 dgView.DataSource 绑定一个 DataTable，
             *          然后再添加行，但是如果一开始没有绑定DataSource，会出现访问空值导致异常
             * Solution: 条件判断如下
             */
            if (dgView.DataSource == null)
            {
                dgView.Rows.Add(); // 直接添加行
            }
            else
            {   /* ERROR: “当控件为数据绑定时，不能以编程方式将行添加到DataGridView的行集合中。”
                 * Analysis：dgv.DataSource = dt.DefaultView 导致的问题
                 * Solution：修正数据绑定，并在句中将 dgView.DataSource 强制转换为 DataTable 然后添加行。 */
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
            // 数据保存
            foreach (DataGridViewRow row in dgView.Rows)
            {
                // 主代码由主代码文本框提供，因而要设置控件只读，避免用户修改后带来的主键查询失败
                model.major_cd = txtMajor_cd.Text.Trim();
                // 其余数据由表格提供
                model.minor_cd = (row.Cells[minor_cd.Name].Value == null)
                                ? "" : row.Cells[minor_cd.Name].Value.ToString();
                model.minor_nm = (row.Cells[minor_nm.Name].Value == null)
                                ? "" : row.Cells[minor_nm.Name].Value.ToString();
                model.remark = (row.Cells[remark.Name].Value == null)
                                ? "" : row.Cells[remark.Name].Value.ToString();
                model.user_cd = FrmMain.user_id;

                // 根据标记进行增删改操作
                switch (row.Cells["idu"].ToolTipText)
                {
                    case "":    // 无标记
                        break;
                    case "Insert":  // 新增操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Insert_B_Minor(model))
                        {
                            /// <remarks>
                            /// 在插入失败时会弹出两次提示框，
                            /// 一次是插入自身的不合法提示(<c>1001/2001/2002</c>)
                            /// 一次是插入失败(<c>1003</c>)
                            /// </remarks>
                            B_Message_BLL.ShowConfirm("1003");
                            return;
                        }
                        break;
                    case "Update":  // 修改操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Update_B_Minor(model))
                        {
                            /// <remarks>
                            /// 在更新失败时会弹出两次提示框，
                            /// 一次是插入自身的不合法提示(<c>1005/2002</c>)
                            /// 一次是插入失败(<c>1005</c>)
                            /// </remarks>
                            B_Message_BLL.ShowConfirm("1005");
                            return;
                        }
                        break;
                    case "Delete":  // 删除操作，返回值为 false 时，提示错误信息并返回
                        if (!bll.Delete_B_Minor(model))
                        {
                            /// <remarks>
                            /// 在插入失败时会弹出两次提示框，
                            /// 一次是插入自身的不合法提示(<c>1004</c>)
                            /// 一次是插入失败(<c>1004</c>)
                            /// </remarks>
                            B_Message_BLL.ShowConfirm("1004");
                            return;
                        }

                        ///<remarks>
                        /// <c>foreach</c> 语句是基于 <c>MoveNext</c> 等函数顺序执行，
                        /// 删除正在遍历元素会导致索引的异常。比如：
                        ///     第六行标记为删除，删除后，第七行变为第六行，
                        ///     但是 foreach 会认为新的第六行已经被遍历过了,
                        ///     会导致原本的第七行被跳过，无法进行 switch 判断
                        /// </remarks>
                        // 无需直接删除，只需修正标记即可，后续查询时会自动过滤
                        // dgView.Rows.Remove(row);  // 保存成功后，删除表中该行
                        break;
                }
                // 数据库操作成功后，将需操作标记改为无标记
                row.Cells["idu"].Value = Properties.Resources.table;
                row.Cells["idu"].ToolTipText = "";
            }
            // 使用查询函数刷新数据，避免因为原 Delete 操作中对行直接删除导致的索引错误
            Query();
            B_Message_BLL.ShowConfirm("0001");  // 查询后提示保存成功
        }

        #endregion

    }
}
