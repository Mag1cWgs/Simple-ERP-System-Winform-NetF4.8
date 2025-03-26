using ERP_DAL;
using ERP_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_BLL
{
    public class B_item_price_BLL
    {
        /// <summary>
        /// 实例化商品单价信息数据访问层，用于数据库操作
        /// </summary>
        B_item_price_DAL dal = new B_item_price_DAL();

        /// <summary>
        /// 获取商品单价信息
        /// </summary>
        /// <param name="item_price">商品单价实例</param>
        /// <param name="item">商品实例</param>
        /// <returns>
        ///     匹配 <c>item_price.bp_cd</c>,
        ///     <c>item.item_group</c>,
        ///     <c>item.item_nm</c> 的结果，
        ///     如果查询为空，则返回<c>null</c>。
        /// </returns>
        /// <exception cref="9999: 未知异常"/>
        public DataTable Get_B_Item_Price(B_item_price item_price, B_item item)
        {
            try
            {
                return dal.Get_B_Item_Price(item_price, item);
            }
            catch (Exception ex)
            {
                B_message_BLL.ShowUnkownError(ex);
                return null;
            }
        }

        /// <summary>
        /// 插入商品单价信息
        /// </summary>
        /// <param name="model">商品单价信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1001: 主代码已存在"/>
        /// <exception cref="2013: 商品编号不能为空"/>
        /// <exception cref="2015: 商品单价不能为空"/>
        /// <exception cref="2018: 商品单价所属往来单位编号不能为空!"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Insert_B_Item_Price(B_item_price model)
        {
            // 判断商品单价信息代码是否为空
            if (String.IsNullOrWhiteSpace(model.item_cd))
            {
                B_message_BLL.ShowConfirm("2013");
                return false;
            }
            // 判断商品单价是否为空
            if (String.IsNullOrWhiteSpace(model.item_price.ToString()))
            {
                B_message_BLL.ShowConfirm("2015");
                return false;
            }
            // 判断商品单价所属往来单位是否为空
            if (String.IsNullOrWhiteSpace(model.bp_cd))
            {
                B_message_BLL.ShowConfirm("2018");
                return false;
            }
            // 保存前判断是否存在相同的主代码
            if (dal.Exist(model))
            {
                B_message_BLL.ShowConfirm("1001");
                return false;
            }
            try  // 保存数据，未知异常处理
            {
                return dal.Insert_B_Item_Price(model);
            }
            catch (Exception ex)
            {
                B_message_BLL.ShowUnkownError(ex);
                return false;
            }
        }

        /// <summary>
        /// 修改商品单价信息信息
        /// </summary>
        /// <param name="model">商品单价信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1005: 未找到要更新的数据"/>
        /// <exception cref="2013: 商品编号不能为空"/>
        /// <exception cref="2015: 商品单价不能为空"/>
        /// <exception cref="2018: 商品单价所属往来单位编号不能为空!"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Update_B_Item_Price(B_item_price model)
        {
            // 判断商品单价信息代码是否为空
            if (String.IsNullOrWhiteSpace(model.item_cd))
            {
                B_message_BLL.ShowConfirm("2013");
                return false;
            }
            // 判断商品单价是否为空
            if (String.IsNullOrWhiteSpace(model.item_price.ToString()))
            {
                B_message_BLL.ShowConfirm("2015");
                return false;
            }
            // 判断商品单价所属往来单位是否为空
            if (String.IsNullOrWhiteSpace(model.bp_cd))
            {
                B_message_BLL.ShowConfirm("2018");
                return false;
            }
            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {   // 存在该数据，则执行修改操作
                try
                {
                    return dal.Update_B_Item_Price(model);
                }
                catch (Exception ex)
                {
                    B_message_BLL.ShowUnkownError(ex);
                    return false;
                }
            }
            else // 不存在该数据
            {
                B_message_BLL.ShowConfirm("1005");
                return false;
            }
        }

        /// <summary>
        /// 删除商品单价信息信息
        /// </summary>
        /// <param name="model">商品单价信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1004: 未找到要删除的数据"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Delete_B_Item_Price(B_item_price model)
        {
            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {
                // 执行删除操作
                try
                {
                    return dal.Delete_B_Item_Price(model);
                }
                catch (Exception ex)
                {
                    B_message_BLL.ShowUnkownError(ex);
                    return false;
                }
            }
            else // 不存在该数据
            {
                B_message_BLL.ShowConfirm("1004");
                return false;
            }
        }


    }
}
