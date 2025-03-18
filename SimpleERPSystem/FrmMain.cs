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

namespace SimpleERPSystem
{
    public partial class FrmMain : Form
    {
        // 用于在其他窗体中调用主窗体
        public static FrmMain frmMain;
        public static string user_id = "admin"; // 用户ID

        public FrmMain()
        {
            InitializeComponent();
            frmMain = this; // 将当前窗体赋值给frmMain
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmHomePage frmHomePage = new FrmHomePage();
            frmHomePage.Show(dockPanelMain);

            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show(dockPanelMain, DockState.DockLeft);
            dockPanelMain.DockLeftPortion = 140; // 设置左侧菜单栏的宽度

            tsslblUser.Text = "当前用户：" + user_id;
            tsslblDate.Text = "当前日期：" + DateTime.Now.ToString("yyyy-MM-dd");
            tsslblVersion.Text = "版本号：V25.1";
        }
    }
}
