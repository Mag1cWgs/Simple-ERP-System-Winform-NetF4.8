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

namespace SimpleERPSystem.Base.POP
{
    public partial class FrmPopMajor : Form
    {
        #region 窗体函数与事件
        public FrmPopMajor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载时，自动查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPopMajor_Load(object sender, EventArgs e)
        {
            Query();
        }
        #endregion

        #region 执行查询
        /// <summary>
        ///     查询函数，为方便调用而设置
        /// <para>相比主窗体中查询函数，去除了主代码只读设置，
        /// 改为对 <c>dgView</c> 设置默认只读。</para>
        /// </summary>
        /// <exception cref="1002: 未找到所要操作数据，请确认查找条件是否正确！"/>
        private void Query()
        {
            B_major model = new B_major()
            {
                major_cd = txtMajor_cd.Text.Trim(),
                major_nm = txtMajor_nm.Text.Trim()
            };
            B_major_BLL bll = new B_major_BLL();
            DataTable dt = bll.Get_B_Major(model);
            dgView.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                B_message_BLL.ShowConfirm("1002");
            }
        }

        /// <summary>
        /// 查询按钮，根据输入条件查询主代码表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Query();
        }

        #region 清空搜索条件文本框
        /// <summary>
        /// 清空主代码文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelMajor_cd_Click(object sender, EventArgs e)
        {
            this.txtMajor_cd.Text = String.Empty;
        }

        /// <summary>
        /// 清空主代码名称文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelMajor_nm_Click(object sender, EventArgs e)
        {
            this.btnDelMajor_nm.Text = String.Empty;
        }
        #endregion

        #endregion

        #region 选取数据

        /// <summary>
        /// 双击选取数据，赋值给 <c>FrmMinor.selectedMajor_cd</c>，作为回调字段
        /// <para>
        /// 通过对 <c>e.RowIndex</c> 和 <c>e.ColumnIndex</c> 的限定，保证选取的数据是有效的。
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && e.ColumnIndex >= 0)
            {
                // 选取 dgView 中 major_cd 列、触发行 e.Index 的值，传递给 FrmMinor 中的回调字段
                FrmMinor.selectedMajor_cd = dgView[major_cd.Name, e.RowIndex].Value.ToString();
                this.Close();
            }
        }

        #endregion
    }
}
