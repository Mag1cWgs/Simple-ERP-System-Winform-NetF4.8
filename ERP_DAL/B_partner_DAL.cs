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


        /// <summary>
        /// 添加往来单位信息
        /// </summary>
        /// <param name="model">往来单位实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Insert_B_Partner(B_partner model)
        {
            string so_flag = model.so_flag == true ? "Y" : "N";
            string po_flag = model.po_flag == true ? "Y" : "N";
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    INSERT INTO dbo.b_partner
                    (
                        bp_cd,bp_full_nm,bp_nm,bp_addr,
                        bp_repre, bp_tel,bp_email,
                        bp_tax,so_flag,po_flag,
                        bank_cd, bank_acct_no,pay_type,
                        remark,
                        ins_user,ins_date,up_user,up_date
                    )
                    VALUES
                    (   N'{0}',N'{1}',N'{2}',N'{3}',       
                        N'{4}',N'{5}',N'{6}',      
                        N'{7}',N'{8}', N'{9}',       
                        N'{10}',N'{11}',N'{12}',       
                        N'{13}',      
                        N'{14}',GETDATE(),N'{14}',GETDATE()
                        )",
                        model.bp_cd, model.bp_full_nm, model.bp_nm, model.bp_addr,
                        model.bp_repre, model.bp_tel, model.bp_email,
                        model.bp_tax, so_flag, po_flag,
                        model.bank_cd, model.bank_acct_no, model.pay_type,
                        model.remark,
                        model.user_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        /// 删除子代码信息
        /// </summary>
        /// <param name="model">子代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Delete_B_Partner(B_partner model)
        {
            string so_flag = model.so_flag == true ? "Y" : "N";
            string po_flag = model.po_flag == true ? "Y" : "N";
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    DELETE FROM dbo.b_partner WHERE bp_cd = N'{0}'
                    ",model.bp_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        ///     修改子代码信息
        /// </summary>
        /// <param name="model">子代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Update_B_Partner(B_partner model)
        {
            string so_flag = model.so_flag == true ? "Y" : "N";
            string po_flag = model.po_flag == true ? "Y" : "N";
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    UPDATE dbo.b_partner SET
                    bp_full_nm = N'{1}',bp_nm = N'{2}',
                    bp_addr = N'{3}',
                    bp_repre = N'{4}',
                    bp_tel = N'{5}',
                    bp_email = N'{6}',
                    bp_tax = N'{7}',
                    so_flag = N'{8}',
                    po_flag = N'{9}',
                    bank_cd = N'{10}',
                    bank_acct_no = N'{11}',
                    pay_type = N'{12}',
                    remark = N'{13}',
                    up_user = N'{14}',
                    up_date = GETDATE()
                    WHERE bp_cd = N'{0}'
                    ",
                    model.bp_cd, model.bp_full_nm, model.bp_nm, model.bp_addr,
                    model.bp_repre, model.bp_tel, model.bp_email,
                    model.bp_tax, so_flag, po_flag,
                    model.bank_cd, model.bank_acct_no, model.pay_type,
                    model.remark,
                    model.user_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        /// 保存前验证是否有主键冲突
        /// <para> 使用 DBHelper 中的 Exist 方法 </para>
        /// <para> 
        ///     查询时判断综合主键 <c>major_cd</c> 和 <c>minor_cd</c> 的 <c>COUNT</c> 值
        /// </para>
        /// </summary>
        /// <param name="model"></param>
        /// <returns>
        ///     返回 <c>True</c> 是存在同名主键数据；
        ///     返回 <c>False</c> 不存在主键冲突。
        /// </returns>
        public bool Exist(B_partner model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT COUNT(1) FROM dbo.b_partner
                    WHERE bp_cd = N'{0}'",
                    model.bp_cd);
            return DbHelperSQL.Exists(strSql.ToString());
        }
    }
}
