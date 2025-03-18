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

        /// <summary>
        /// 添加人员信息信息
        /// </summary>
        /// <param name="model">人员信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Insert_B_User(B_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    INSERT INTO dbo.b_user
                    (user_cd, user_nm, tel_no, dept_nm,
                    remark,ins_user,ins_date,up_user,up_date)
                    VALUES
                    (N'{0}',N'{1}',N'{2}',N'{3}',
                    N'{4}',N'{5}',GETDATE(),N'{5}',GETDATE())",
                    model.user_cd, model.user_nm, model.tel_no, model.dept_nm,
                    model.remark,  model.user_using_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        /// 删除人员信息信息
        /// </summary>
        /// <param name="model">人员信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Delete_B_User(B_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    DELETE FROM dbo.b_user
                    WHERE user_cd = N'{0}'",
                    model.user_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        ///     修改人员信息信息
        /// </summary>
        /// <param name="model">人员信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Update_B_User(B_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    UPDATE dbo.b_user SET
                    user_nm = N'{1}',
                    tel_no = N'{2}',
                    dept_nm = N'{3}',
                    remark = N'{4}',
                    up_user = N'{5}',
                    up_date = GETDATE()
                    WHERE user_cd = N'{0}'",
                    model.user_cd,
                    model.user_nm,
                    model.tel_no,
                    model.dept_nm,
                    model.remark,
                    model.user_using_cd);
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
        public bool Exist(B_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT COUNT(1) FROM dbo.b_user
                    WHERE user_cd = N'{0}'",
                    model.user_cd);
            return DbHelperSQL.Exists(strSql.ToString());
        }


    }
}
