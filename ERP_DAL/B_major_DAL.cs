using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;

namespace ERP_DAL
{
    public class B_major_DAL
    {
        /// <summary>
        /// 接受主代码实体，查询主代码表
        /// </summary>
        /// <param name="model">主代码实体类</param>
        /// <returns>匹配 major_cd 或 major_nm 的结果</returns>
        public DataTable Get_B_Major(B_major model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
            SELECT major_cd,major_nm,remark FROM dbo.b_major
            WHERE major_cd LIKE N'%{0}%'
            OR major_nm LIKE N'%{1}%'",
            model.major_cd,
            model.major_nm);

            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
    }
}
