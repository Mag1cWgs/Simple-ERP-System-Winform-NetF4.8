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
        public FrmMinor()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     查询函数，为方便调用而设置
        /// </summary>
        /// <exception cref="1002: 查找失败！未找到所要操作数据，请确认查找条件是否正确！"/>
        private void Query()
        {
            // 数据封装
            B_minor model = new B_minor();
            model.major_cd = txtMajor_cd.Text.Trim();

            B_minor_BLL bll = new B_minor_BLL();
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

        /// <summary>
        ///     搜索按钮，根据输入条件查询主代码表。
        /// <para>
        ///     如果有已经标记但未保存的数据，会弹出提示框
        /// </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="1007: 未填写必需信息，补充后重新操作"/>
        /// <exception cref="1006: 存在未保存数据，确认以继续操作"/>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMajor_cd.Text.Trim() == "")
            {
                B_Message_BLL.ShowConfirm("1007");
                return;
            }
            if(HasNoSavedData())
            {
                DialogResult dr = B_Message_BLL.ShowYesOrNo("1006");
                if (dr == DialogResult.No)
                    return;
            }
            Query();
        }



        /// <summary>
        /// 用于存储选中的主代码
        /// </summary>
        public static string selectedMajor_cd=String.Empty;

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
            if (selectedMajor_cd != String.Empty)
            {
                txtMajor_cd.Text = selectedMajor_cd; // 选中的主代码赋值给主代码文本框
                selectedMajor_cd = String.Empty; // 清空选中的主代码
            }
        }


    }
}
