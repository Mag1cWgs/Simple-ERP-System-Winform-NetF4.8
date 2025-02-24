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
    public class B_major_BLL
    {
        /// <summary>
        /// 接受主代码实体，查询主代码表
        /// </summary>
        /// <param name="model">主代码实体类</param>
        /// <returns>匹配 major_cd 或 major_nm 的结果</returns>
        public DataTable Get_B_Major(B_major model)
        {
            return new B_major_DAL().Get_B_Major(model);
        }

        /// <summary>
        /// 删除主代码信息
        /// </summary>
        /// <param name="model">主代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Delete_B_Major(B_major model)
        {
            B_major_DAL dal = new B_major_DAL();
            // 保存前判断是否存在要操作的数据
            if (dal.Exist(model))
            {
                try
                {   // 存在该数据，则执行删除操作
                    return new B_major_DAL().Delete_B_Major(model);
                }
                catch (Exception ex)
                {
                    KryptonMessageBox.Show("删除失败！" + ex.Message);
                    return false;
                }
            }
            // 不存在该数据
            KryptonMessageBox.Show("该数据不存在或已被删除！删除失败！");
            return false;
        }

        /// <summary>
        /// 插入主代码行
        /// </summary>
        /// <param name="model">主代码实体</param>
        /// <returns>
        ///     <c>True</c>: 成功;
        ///     <c>False</c>: 失败。
        /// </returns>
        public bool Insert_B_Major(B_major model)
        {   // 判断主代码是否为空
            if (String.IsNullOrWhiteSpace(model.major_cd))
            {
                KryptonMessageBox.Show("主代码不能为空！");
                return false;
            }
            // 判断主代码名称是否为空
            if (String.IsNullOrWhiteSpace(model.major_nm))
            {
                KryptonMessageBox.Show("主代码名称不能为空！");
                return false;
            }
            B_major_DAL dal = new B_major_DAL();
            // 保存前判断是否存在相同的主代码
            if (dal.Exist(model))
            {   
                KryptonMessageBox.Show("已经存在相同的主代码，无法添加！");
                return false;
            }
            // 保存数据，未知异常处理
            try
            {
                return new B_major_DAL().Insert_B_Major(model);
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("添加失败！" + ex.Message);
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
        public bool Update_B_Major(B_major model)
        {   // 判断修改后主代码是否为空
            if (String.IsNullOrWhiteSpace(model.major_nm))
            {
                KryptonMessageBox.Show("主代码名称不能为空！");
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
                    KryptonMessageBox.Show("删除失败！" + ex.Message);
                    return false;
                }
            }
            // 不存在该数据
            KryptonMessageBox.Show("该数据不存在或已被删除！修改失败！");
            return false;
        }
    }
}
