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
    }
}
