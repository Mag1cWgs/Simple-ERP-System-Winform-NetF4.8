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
    public class B_partner_BLL
    {
        /// <summary>
        /// 实例化往来单位数据访问层，用于数据库操作
        /// </summary>
        B_partner_DAL dal = new B_partner_DAL();

        /// <summary>
        /// 接受往来单位信息实体，查询主代码表
        ///     <para>
        ///     如果查询为空，则返回<c>null</c>，由UI层进行处理。
        ///     </para>
        /// </summary>
        /// <param name="model">往来单位信息实体类</param>
        /// <returns>
        ///     匹配的结果，如果查询为空，则返回<c>null</c>。
        /// </returns>
        /// <exception cref="9999: 未知异常"/>
        public DataTable Get_B_Partner(B_partner model)
        {
            try
            {
                return dal.Get_B_Partner(model);
            }
            catch (Exception ex)
            {
                B_Message_BLL.ShowUnkownError(ex);
                return null;
            }
        }


        /// <summary>
        /// 插入往来单位信息
        /// </summary>
        /// <param name="model">往来单位信息</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1001: 主代码已存在"/>
        /// <exception cref="2000: 缺少必填项"/>
        /// <exception cref="2005: 不应存在既非销售方又非采购方的实体"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Insert_B_Partner(B_partner model)
        {   // 判断非空条件，均报 2000 异常
            if (String.IsNullOrWhiteSpace(model.bp_cd))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_full_nm))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_nm))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_addr))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_repre))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_tel))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_email))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_tax))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bank_acct_no))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            // 既非上游销售方又非下游采购方时报 2005 异常
            if(model.flag == null)
            {
                B_Message_BLL.ShowConfirm("2005");
                return false;
            }
            // 保存前判断是否存在相同的主代码
            if (dal.Exist(model))
            {
                B_Message_BLL.ShowConfirm("1001");
                return false;
            }
            // 保存数据，未知异常处理
            try
            {
                return dal.Insert_B_Partner(model);
            }
            catch (Exception ex)
            {
                B_Message_BLL.ShowUnkownError(ex);
                return false;
            }
        }

        /// <summary>
        /// 删除往来单位信息
        /// </summary>
        /// <param name="model">往来单位信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1004: 未找到要删除的数据"/>
        /// <exception cref="2003: 子代码不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Delete_B_Partner(B_partner model)
        {
            // 判断主代码是否为空
            if (String.IsNullOrWhiteSpace(model.bp_cd))
            {
                B_Message_BLL.ShowConfirm("2001");
                return false;
            }

            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {
                try   // 存在该数据，则执行删除操作
                {
                    return dal.Delete_B_Partner(model);
                }
                catch (Exception ex)
                {
                    B_Message_BLL.ShowUnkownError(ex);
                    return false;
                }
            }
            else // 不存在该数据
            {
                B_Message_BLL.ShowConfirm("1004");
                return false;
            }
        }

        /// <summary>
        /// 修改往来单位信息
        /// </summary>
        /// <param name="model">往来单位信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1005: 未找到要更新的数据"/>
        /// <exception cref="2000: 未填写必填信息"/>
        /// <exception cref="2005: 不应存在既非销售方又非采购方的实体"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Update_B_Partner(B_partner model)
        {
            // 判断非空条件，均报 2000 异常
            if (String.IsNullOrWhiteSpace(model.bp_full_nm))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_nm))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_addr))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_repre))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_tel))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_email))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bp_tax))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            if (String.IsNullOrWhiteSpace(model.bank_acct_no))
            {
                B_Message_BLL.ShowConfirm("2000");
                return false;
            }
            // 既非上游销售方又非下游采购方时报 2005 异常
            if (model.flag == null)
            {
                B_Message_BLL.ShowConfirm("2005");
                return false;
            }
            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {   // 存在该数据，则执行修改操作
                try
                {
                    return dal.Update_B_Partner(model);
                }
                catch (Exception ex)
                {
                    B_Message_BLL.ShowUnkownError(ex);
                    return false;
                }
            }
            else // 不存在该数据
            {
                B_Message_BLL.ShowConfirm("1005");
                return false;
            }
        }
    }
}
