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

namespace SimpleERPSystem.POP
{
    public partial class FrmPopItem : Form
    {
        B_partner b_partner = new B_partner();


        B_item_BLL bll = new B_item_BLL();

        public FrmPopItem(B_partner partner)
        {
            InitializeComponent();
            b_partner = partner;
        }

        void Query()
        {
            B_item b_item = new B_item();
            b_item.item_nm = txtItem_nm.Text.Trim();
            b_item.item_group = txtItem_group.Text.Trim();

            DataTable dt = bll.Get_B_Item_Pop(this.b_partner, b_item);
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

        private void FrmPopItem_Load(object sender, EventArgs e)
        {
            Query();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void dgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            FrmPrice.drRow = dgView.Rows[e.RowIndex];
            this.Close();
        }
    }
}
