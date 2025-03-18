using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_MODEL
{
    public class B_user
    {
        /// <summary>
        /// 人员编号
        /// </summary>
        public string user_cd { get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        public string user_nm { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string tel_no { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string dept_nm { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 操作人编号
        /// </summary>
        public string user_using_cd { get; set; }
    }
}
