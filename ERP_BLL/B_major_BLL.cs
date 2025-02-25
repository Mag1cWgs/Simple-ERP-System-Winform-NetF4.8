using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_DAL;
using ERP_MODEL;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace ERP_BLL
{
    /// <summary>
    /// 主代码业务逻辑层
    /// </summary>
    public class B_major_BLL
    {
        /// <summary>
        /// 接受主代码实体，查询主代码表
        ///     <para>
        ///     如果查询为空，则返回<c>null</c>，由UI层进行处理。
        ///     </para>
        /// </summary>
        /// <param name="model">主代码实体类</param>
        /// <returns>
        ///     匹配 <c>major_cd</c> 或 <c>major_nm</c> 的结果，
        ///     如果查询为空，则返回<c>null</c>。
        /// </returns>
        /// <exception cref="9999: 未知异常"/>
        public DataTable Get_B_Major(B_major model)
        {   
            try  // 异常处理
            {
             // 正常返回查询结果，在UI层进行处理
             //DataTable dt = new B_major_DAL().Get_B_Major(model);
             //if(dt.Rows.Count == 0)
             //    B_Message_BLL.ShowConfirm(1002);
             //KryptonMessageBox.Show("查询成功！共有" + dt.Rows.Count + "条数据。");
                return new B_major_DAL().Get_B_Major(model);
            }
            catch (Exception ex)
            {
                B_Message_BLL.ShowUnkownError(ex);
                return null;
            }
        }

        /// <summary>
        /// 删除主代码信息
        /// </summary>
        /// <param name="model">主代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1004: 未找到要删除的数据"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Delete_B_Major(B_major model)
        {
            B_major_DAL dal = new B_major_DAL();
            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {
                try   // 存在该数据，则执行删除操作
                {
                    return new B_major_DAL().Delete_B_Major(model);
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
        /// 插入主代码行
        /// </summary>
        /// <param name="model">主代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1001: 主代码已存在"/>
        /// <exception cref="2001: 主代码不能为空"/>
        /// <exception cref="2002: 主代码名称不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Insert_B_Major(B_major model)
        {   // 判断主代码是否为空
            if (String.IsNullOrWhiteSpace(model.major_cd))
            {
                B_Message_BLL.ShowConfirm("2001");
                return false;
            }
            // 判断主代码名称是否为空
            if (String.IsNullOrWhiteSpace(model.major_nm))
            {
                B_Message_BLL.ShowConfirm("2002");
                return false;
            }
            B_major_DAL dal = new B_major_DAL();
            // 保存前判断是否存在相同的主代码
            if (dal.Exist(model))
            {
                B_Message_BLL.ShowConfirm("1001");
                return false;
            }
            // 保存数据，未知异常处理
            try
            {
                return new B_major_DAL().Insert_B_Major(model);
            }
            catch (Exception ex)
            {
                B_Message_BLL.ShowUnkownError(ex);
                return false;
            }
        }

        /// <summary>
        /// 修改主代码信息
        /// </summary>
        /// <param name="model">主代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        /// <exception cref="1005: 未找到要更新的数据"/>
        /// <exception cref="2002: 主代码名称不能为空"/>
        /// <exception cref="9999: 未知异常"/>
        public bool Update_B_Major(B_major model)
        {   // 判断修改后主代码名称是否为空
            if (String.IsNullOrWhiteSpace(model.major_nm))
            {
                B_Message_BLL.ShowConfirm("2002");
                return false;
            }
            B_major_DAL dal = new B_major_DAL();
            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {   // 存在该数据，则执行修改操作
                try
                {
                    return new B_major_DAL().Update_B_Major(model);
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
