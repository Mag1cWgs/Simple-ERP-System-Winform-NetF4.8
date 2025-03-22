using ERP_BLL;
using ERP_MODEL;
using NPOI.SS.Formula.Functions;
using SimpleERPSystem.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleERPSystem.POP
{
    public partial class FrmPopMinor : Form
    {
        #region 窗体函数与事件
        /// <summary>
        /// 窗体构造函数
        /// </summary>
        /// <param name="minorImport">传入要查询的子代码</param>
        public FrmPopMinor(B_minor minorImport)
        {
            InitializeComponent();
            model = minorImport;
            this.Text = model.major_cd + " 子代码查询";
        }

        /// <summary>
        /// 窗体加载时，自动查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPopMinor_Load(object sender, EventArgs e)
        {
            Query();
        }
        #endregion

        #region 辅助字段 / 函数 : model, bll, Query()
        /// <summary>
        ///    子代码实体，用于存储查询条件
        /// </summary>
        B_minor model = new B_minor();

        /// <summary>
        ///   BLL 操作类实体
        /// </summary>
        B_minor_BLL bll = new B_minor_BLL();

        /// <summary>
        ///     查询函数，为方便调用而设置
        /// <para>相比主窗体中查询函数，去除了主代码只读设置，
        /// 改为对 <c>dgView</c> 设置默认只读。</para>
        /// </summary>
        /// <exception cref="1002: 未找到所要操作数据，请确认查找条件是否正确！"/>
        private void Query()
        {
            if(string.IsNullOrEmpty(model.minor_cd))
                model.minor_cd = txtMinor_cd.Text.Trim();
            if(string.IsNullOrEmpty(model.minor_nm))
                model.minor_nm = txtMinor_nm.Text.Trim();
            DataTable dt = bll.Get_Minor_Pop(model);
            dgView.DataSource = dt;
            // 查询完数据后，清空 model 中的数据
            model.minor_cd = "";
            model.minor_nm = "";
            if (dt.Rows.Count == 0)
            {
                B_message_BLL.ShowConfirm("1002");
            }
        }

        #endregion


        /// <summary>
        /// 查询按钮，根据输入条件查询主代码表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Query();
        }

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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // 选取 dgView 中 major_cd 列、触发行 e.Index 的值，传递给 FrmMinor 中的回调字段
                //BaseInfo.FrmMinor.selectedMajor_cd = dgView[major_cd.Name, e.RowIndex].Value.ToString();
                FrmItem.minor_cd_query = dgView[minor_cd.Name, e.RowIndex].Value.ToString();
                FrmItem.minor_nm_query = dgView[minor_nm.Name, e.RowIndex].Value.ToString();
                this.Close();
            }
        }

    }
}
