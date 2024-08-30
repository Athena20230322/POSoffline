using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPLib.POCO
{
    public class ICPOF002Req
    {
        public string PlatformID { get; set; }
        public string MerchantID { get; set; }
        public string WalletID { get; set; }
        /// <summary>
        /// 愛金卡產生的原始交易編號(交易成功產生) 連線逾時可為空
        /// </summary>
        public string TransactionID { get; set; }
        public string StoreID { get; set; }
        public string StoreName { get; set; }

        /// <summary>
        /// POS編號
        /// </summary>
        public string MerchantTID { get; set; }

        /// <summary>
        /// 商家交易編號 (特店唯一值)
        /// </summary>
        public string MerchantTradeNo { get; set; }

        /// <summary>
        /// 交易取消日期
        /// </summary>
        public string MerchantTradeDate { get; set; }

    }
}
