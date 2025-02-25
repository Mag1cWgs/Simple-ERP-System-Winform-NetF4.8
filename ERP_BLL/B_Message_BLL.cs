using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using ERP_DAL;

namespace ERP_BLL
{
    /// <summary>
    /// 消息提示类的业务逻辑层，用于弹出响应信息的提示窗口。
    /// </summary>
    public abstract class B_Message_BLL
    {
        /// <summary>
        ///     信息提示窗，仅提供 “Yes” 选项，显示向数据库查询所得到的异常信息。
        /// <para>
        ///     使用<c> B_Message_DAL</c>中的
        ///     <c>Get_Exception_Message(string <paramref name="msg_cd"/>)</c>
        ///     函数获取异常信息。
        /// </para>
        /// </summary>
        /// <param name="msg_cd">信息编号，有效范围在'0000'~'9999'</param>
        public static void ShowConfirm(string msg_cd)
        {
            string str = B_Message_DAL.Get_Exception_Message(msg_cd);
            KryptonMessageBox.Show(str,msg_cd.ToString(),
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///     信息提示窗，显示系统 Try Catch 捕获的异常错误<paramref name="ex"/>。
        ///     <para>
        ///     仍然会对数据库进行查询，获取异常信息。对应的异常信息编号为 <c>9999</c>。
        ///     </para>
        /// </summary>
        /// <param name="ex">发生的异常错误</param>
        public static void ShowUnkownError(Exception ex)
        {
            StringBuilder str = new StringBuilder();
            str.Append(B_Message_DAL.Get_Exception_Message("9999"))
                .Append("\r\n")
                .Append(ex.Message);
            KryptonMessageBox.Show(str.ToString(), "9999",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 信息提示窗，提供 “Yes” “No” 选项，显示向数据库查询所得到的异常信息。
        /// <para>
        ///     使用<c> B_Message_DAL</c>中的
        ///     <c>Get_Exception_Message(string <paramref name="msg_cd"/>)</c>
        ///     函数获取异常信息。
        /// </para>
        /// </summary>
        /// <param name="msg_cd">信息编号，有效范围在'0000'~'9999'</param>
        /// <returns>返回用户选择的结果，类型为 <c>DialogResult</c> </returns>
        public static DialogResult ShowYesOrNo(string msg_cd)
        {
            string str = B_Message_DAL.Get_Exception_Message(msg_cd);
            return KryptonMessageBox.Show(str, msg_cd.ToString(),
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
