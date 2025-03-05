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
        /// 接受往来单位实体，查询主代码表
        ///     <para>
        ///     如果查询为空，则返回<c>null</c>，由UI层进行处理。
        ///     </para>
        /// </summary>
        /// <param name="model">往来单位实体类</param>
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
    }
}
