using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_MODEL
{
    public class B_item
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        public string item_cd { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string item_nm { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        public string item_spec { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        public decimal? item_price { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        public string item_unit { get; set; }

        /// <summary>
        /// 商品分类
        /// </summary>
        public string item_group { get; set; }

        /// <summary>
        /// 商品库位
        /// </summary>
        public string sl_cd { get; set; }

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
