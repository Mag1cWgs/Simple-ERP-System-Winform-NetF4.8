using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_MODEL
{
    public class B_partner
    {
        /// <summary>
        /// 单位编号，可自动生成
        /// </summary>
        public string bp_cd{ get; set; }

        /// <summary>
        /// 单位全称
        /// </summary>
        public string bp_full_nm { get; set; }

        /// <summary>
        /// 单位简称
        /// </summary>
        public string bp_nm { get; set; }

        /// <summary>
        /// 单位地址
        /// </summary>
        public string bp_addr { get; set; }

        /// <summary>
        /// 单位联系人
        /// </summary>
        public string bp_repre { get; set; }

        /// <summary>
        /// 单位联系电话
        /// </summary>
        public string bp_tel { get; set; }

        /// <summary>
        /// 单位传真
        /// </summary>
        public string bp_email { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        public string bp_tax { get; set; }

        /// <summary>
        /// 标记，<c>null</c> 为非法值
        /// </summary>
        public string flag 
        {
            get
            {
                if (so_flag == true && po_flag == false)
                    return "s";
                else if (so_flag == false && po_flag == true)
                    return "p";
                else if (so_flag == true && po_flag == true)
                    return "Y";
                else
                    return null;
            }
            set { flag = value; }
        }

        /// <summary>
        /// 上游销售方标记
        /// </summary>
        public bool so_flag { get; set; }

        /// <summary>
        /// 下游采购方标记
        /// </summary>
        public bool po_flag { get; set; }

        /// <summary>
        /// 银行类型编号
        /// </summary>
        public string bank_cd { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        public string bank_acct_no { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        public string pay_type { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 操作者ID
        /// </summary>
        public string user_cd { get; set; }
    }
}
