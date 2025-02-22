﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SimpleERPSystem.Base;
using System.Security.AccessControl;
using ComponentFactory.Krypton.Toolkit;

namespace SimpleERPSystem
{
    public partial class FrmMenu : DockContent
    {
        public FrmMenu()
        {
            InitializeComponent();
        }


        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件的辅助函数
        /// </summary>
        /// <param name="dockContent">使用父类传入，实现加载子类窗体</param>
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

        private void lblMajor_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new FrmMajor(),lbl);
        }


        private void lblMinor_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new FrmMinor(), lbl);
        }

        private void lblPartner_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new FrmPartner(), lbl);
        }

        private void lblTax_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new FrmTax(), lbl);
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            var lbl = sender as KryptonLabel;
            OpenSubForm(new FrmUser(), lbl);
        }
 #endregion
    }
   
}
