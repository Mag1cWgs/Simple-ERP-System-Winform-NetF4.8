using ERP_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DAL
{
    public class B_user_DAL
    {
        /// <summary>
        /// 查询人员信息表
        /// </summary>
        /// <param name="model">人员信息实体类</param>
        /// <returns>匹配 user_nm 的结果</returns>
        public DataTable Get_B_User(B_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT user_cd,user_nm,tel_no,dept_nm,remark
                    FROM dbo.b_user
                    WHERE user_nm LIKE N'%{0}%'",
                    model.user_nm);

            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }


    }
}
