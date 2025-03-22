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

        public DataTable Get_B_Item(B_item model)
        {
            return null;
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
            // 保存数据，未知异常处理
            try
            {
                return dal.Insert_B_Item(model);
            }
            catch (Exception ex)
            {
                B_message_BLL.ShowUnkownError(ex);
                return false;
            }
        }


        public bool Update_B_Item(B_item model)
        {
            return false;
        }

        public bool Delete_B_Item(B_item model)
        {
            return false;
        }
    }
}
