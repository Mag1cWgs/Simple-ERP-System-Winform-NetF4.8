using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ERP_MODEL;

namespace ERP_DAL
{
    public class B_partner_DAL
    {
        /// <summary>
        /// 查询往来单位信息
        /// </summary>
        /// <param name="model">往来单位实体类</param>
        /// <returns>匹配的往来单位结果</returns>
        public DataTable Get_B_Partner(B_partner model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT bp_cd,
                           bp_full_nm,
                           bp_nm,
                           bp_addr,
                           bp_repre,
                           bp_tel,
                           bp_email,
                           bp_tax,
                           so_flag,
                           po_flag,
                           bank_cd,
	                       dbo.Get_Minor_nm('1002',bank_cd) AS bank_cd_nm,
                           bank_acct_no,
                           pay_type,
	                       dbo.Get_Minor_nm('1001',pay_type) AS pay_type_nm,
                           remark
                    FROM dbo.b_partner
                    WHERE CASE
	                    WHEN N'{0}' = N's' THEN so_flag
	                    WHEN N'{0}' = N'p' THEN po_flag
	                    ELSE 'Y' END  = 'Y'
                    AND bp_full_nm LIKE '%{1}%'
                    AND bp_repre LIKE '%{2}%'",
                    model.flag,
                    model.bp_full_nm,
                    model.bp_repre);

            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
    }
}
