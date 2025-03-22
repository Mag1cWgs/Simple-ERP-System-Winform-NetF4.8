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
        /// <returns>匹配  的结果</returns>
        public DataTable Get_B_Item(B_item model)
        {
            return null;
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
