﻿using ERP_MODEL;
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

        /// <summary>
        /// 添加子代码信息
        /// </summary>
        /// <param name="model">子代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Insert_B_Minor(B_minor model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    INSERT INTO dbo.b_minor
                    (
                        major_cd,
                        minor_cd,
                        minor_nm,
                        remark,
                        ins_user,
                        ins_date,
                        up_user,
                        up_date
                    )
                    VALUES
                    (   N'{0}',       -- major_cd - nvarchar(6)
                        N'{1}',       -- minor_cd - nvarchar(6)
                        N'{2}',       -- minor_nm - nvarchar(50)
                        N'{3}',      -- remark - nvarchar(100)
                        N'{4}',       -- ins_user - nvarchar(6)
                        GETDATE(), -- ins_date - datetime
                        N'{4}',       -- up_user - nvarchar(6)
                        GETDATE()  -- up_date - datetime
                        )",
                    model.major_cd,
                    model.minor_cd,
                    model.minor_nm,
                    model.remark,
                    model.user_cd,
                    model.user_cd
                    );
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
        public bool Delete_B_Minor(B_minor model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    DELETE FROM dbo.b_minor
                    WHERE major_cd = N'{0}' AND minor_cd = N'{1}'",
                    model.major_cd, model.minor_cd);
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
        public bool Update_B_Minor(B_minor model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    UPDATE dbo.b_minor SET
                    minor_nm = N'{2}',
                    remark = N'{3}',
                    up_user = N'{4}',
                    up_date = GETDATE()
                    WHERE major_cd = N'{0}' AND minor_cd = N'{1}'",
                    model.major_cd,
                    model.minor_cd,
                    model.minor_nm,
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
        public bool Exist(B_minor model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT COUNT(1) FROM dbo.b_minor
                    WHERE major_cd = N'{0}' AND minor_cd = N'{1}'",
                    model.major_cd,
                    model.minor_cd);
            return DbHelperSQL.Exists(strSql.ToString());
            // return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString())) > 0;
        }

        /// <summary>
        ///     根据主代码查询子代码，返回子代码名称，用于下拉框绑定。
        /// <para> 类似当前类的 Exist 方法。 </para>
        /// <para> 同样借用 DBHelper 中的 Exist 方法。</para>
        /// <para> 
        ///     查询时判断综合主键 <c>major_cd</c> 和 <c>minor_cd</c> 的 <c>COUNT</c> 值。
        /// </para>
        /// </summary>
        /// <param name="model">传入的子代码实体</param>
        /// <returns> 返回匹配的数据表 </returns>
        public DataTable Get_Minor_nm(B_minor model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT minor_cd,minor_nm FROM dbo.b_minor
                    WHERE major_cd = N'{0}'",
                    model.major_cd);
            return DbHelperSQL.Query(strSql.ToString()).Tables[0];

        }


        /// <summary>
        /// 查询子代码表，用于参照窗体 Pop.FrmPopMinor
        /// </summary>
        /// <param name="model">子代码实体类</param>
        /// <returns>匹配 <c>major_cd</c> / <c>minor_cd</c> / <c>minor_nm</c> 的子代码结果</returns>
        public DataTable Get_B_Minor_Pop(B_minor model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT minor_cd, minor_nm, remark
                    FROM dbo.b_minor
                    WHERE major_cd = N'{0}'
                    AND minor_cd LIKE N'%{1}%'
                    AND minor_nm LIKE N'%{2}%'",
                    model.major_cd, model.minor_cd, model.minor_nm);

            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
    }
}
