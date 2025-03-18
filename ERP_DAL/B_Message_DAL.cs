using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DAL
{
    /// <summary>
    /// 消息提示类数据访问层
    /// </summary>
    public abstract class B_message_DAL
    {
        /// <summary>
        ///     获取异常信息，通过输入的消息代码获取对应的消息文本：
        ///     接受 <c>string</c> 类型的 <paramref name="code"/>，拼接后作为 <c>msg_cd</c> 字段进行查询。
        /// </summary>
        /// <remarks>
        /// <para>
        ///     <c>string</c> 类变量 <paramref name="code"/> 
        ///     保证了 <c>0000 ~ 0999</c> 之间值可以正常的拼接在数据库查询语句中。
        /// </para>
        /// <para>
        ///     因为数据库中的标量值函数中 <c>@msg_cd</c> 是以 <c>'XXXX'</c> 格式判断，
        ///     使用 <c>int</c> 类型的参数会丢失全 <c>0</c> 前缀。
        /// </para>
        /// </remarks>
        /// <param name="msg_cd">消息代码</param>
        /// <returns>
        ///     异常信息字符串 <c>msg_text</c>
        /// </returns>
        public static string Get_Exception_Message(string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT dbo.Get_Message('{0}') AS msg_text",
                    code);
            SqlDataReader reader = DbHelperSQL.ExecuteReader(strSql.ToString());
            if ( reader.Read())
            {
                return reader["msg_text"].ToString();
            }
            return null;
        }
    }
}
