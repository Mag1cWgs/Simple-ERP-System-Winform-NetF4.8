using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_MODEL
{
    public class B_tax
    {
        /// <summary>
        /// 税率编号
        /// </summary>
        public string tax_cd { get; set; }

        /// <summary>
        /// 税率名称
        /// </summary>
        public string tax_nm { get; set; }

        /// <summary>
        /// 税率值，设置为可null，保证删除时不会报错
        /// </summary>
        public decimal? tax_rate { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 操作者编号
        /// </summary>
        public string user_cd { get; set; }

    }
}
