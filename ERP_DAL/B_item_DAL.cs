using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_MODEL;

namespace ERP_DAL
{
    public class B_item_DAL
    {
        /// <summary>
        /// 查询商品信息
        /// </summary>
        /// <param name="model">商品信息实体类</param>
        /// <returns>匹配 <c>item_nm</c> 或 <c>item_group</c> 的结果</returns>
        public DataTable Get_B_Item(B_item model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT 
	                    item_cd, item_nm, item_spec, item_price,
	                    item_unit, dbo.Get_Minor_nm('1003',item_unit) AS item_unit_nm,
                        item_group, dbo.Get_Minor_nm('1004',item_group) AS item_group_nm,
	                    sl_cd, dbo.Get_Minor_nm('1005',sl_cd) AS sl_nm,
	                    remark FROM dbo.b_item
                    WHERE item_nm LIKE N'%{0}%'
                    AND CASE WHEN N'{1}' = '' THEN ''
                        ELSE item_group END = N'{1}'",
                    model.item_nm,
                    model.item_group);

            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }

        /// <summary>
        /// 添加商品信息
        /// </summary>
        /// <param name="model">商品信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Insert_B_Item(B_item model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    INSERT INTO dbo.b_item
                    (	
	                    item_cd,item_nm,item_spec,item_price,item_unit,
	                    item_group,sl_cd,remark,ins_user,ins_date,up_user,up_date
                    )
                    VALUES
                    (	
	                    N'{0}', N'{1}', N'{2}', {3}, N'{4}', 
	                    N'{5}', N'{6}', N'{7}', N'{8}', GETDATE(),N'{8}', GETDATE()
                    )",
                    model.item_cd, model.item_nm, model.item_spec, model.item_price, model.item_unit,
                    model.item_group, model.sl_cd, model.remark, model.user_cd, model.user_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }


        /// <summary>
        /// 删除商品信息信息
        /// </summary>
        /// <param name="model">商品信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Delete_B_Item(B_item model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    DELETE FROM dbo.b_item
                    WHERE item_cd = N'{0}'",
                    model.item_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        ///     修改商品信息信息
        /// </summary>
        /// <param name="model">商品信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Update_B_Item(B_item model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    UPDATE dbo.b_item SET
                    item_nm		= N'{1}',
                    item_spec	= N'{2}',
                    item_price	= {3},
                    item_unit	= N'{4}',
                    item_group	= N'{5}',
                    sl_cd		= N'{6}',
                    remark		= N'{7}',
                    up_user		= N'{8}',   
                    up_date		= GETDATE()
                    WHERE item_cd = N'{0}'",
                    model.item_cd, model.item_nm, model.item_spec, model.item_price,
                    model.item_unit, model.item_group, model.sl_cd, model.remark,
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
        public bool Exist(B_item model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT COUNT(1) FROM dbo.b_item
                    WHERE item_cd = N'{0}'",
                    model.item_cd);
            return DbHelperSQL.Exists(strSql.ToString());
        }

    }
}
