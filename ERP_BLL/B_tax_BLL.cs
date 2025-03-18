using ERP_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_DAL;

namespace ERP_BLL
{
    public class B_tax_BLL
    {
        /// <summary>
        /// DAL 层的辅助实例，方便调用DAL层
        /// </summary>
        B_tax_DAL dal = new B_tax_DAL();

        /// <summary>
        /// 查询税率信息表
        ///     <para>
        ///     如果查询为空，则返回<c>null</c>，由UI层进行处理。
        ///     </para>
        /// </summary>
        /// <returns>
        ///     直接输出查询到的所有数据，
        ///     如果查询为空，则返回<c>null</c>。
        /// </returns>
        /// <exception cref="9999: 未知异常"/>
        public DataTable Get_B_Tax()
        {
            try  // 异常处理
            {
                return dal.Get_B_Tax();
            }
            catch (Exception ex)
            {
                B_message_BLL.ShowUnkownError(ex);
                return null;
            }
        }

        /// <summary>
        /// 插入税率信息行
        /// </summary>
        /// <param name="model">税率信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1001: 主代码已存在"/>
        /// <exception cref="2006: 税率编号不能为空"/>
        /// <exception cref="2007: 税率名称不能为空"/>
        /// <exception cref="2008: 税率比例不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Insert_B_Tax(B_tax model)
        {   // 判断税率编号是否为空 2006
            if (String.IsNullOrWhiteSpace(model.tax_cd))
            {
                B_message_BLL.ShowConfirm("2006");
                return false;
            }
            // 判断税率名称名称是否为空 2007
            if (String.IsNullOrWhiteSpace(model.tax_nm))
            {
                B_message_BLL.ShowConfirm("2007");
                return false;
            }
            // 判断税率比例是否为空 2008
            if(String.IsNullOrWhiteSpace(model.tax_rate.ToString()))
            {
                B_message_BLL.ShowConfirm("2008");
            }
            // 保存前判断是否存在相同的主代码 1001
            if (dal.Exist(model))
            {
                B_message_BLL.ShowConfirm("1001");
                return false;
            }
            // 保存数据，未知异常处理 ex
            try
            {
                return dal.Insert_B_Tax(model);
            }
            catch (Exception ex)
            {
                B_message_BLL.ShowUnkownError(ex);
                return false;
            }
        }

        /// <summary>
        /// 删除税率信息信息
        /// </summary>
        /// <param name="model">税率信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1004: 未找到要删除的数据"/>
        /// <exception cref="2001: 主代码不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Delete_B_Tax(B_tax model)
        {
            // 判断主代码是否为空 2001
            if (String.IsNullOrWhiteSpace(model.tax_cd))
            {
                B_message_BLL.ShowConfirm("2001");
                return false;
            }
            // 保存前判断是否存在要操作的数据 1001 / ex
            if (dal.Exist(model))
            {   // 存在该数据，则执行删除操作
                try
                {
                    return dal.Delete_B_Tax(model);
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

        /// <summary>
        /// 修改税率信息信息
        /// </summary>
        /// <param name="model">税率信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1005: 未找到要更新的数据"/>
        /// <exception cref="2007: 税率名称不能为空"/>
        /// <exception cref="2008: 税率比例不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Update_B_Tax(B_tax model)
        {   // 判断当前税率名称是否为空
            if (String.IsNullOrWhiteSpace(model.tax_nm))
            {
                B_message_BLL.ShowConfirm("2007");
                return false;
            }
            // 判断当前税率比例是否为空
            if (String.IsNullOrWhiteSpace(model.tax_rate.ToString()))
            {
                B_message_BLL.ShowConfirm("2008");
                return false;
            }
            // 保存前判断是否存在要操作的数据 ex / 1005
            if (dal.Exist(model))
            {   // 存在该数据，则执行修改操作
                try
                {
                    return dal.Update_B_Tax(model);
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

    }
}
