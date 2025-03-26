using ERP_BLL;
using ERP_MODEL;
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
using WeifenLuo.WinFormsUI.Docking;

namespace SimpleERPSystem.POP
{
    public partial class FrmPopPartner : DockContent
    {
        // 记录调用窗体名称
        string callFormName = "";

        /// <summary>
        /// 窗体构造函数
        /// </summary>
        /// <param name="callFormName"></param>
        public FrmPopPartner(string callFormName)
        {
            InitializeComponent();
            this.callFormName = callFormName;
        }

        /// <summary>
        /// 窗体加载时，自动查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPopPartner_Load(object sender, EventArgs e)
        {
            Query();
        }

        /// <summary>
        ///     查询函数，为方便调用而设置
        /// </summary>
        /// <exception cref="1002: 查找失败！未找到所要操作数据，请确认查找条件是否正确！"/>
        private void Query()
        {

            B_partner_BLL bll = new B_partner_BLL();
            B_partner model = new B_partner();

            // 数据封装
            model.bp_nm = txtBp_nm.Text.Trim();

            //MessageBox.Show(model.flag.ToString());
            // 数据绑定
            DataTable dt = bll.Get_B_Partner_Pop(model);
            dgView.DataSource = dt;

            // 先绑定数据源，再判断是否有数据
            if (dt.Rows.Count == 0)
            {
                B_message_BLL.ShowConfirm("1002");
            }
        }

        /// <summary>
        /// 点击查询按钮，执行查询函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Query();
        }

        /// <summary>
        /// 双击选取数据，赋值给传入窗体的回调字段
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
                switch (callFormName)
                {
                    case "FrmPrice":
                        FrmPrice.bp_cd_query = dgView[bp_cd.Name, e.RowIndex].Value.ToString();
                        FrmPrice.bp_nm_query = dgView[bp_nm.Name, e.RowIndex].Value.ToString();
                        break;

                }
                this.Close();
            }

        }

    }
}
