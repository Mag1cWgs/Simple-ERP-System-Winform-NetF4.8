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
    public class B_user_BLL
    {
        #region 辅助字段 / 辅助函数
        /// <summary>
        /// 实例化人员信息数据访问层，用于数据库操作
        /// </summary>
        B_user_DAL dal = new B_user_DAL();

        /// <summary>
        /// 判断当前传入的人员信息实体是否为空，
        ///     <c>remark</c> 字段可为空
        /// </summary>
        /// <param name="model"></param>
        /// <exception cref="2009: 人员信息不能为空"/>
        /// <exception cref="2010: 人员信息名称不能为空"/>
        /// <exception cref="2011: 联系电话不能为空"/>
        /// <exception cref="2012: 所属部门不能为空"/>
        private bool NotEmptyModel(B_user model)
        {
            // 判断人员信息是否为空
            if (String.IsNullOrWhiteSpace(model.user_cd))
            {
                B_message_BLL.ShowConfirm("2009");
                return false;
            }
            // 判断人员信息名称是否为空
            if (String.IsNullOrWhiteSpace(model.user_nm))
            {
                B_message_BLL.ShowConfirm("2010");
                return false;
            }
            // 判断人员信息联系电话是否为空
            if (String.IsNullOrWhiteSpace(model.tel_no))
            {
                B_message_BLL.ShowConfirm("2011");
                return false;
            }
            // 判断人员信息所属部门是否为空
            if (String.IsNullOrWhiteSpace(model.dept_nm))
            {
                B_message_BLL.ShowConfirm("2012");
                return false;
            }
            return true;
        }
        #endregion


        /// <summary>
        /// 接受人员信息实体，查询人员信息表
        ///     <para>
        ///     如果查询为空，则返回<c>null</c>，由UI层进行处理。
        ///     </para>
        /// </summary>
        /// <param name="model">人员信息实体类</param>
        /// <returns>
        ///     匹配 user_nm</c> 的结果，
        ///     如果查询为空，则返回<c>null</c>。
        /// </returns>
        /// <exception cref="9999: 未知异常"/>
        public DataTable Get_B_User(B_user model)
        {
            try  // 异常处理
            {
                return dal.Get_B_User(model);
            }
            catch (Exception ex)
            {
                B_message_BLL.ShowUnkownError(ex);
                return null;
            }
        }

        /// <summary>
        /// 插入人员信息行
        /// </summary>
        /// <param name="model">人员信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1001: 人员信息已存在"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Insert_B_User(B_user model)
        {
            // 判断人员信息是否为空
            NotEmptyModel(model);

            // 保存前判断是否存在相同的人员信息
            if (dal.Exist(model))
            {
                B_message_BLL.ShowConfirm("1001");
                return false;
            }
            // 保存数据，未知异常处理
            try
            {
                return dal.Insert_B_User(model);
            }
            catch (Exception ex)
            {
                B_message_BLL.ShowUnkownError(ex);
                return false;
            }
        }

        /// <summary>
        /// 删除人员信息信息
        /// </summary>
        /// <param name="model">人员信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1004: 未找到要删除的数据"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Delete_B_User(B_user model)
        {
            // 判断人员信息是否为空
            NotEmptyModel(model);

            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {
                try   // 存在该数据，则执行删除操作
                {
                    return dal.Delete_B_User(model);
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
        /// 修改人员信息信息
        /// </summary>
        /// <param name="model">人员信息实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1005: 未找到要更新的数据"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Update_B_User(B_user model)
        {
            // 判断人员信息是否为空
            NotEmptyModel(model);

            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {   // 存在该数据，则执行修改操作
                try
                {
                    return dal.Update_B_User(model);
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
