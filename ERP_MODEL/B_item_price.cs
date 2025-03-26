using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_MODEL
{
    public class B_item_price
    {
        /// <summary>
        /// 往来单位编号
        /// </summary>
        public string bp_cd { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        public string item_cd { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        public decimal? item_price { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        public string user_cd { get; set; }
    }
}
