using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_DAL;
using ERP_MODEL;

namespace ERP_BLL
{
    public class B_item_BLL
    {
        /// <summary>
        /// 实例化商品信息数据访问层，用于数据库操作
        /// </summary>
        B_item_DAL dal = new B_item_DAL();

        /// <summary>
        /// 接受商品信息实体，查询主代码表
        ///     <para>
        ///     如果查询为空，则返回<c>null</c>，由UI层进行处理。
        ///     </para>
        /// </summary>
        /// <param name="model">商品信息实体类</param>
        /// <returns>
        ///     匹配 <c>item_nm</c> 或 <c>item_group</c> 的结果，
        ///     如果查询为空，则返回<c>null</c>。
        /// </returns>
        /// <exception cref="9999: 未知异常"/>
        public DataTable Get_B_Item(B_item model)
        {
            try
            {
                return dal.Get_B_Item(model);
            }
            catch (Exception ex)
            {
                B_message_BLL.ShowUnkownError(ex);
                return null;
            }
        }

        /// <summary>
        /// 插入商品信息
        /// </summary>
        /// <param name="model">商品信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1001: 主代码已存在"/>
        /// <exception cref="2001: 主代码不能为空"/>
        /// <exception cref="2002: 主代码名称不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Insert_B_Item(B_item model)
        {   // 判断商品信息代码是否为空
            if (String.IsNullOrWhiteSpace(model.item_cd))
            {
                B_message_BLL.ShowConfirm("2013");
                return false;
            }
            // 判断商品信息名称是否为空
            if (String.IsNullOrWhiteSpace(model.item_nm))
            {
                B_message_BLL.ShowConfirm("2014");
                return false;
            }
            // 判断商品单价是否为空
            if (String.IsNullOrWhiteSpace(model.item_price.ToString()))
            {
                B_message_BLL.ShowConfirm("2015");
                return false;
            }
            // 判断商品单位是否为空
            if (String.IsNullOrWhiteSpace(model.item_unit))
            {
                B_message_BLL.ShowConfirm("2016");
                return false;
            }
            // 判断商品分类是否为空
            if (String.IsNullOrWhiteSpace(model.item_group))
            {
                B_message_BLL.ShowConfirm("2017");
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
                return dal.Insert_B_Item(model);
            }
            catch (Exception ex)
            {
                B_message_BLL.ShowUnkownError(ex);
                return false;
            }
        }

        /// <summary>
        /// 修改商品信息信息
        /// </summary>
        /// <param name="model">商品信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1005: 未找到要更新的数据"/>
        /// <exception cref="2002: 主代码名称不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Update_B_Item(B_item model)
        {
            // 判断当前主代码名称是否为空
            if (String.IsNullOrWhiteSpace(model.item_nm))
            {
                B_message_BLL.ShowConfirm("2002");
                return false;
            }
            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {   // 存在该数据，则执行修改操作
                try
                {
                    return dal.Update_B_Item(model);
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
        /// 删除商品信息信息
        /// </summary>
        /// <param name="model">商品信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1004: 未找到要删除的数据"/>
        /// <exception cref="1008: 有关联的采购订单"/>
        /// <exception cref="1009: 有关联的销售订单"/>
        /// <exception cref="1010: 有关联的商品单价信息"/>
        /// <exception cref="2001: 主代码不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Delete_B_Item(B_item model)
        {
            // 判断主代码是否为空
            if (String.IsNullOrWhiteSpace(model.item_cd))
            {
                B_message_BLL.ShowConfirm("2001");
                return false;
            }
            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {
                // 判断是否有关联的采购订单
                if (dal.Exist_Po_dtl(model))
                {
                    B_message_BLL.ShowConfirm("1008");
                    return false;
                }
                // 判断是否有关联的销售订单
                if (dal.Exist_So_dtl(model))
                {
                    B_message_BLL.ShowConfirm("1009");
                    return false;
                }
                // 判断是否有关联的商品单价信息
                if (dal.Exist_B_Item_Price(model))
                {
                    B_message_BLL.ShowConfirm("1010");
                    return false;
                }
                // 执行删除操作
                try
                {
                    return dal.Delete_B_Item(model);
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
