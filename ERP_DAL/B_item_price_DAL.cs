using ERP_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ERP_DAL
{
    public class B_item_price_DAL
    {
        /// <summary>
        /// 获取商品单价信息
        /// </summary>
        /// <param name="item_price">商品单价实例</param>
        /// <param name="item">商品实例</param>
        /// <returns>返回查询结果</returns>
        public DataTable Get_B_Item_Price(B_item_price item_price, B_item item)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT 
                        a.bp_cd, b.bp_nm,
                        a.item_cd, c.item_nm, c.item_spec,
                        a.item_price,
                        dbo.Get_Minor_nm('1003',c.item_unit) AS item_unit_nm,
                        dbo.Get_Minor_nm('1004',c.item_group) AS item_group_nm,
                        a.remark
                    FROM dbo.b_item_price AS a
                    INNER JOIN dbo.b_partner AS b ON b.bp_cd = a.bp_cd
                    INNER JOIN dbo.b_item AS c ON c.item_cd = a.item_cd 
                    WHERE a.bp_cd = N'{0}'
                    AND CASE WHEN N'{1}' = '' THEN ''
                            ELSE c.item_group END = N'{1}'
                    AND c.item_nm LIKE N'%{2}%'",
                    item_price.bp_cd,item.item_group,item.item_nm);

            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }

        /// <summary>
        /// 添加商品单价信息
        /// </summary>
        /// <param name="model">商品单价信息</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Insert_B_Item_Price(B_item_price model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    INSERT INTO dbo.b_item_price
                    (	
	                    bp_cd, item_cd, item_price,remark,
                        ins_user,ins_date,up_user,up_date
                    )
                    VALUES
                    (	
	                    N'{0}', N'{1}', {2}, N'{3}', 
                        N'{4}', GETDATE(),N'{4}', GETDATE()
                    )",
                    model.bp_cd, model.item_cd, model.item_price, model.remark,
                    model.user_cd, model.user_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        /// 删除商品单价信息信息
        /// </summary>
        /// <param name="model">商品单价信息</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Delete_B_Item_Price(B_item_price model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    DELETE FROM dbo.b_item_price
                    WHERE bp_cd = N'{0}' AND item_cd = N'{1}'",
                    model.bp_cd, model.item_cd);
            return DbHelperSQL.ExecuteSql(strSql.ToString()) > 0;
        }

        /// <summary>
        ///     修改商品单价信息信息
        /// </summary>
        /// <param name="model">商品单价信息</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Update_B_Item_Price(B_item_price model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    UPDATE dbo.b_item_price SET
                    item_price	= {2},
                    remark	    = N'{3}',
                    up_user		= N'{4}',   
                    up_date		= GETDATE()
                    WHERE bp_cd = N'{0}' AND item_cd = N'{1}'",
                    model.bp_cd, model.item_cd,
                    model.item_price, model.remark, model.user_cd);
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
        public bool Exist(B_item_price model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(@"
                    SELECT COUNT(1) FROM dbo.b_item_price
                    WHERE bp_cd = N'{0}' AND item_cd = N'{1}'",
                    model.bp_cd, model.item_cd);
            return DbHelperSQL.Exists(strSql.ToString());
        }

    }
}
