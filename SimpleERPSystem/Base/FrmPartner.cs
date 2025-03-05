using ComponentFactory.Krypton.Toolkit;
using ERP_BLL;
using ERP_CL;
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
    public partial class FrmPartner : DockContent
    {
        public FrmPartner()
        {
            InitializeComponent();
        }

        #region 辅助字段、函数: bll/ model / selectedMajor_cd / Query() / HasNoSavedData() / Clear_pnl_partner_info()
        /// <summary>
        /// 作为清除 pnl_partner_info 中内容的辅助函数
        /// </summary>
        private void Clear_pnl_partner_info()
        {
            // 重置 CheckBox 内容
            this.cb_so_flag.Checked = false;
            this.cb_po_flag.Checked = false;
            //使用字段 txt、cbb 作为中继变量
            ERP_TextBox txt;
            KryptonComboBox cbb;
            /*  使用foreach循环遍历控件，对每一个ERP_TextBox控件进行清空操作
             *  其中 pnl_partner_info 为存放 ERP_TextBox 控件的Panel控件
             *  它的 Controls属性存放了所有子控件，均基于 Control 父类    */
            /* 可以用类似于下面的代码进行重写，其中只写了 ERO_TextBox 类型的控件清空操作
            for (int i = 0; i < pnl_partner_info.Controls.Count; i++)
            {
                if ("ERP_CL."+pnl_partner_info.Controls[i].GetType().Name 
                                            == typeof(ERP_TextBox).ToString())
                {
                    txt = (ERP_TextBox)pnl_partner_info.Controls[i];
                    txt.Text = string.Empty;
                }
            }
             */
            foreach (Control item in pnl_partner_info.Controls)
            {
                string name = item.GetType().Name;
                /*  用于测试时比对类型
                 MessageBox.Show("ComponentFactory.Krypton.Toolkit." + name
                    + '\n' + typeof(ERP_CL.ERP_TextBox).ToString()
                    + '\n' + typeof(ComponentFactory.Krypton.Toolkit.KryptonCheckBox).ToString());
                 */
                /* 对 item 进行类型判断，如果是 ERP_TextBox 类型，则进行清空操作
                 * 但是通过 GetType().Name 获取的是类的全名，不含命名空间，
                 * 需要加上命名空间然后进行比较   */
                if (("ERP_CL." + name) == typeof(ERP_TextBox).ToString())
                {
                    txt = (ERP_TextBox)item;
                    txt.Text = string.Empty;
                }
                else if ("ComponentFactory.Krypton.Toolkit." + name
                    == typeof(KryptonComboBox).ToString())
                {
                    cbb = (KryptonComboBox)item;
                    cbb.Text = string.Empty;
                }
            }
            this.txt_bp_cd.Focus();

        }

        /// <summary>
        /// 实例化子代码业务处理层，用于业务操作
        /// </summary>
        B_partner_BLL bll = new B_partner_BLL();
        /// <summary>
        /// 实例化子代码对象，用于数据封装
        /// </summary>
        B_partner model = new B_partner();

        /// <summary>
        ///     查询函数，为方便调用而设置
        /// </summary>
        /// <exception cref="1002: 查找失败！未找到所要操作数据，请确认查找条件是否正确！"/>
        private void Query()
        {
            // 数据封装
            if (rbtn_query_so.Checked == true)
                model.flag = "s";
            else if (rbtn_query_po.Checked == true)
                model.flag = "p";
            else if (rbtn_query_all.Checked == true)
                model.flag = "Y";
            model.bp_full_nm = txt_query_bp_full_nm.Text.Trim();
            model.bp_repre = txt_query_bp_repre.Text.Trim();
            // 数据绑定
            DataTable dt = bll.Get_B_Partner(model);
            dgView.DataSource = dt;

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

        #region
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 单位全称 和 联系人 至少填一个
            if (txt_query_bp_full_nm.Text.Trim() == "" && txt_query_bp_repre.Text.Trim() == "")
            {
                B_Message_BLL.ShowConfirm("2000");
                return;
            }
            /*  查询前比对数据
            if (HasNoSavedData())
            {
                DialogResult dr = B_Message_BLL.ShowYesOrNo("2101");
                if (dr == DialogResult.No)
                    return;
            }
             */
            Query();
        }
        #endregion

        #region 增删按钮事件 btnDel_Click
        /// <summary>
        /// 删除按钮，点击提示是否删除，确认后删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="2102: 敏感操作：删除，确认以继续操作"/>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if(B_Message_BLL.ShowYesOrNo("2102") == DialogResult.Yes)
            {
                // 此处写删除代码
            }
        }

        /// <summary>
        /// 添加按钮，点击后弹出添加窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clear_pnl_partner_info();
        }
        #endregion

    }
}
