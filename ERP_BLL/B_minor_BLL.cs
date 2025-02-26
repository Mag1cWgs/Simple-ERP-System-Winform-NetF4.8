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
    public class B_minor_BLL
    {
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
                return new B_minor_DAL().Get_B_Minor(model);
            }
            catch (Exception ex)
            {
                B_Message_BLL.ShowUnkownError(ex);
                return null;
            }
        }
    }
}
