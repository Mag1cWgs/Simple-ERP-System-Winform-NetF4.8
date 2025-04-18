﻿using System;
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
    public abstract class B_message_BLL
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
            /// <para>
            /// 
            /// 从 0000 开始为操作提示
            ///     <c>0000</c> 操作成功！
            ///     <c>0001</c> 保存成功，请确认！已自动查询最新数据。
            /// 
            /// 从 1000 开始为数据库操作提示
            ///     <c>1001</c> 已经存在相同的主代码，无法添加！
            ///     <c>1002</c> 查找失败！未找到所要操作数据，请确认查找条件是否正确！
            ///     <c>1003</c> 插入失败！
            ///     <c>1004</c> 删除失败！未找到待删除数据！
            ///     <c>1005</c> 更新失败！未找到待更新数据！
            ///     <c>1006</c> 删除失败！子代码表中有当前主代码关联数据，请清除子代码表中与之关联所有数据后再执行删除！
            ///     <c>1007</c> 输入的数据类型不正确！例如：在要求数字类型的位置输入了文本。
            ///     <c>1008</c> 删除失败！要删除的商品信息有关联的采购订单，请先清除相关的采购订单再操作！
            ///     <c>1009</c> 删除失败！要删除的商品信息有关联的销售订单，请先清除相关的采购订单再操作！
            ///     <c>1010</c> 删除失败！要删除的商品信息有关联的商品单价信息，请先清除相关的商品单价信息再操作！
            /// 
            /// 从 2000 开始为窗体内报信息提示，不进入数据库查询
            ///     <c>2000</c> 未填写必填信息！请检查并填写完整！
            /// B_major
            ///     <c>2001</c> 主代码编号不能为空！
            ///     <c>2002</c> 主代码名称不能为空！
            /// B_minor
            ///     <c>2003</c> 子代码编号不能为空！
            ///     <c>2004</c> 子代码名称不能为空！
            /// B_partner
            ///     <c>2005</c> 上游销售方和下游采购方至少选择一种！
            /// B_tax
            ///     <c>2006</c> 税率编号不能为空！
            ///     <c>2007</c> 税率名称不能为空！
            ///     <c>2008</c> 税率比例不能为空！
            /// B_user
            ///     <c>2009</c> 人员编号不能为空！
            ///     <c>2010</c> 人员名称不能为空！
            ///     <c>2011</c> 联系电话不能为空！
            ///     <c>2012</c> 所属部门不能为空！
            /// B_item
            ///     <c>2013</c> 商品编号不能为空！
            ///     <c>2014</c> 商品名称不能为空！
            ///     <c>2015</c> 商品单价不能为空！
            ///     <c>2016</c> 商品单位不能为空！
            ///     <c>2017</c> 商品分类不能为空！
            /// B_item_price
            ///     <c>2018</c> 商品单价所属往来单位不能为空！
            /// </para>
            string str = B_message_DAL.Get_Exception_Message(msg_cd);
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
            str.Append(B_message_DAL.Get_Exception_Message("9999"))
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
            /// <para>
            ///     <c>2101</c> 当前有未保存的数据，是否继续操作？
            ///     <c>2102</c> 敏感操作：删除，确认以继续操作。
            /// </para>
            string str = B_message_DAL.Get_Exception_Message(msg_cd);
            return KryptonMessageBox.Show(str, msg_cd.ToString(),
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
