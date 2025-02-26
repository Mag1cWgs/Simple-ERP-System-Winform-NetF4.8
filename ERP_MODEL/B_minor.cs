using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_MODEL
{
    public class B_minor
    {
        /// <summary>
        /// 主代码编号
        /// </summary>
        public string major_cd { get; set; }

        /// <summary>
        /// 子代码编号
        /// </summary>
        public string minor_cd { get; set; }

        /// <summary>
        /// 子代码名称
        /// </summary>
        public string minor_nm { get; set; }

        /// <summary>
        /// 操作者编号
        /// </summary>
        public string user_cd { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string remark { get; set; }
    }
}
