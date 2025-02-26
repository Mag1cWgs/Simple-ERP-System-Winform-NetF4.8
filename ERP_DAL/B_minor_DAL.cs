using ERP_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DAL
{
    public class B_minor_DAL
    {
        /// <summary>
        /// 查询子代码表
        /// </summary>
        /// <param name="model">子代码实体类</param>
        /// <returns>匹配 <c>major_cd</c> 的子代码结果</returns>
        public DataTable Get_B_Minor(B_minor model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT minor_cd, minor_nm, remark
                    FROM dbo.b_minor
                    WHERE major_cd = N'{0}'",
                    model.major_cd);

            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
    }
}
