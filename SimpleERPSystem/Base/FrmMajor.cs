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
using ERP_BLL;
using ERP_MODEL;

namespace SimpleERPSystem.Base
{
    public partial class FrmMajor : DockContent
    {
        public FrmMajor()
        {
            InitializeComponent();
        }

        #region 对显示表格操作
        /// <summary>
        ///     搜索按钮，根据输入条件查询主代码表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 数据封装
            B_major model = new B_major()
            {
                major_cd = txtMajor_cd.Text.Trim(),
                major_nm = txtMajor_nm.Text.Trim()
            };

            B_major_BLL bll = new B_major_BLL();
            DataTable dt = bll.Get_B_Major(model);
            dgView.DataSource = dt;
            // 不能用 dt.DefaultView 作为 DataSource，会与添加行功能冲突:
            // “无法将类型为“System.Data.DataView”的对象强制转换为类型“System.Data.DataTable”
        }

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
            {   /*
                 * ERROR: “当控件为数据绑定时，不能以编程方式将行添加到DataGridView的行集合中。”
                 * Analysis：dgv.DataSource = dt.DefaultView 导致的问题
                 * Solution：修正数据绑定，并在句中将 dgView.DataSource 强制转换为 DataTable 然后添加行
                 */
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
            foreach(DataGridViewRow row in dgView.SelectedRows)
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

        #region dgView编辑事件 dgView_CellBeginEdit dgView_CellEndEdit
        // 存储表格内容
        string str_old , str_new;
        // 修改表格内容时，记录修改前的值
        private void dgView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            str_old = String.Empty;
            str_old = dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            // 实际可优化 dgView[e.ColumnIndex, e.RowIndex].Value.ToString();
        }
        // 修改表格内容时，记录修改后的值，并标记为Update
        private void dgView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            str_new = String.Empty;
            str_new = dgView[e.ColumnIndex, e.RowIndex].Value.ToString();
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

        #endregion


        private void btnSave_Click(object sender, EventArgs e)
        {// 数据封装
            B_major model = new B_major();
            
            foreach (DataGridViewRow row in dgView.Rows)
            {
                model.major_cd = row.Cells[major_cd.Name].Value.ToString();
                model.major_nm = row.Cells[major_nm.Name].Value.ToString();
                model.remark = row.Cells[remark.Name].Value.ToString();
                model.user_cd = FrmMain.user_id;
                // 根据标记进行增删改操作
                switch (row.Cells["idu"].ToolTipText)
                {
                    case "":
                        break;
                    case "Insert":
                        new B_major_BLL().Insert_B_Major(model);
                        break;
                    case "Update":
                        new B_major_BLL().Update_B_Major(model);
                        break;
                    case "Delete":
                        new B_major_BLL().Delete_B_Major(model);
                        break;
                }
            }
        }

    }
}
