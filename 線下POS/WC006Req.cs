using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPLib.POCO
{
    public class WC006Req
    {
        public string PlatformID { get; set; }
       public string MerchantID {get;set;}
       public string WalletID { get; set; }
       public string Barcode {get;set;}
       public int Amount {get;set;}
       public string StoreID { get; set; }
       public string StoreName { get; set; }
       public string PosRefNo { get; set; }
       public string MerchantTID { get; set; }
       public string MerchantTradeNo {get;set;}
       public string MerchantTradeDate {get;set;}
       public string CarrierType {get;set;}
       public int ItemAmt {get;set;}
       public int UtilityAmt {get;set;}
       public int CommAmt {get;set;}
       public int ExceptAmt1 {get;set;}
       public int ExceptAmt2 {get;set;}
       public int RedeemFlag {get;set;}
       public int BonusAmt {get;set;}
       public int DebitPoint {get;set;}
       public int NonRedeemAmt {get;set;}
       public int NonPointAmt {get;set;}
       public List<WC006SubItemList> ItemList { get; set; }
       //public string Invo_no { get; set; }
    }
}
