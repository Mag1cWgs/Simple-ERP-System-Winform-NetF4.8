﻿using ERP_DAL;
using ERP_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_BLL
{
    public class B_minor_BLL
    {
        /// <summary>
        /// 实例化子代码数据访问层，用于数据库操作
        /// </summary>
        B_minor_DAL dal = new B_minor_DAL();

        /// <summary>
        /// 接受子代码实体，查询子代码表
        ///     <para>
        ///     如果查询为空，则返回<c>null</c>，由UI层进行处理。
        ///     </para>
        /// </summary>
        /// <param name="model">子代码实体类</param>
        /// <returns>
        ///     匹配 <c>major_cd</c>  的结果，
        ///     如果查询为空，则返回<c>null</c>。
        /// </returns>
        /// <exception cref="9999: 未知异常"/>
        public DataTable Get_B_Minor(B_minor model)
        {
            try  // 异常处理
            {
                return dal.Get_B_Minor(model);
            }
            catch (Exception ex)
            {
                B_Message_BLL.ShowUnkownError(ex);
                return null;
            }
        }


        /// <summary>
        /// 插入子代码行
        /// </summary>
        /// <param name="model">子代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1001: 主代码已存在"/>
        /// <exception cref="2001: 主代码不能为空"/>
        /// <exception cref="2003: 子代码不能为空"/>
        /// <exception cref="2004: 子代码名称不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Insert_B_Minor(B_minor model)
        {   // 判断主代码是否为空
            if (String.IsNullOrWhiteSpace(model.major_cd))
            {
                B_Message_BLL.ShowConfirm("2001");
                return false;
            }
            // 判断子代码是否为空
            if (String.IsNullOrWhiteSpace(model.minor_cd))
            {
                B_Message_BLL.ShowConfirm("2003"); 
            }
            // 判断子代码名称是否为空
            if (String.IsNullOrWhiteSpace(model.minor_nm))
            {
                B_Message_BLL.ShowConfirm("2004");
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
                return dal.Insert_B_Minor(model);
            }
            catch (Exception ex)
            {
                B_Message_BLL.ShowUnkownError(ex);
                return false;
            }
        }


        /// <summary>
        /// 删除子代码信息
        /// </summary>
        /// <param name="model">子代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1004: 未找到要删除的数据"/>
        /// <exception cref="2003: 子代码不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Delete_B_Minor(B_minor model)
        {
            // 判断主代码是否为空
            if (String.IsNullOrWhiteSpace(model.major_cd))
            {
                B_Message_BLL.ShowConfirm("2001");
                return false;
            }
            // 判断子代码是否为空
            if (String.IsNullOrWhiteSpace(model.minor_cd))
            {
                B_Message_BLL.ShowConfirm("2003");
            }
            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {
                try   // 存在该数据，则执行删除操作
                {
                    return dal.Delete_B_Minor(model);
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
        /// 修改子代码信息
        /// </summary>
        /// <param name="model">子代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1005: 未找到要更新的数据"/>
        /// <exception cref="2004: 子代码名称不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Update_B_Minor(B_minor model)
        {   
            // 判断当前子代码名称是否为空
            if (String.IsNullOrWhiteSpace(model.minor_nm))
            {
                B_Message_BLL.ShowConfirm("2004");
                return false;
            }
            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {   // 存在该数据，则执行修改操作
                try
                {
                    return dal.Update_B_Minor(model);
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
