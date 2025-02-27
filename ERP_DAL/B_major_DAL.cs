using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;

namespace ERP_DAL
{
    /// <summary>
    /// 主代码数据访问层
    /// </summary>
    public class B_major_DAL
    {
        /// <summary>
        /// 查询主代码表
        /// </summary>
        /// <param name="model">主代码实体类</param>
        /// <returns>匹配 major_cd 或 major_nm 的结果</returns>
        public DataTable Get_B_Major(B_major model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT major_cd,major_nm,remark FROM dbo.b_major
                    WHERE major_cd LIKE N'%{0}%'
                    AND major_nm LIKE N'%{1}%'",
                    model.major_cd,
                    model.major_nm);

            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }

        /// <summary>
        /// 添加主代码信息
        /// </summary>
        /// <param name="model">主代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Insert_B_Major(B_major model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    INSERT INTO dbo.b_major
                    (major_cd,major_nm,remark,ins_user,ins_date,up_user,up_date)
                    VALUES
                    (N'{0}',N'{1}',N'{2}',N'{3}',GETDATE(),N'{3}',GETDATE())",
                    model.major_cd,
                    model.major_nm,
                    model.remark,
                    model.user_cd,
                    model.user_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        /// 删除主代码信息
        /// </summary>
        /// <param name="model">主代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Delete_B_Major(B_major model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    DELETE FROM dbo.b_major
                    WHERE major_cd = N'{0}'",
                    model.major_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        ///     修改主代码信息
        /// </summary>
        /// <param name="model">主代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Update_B_Major(B_major model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    UPDATE dbo.b_major SET
                    major_nm = N'{1}',
                    remark = N'{2}',
                    up_user = N'{3}',
                    up_date = GETDATE()
                    WHERE major_cd = N'{0}'",
                    model.major_cd,
                    model.major_nm,
                    model.remark,
                    model.user_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        /// 保存前验证是否有主键冲突
        /// </summary>
        /// <remarks> 使用 DBHelper 中的 Exist 方法 </remarks>
        /// <param name="model"></param>
        /// <returns>
        ///     返回 <c>True</c> 是存在同名主键数据；
        ///     返回 <c>False</c> 不存在主键冲突。
        /// </returns>
        public bool Exist(B_major model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT COUNT(1) FROM dbo.b_major
                    WHERE major_cd = N'{0}'",
                    model.major_cd);
            return DbHelperSQL.Exists(strSql.ToString());
            // return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString())) > 0;
        }

        /// <summary>
        /// 删除主代码前验证是否有外键关联
        /// <para>
        ///     对应的外键表：b_minor
        /// </para>
        /// </summary>
        /// <param name="model">子代码实体类</param>
        /// <returns>
        ///     返回 <c>True</c> 是存在使用当前主代码的子代码实体；
        ///     返回 <c>False</c> 不存在主键冲突。
        /// </returns>
        public bool ExistMinor(B_major model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT COUNT(1) FROM dbo.b_minor
                    WHERE major_cd = N'{0}'",
                    model.major_cd);
            return DbHelperSQL.Exists(strSql.ToString());
        }
    }
}
