using ERP_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DAL
{
    public class B_tax_DAL
    {
        /// <summary>
        /// 查询税率表
        /// </summary>
        /// <returns>匹配 tax_cd 或 tax_nm 的结果</returns>
        public DataTable Get_B_Tax()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT tax_cd,tax_nm,tax_rate,remark FROM dbo.b_tax");
            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }

        /// <summary>
        /// 添加税率信息
        /// </summary>
        /// <param name="model">税率信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Insert_B_Tax(B_tax model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    INSERT INTO dbo.b_tax(
	                    tax_cd,tax_nm,tax_rate,remark,
	                    ins_user,ins_date,up_user,up_date)
                    VALUES(
	                    N'{0},N'{1}',N'{2}',N'{3}',
	                    N'{4}',GETDATE(),N'{4}',GETDATE())",
                    model.tax_cd, model.tax_nm, model.tax_rate, model.remark,
                    model.user_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        /// 删除税率信息信息
        /// </summary>
        /// <param name="model">税率信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Delete_B_Tax(B_tax model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    DELETE FROM dbo.b_tax WHERE tax_cd = N'{0}'",
                    model.tax_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        ///     修改税率信息信息
        /// </summary>
        /// <param name="model">税率信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Update_B_Tax(B_tax model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    UPDATE dbo.b_tax SET
                        tax_nm = N'{1}',
                        tax_rate = N'{2}',
                        remark = N'{3}',
                        up_user = N'{4}',
                        up_date = GETDATE()
                    WHERE tax_cd = N'{0}'",
                    model.tax_cd,
                    model.tax_cd,
                    model.tax_nm,
                    model.remark,
                    model.user_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        /// 保存前验证是否有主键冲突
        /// </summary>
        /// <remarks> 使用 DBHelper 中的 Exist 方法 </remarks>
        /// <param name="model">税率信息实体</param>
        /// <returns>
        ///     返回 <c>True</c> 是存在同名主键数据；
        ///     返回 <c>False</c> 不存在主键冲突。
        /// </returns>
        public bool Exist(B_tax model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT COUNT(1) FROM dbo.b_tax
                    WHERE tax_cd = N'{0}'",
                    model.tax_cd);
            return DbHelperSQL.Exists(strSql.ToString());
        }

    }
}
