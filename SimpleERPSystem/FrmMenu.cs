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
using System.Security.AccessControl;
using ComponentFactory.Krypton.Toolkit;

namespace SimpleERPSystem
{
    public partial class FrmMenu : DockContent
    {
        #region 构造函数 / 窗体事件
        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件的辅助函数，用于打开子窗体，并保证单例
        /// </summary>
        /// <param name="dockContent">使用父类传入，类似泛型化</param>
        /// <param name="label">窗体标题同步的目标Label</param>
        private void OpenSubForm(DockContent dockContent, KryptonLabel label)
        {
            // 遍历所有窗体，如果已经打开则激活，保证单例
           // 不应在此处设置窗体标题，应在外部直接对目标窗体设置
            foreach (DockContent item in FrmMain.frmMain.dockPanelMain.Contents)
            {
                if (item.Name.Equals(dockContent.Name))
                {
                    item.Activate();
                    return;
                }
            }
            // 设置窗体标题同步，保证在不触发单例判断的情况下也能设置标题
            dockContent.Text = label.Text;
            // 显示窗体，使用静态类FrmMain中的frmMain对象取巧
            dockContent.Show(FrmMain.frmMain.dockPanelMain);
        }
        #endregion

        #region 基础信息分菜单中的点击事件
        /// <summary>
        /// 主代码窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMajor_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new BaseInfo.FrmMajor(),lbl);
        }

        /// <summary>
        /// 子代码窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMinor_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new BaseInfo.FrmMinor(), lbl);
        }

        /// <summary>
        /// 往来单位窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPartner_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new BaseInfo.FrmPartner(), lbl);
        }

        /// <summary>
        /// 税率窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTax_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new BaseInfo.FrmTax(), lbl);
        }

        /// <summary>
        /// 用户信息窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblUser_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new BaseInfo.FrmUser(), lbl);
        }
        #endregion

        #region 商品信息分菜单中的点击事件
        /// <summary>
        /// 商品信息窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblItem_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new Item.FrmItem(), lbl);
        }

        /// <summary>
        /// 往来单价窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPrice_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new Item.FrmPrice(), lbl);
        }
        #endregion
    }

}
