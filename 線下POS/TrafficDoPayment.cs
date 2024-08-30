using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICPLib.POCO
{

  


    public class TrafficDoPayment
    {//10500855星巴克
     //10510426	1682022000007133	1	大都會客運	
     //10510428	1682022000007154	1	豐原客運	
     //10510429	1682022000007163	1	高雄客運	   
     static public string TrafficJsonSample = @"{
   ""record"":{
      ""version"":null,
      ""orgQrcode"":""00000000000000000397"",
      ""terminalPosParam"":{
         ""recordId"":""03330520190827000922"",
         ""recordSn"":null,
         ""merchantId"":""10510426"",
         ""consumptionType"":""0"",
         ""transactionType"":""A"",
         ""terminalId"":""03330520"",
         ""terminalMfId"":""233123"",
         ""terminalSwVersion"":null,
         ""sdkVersion"":null,
         ""merchantType"":""1"",
         ""currency"":""TWD"",
         ""originalAmount"":1400.0,
         ""discountAmount"":0.0,
         ""transactionAmount"":1400.0,
         ""discountInfo"":[
            {
               ""typeId"":""1"",
               ""amount"":2.0
            },
            {
               ""typeId"":""2"",
               ""amount"":3.0
            }
         ],
         ""transactionDatetime"":""20201211170655"",
         ""transportNo"":""A1"",
         ""plateNo"":""AA888"",
         ""driverNo"":""000123"",
         ""lineInfo"":""9650"",
         ""stationNo"":""A1"",
         ""stationName"":""忠孝國小"",
         ""stationName2"":null,
         ""lbsInfoX"":null,
         ""lbsInfoY"":null,
         ""entryStationNo"":""A1"",
         ""entryDeductZoneNo"":null,
         ""entryStationName"":""忠孝國小"",
         ""entryStationName2"":null,
         ""entryDatetime"":""20201211170655"",
         ""exitStationNo"":null,
         ""exitDeductZoneNo"":null,
         ""exitStationName"":null,
         ""exitStationName2"":null,
         ""exitDatetime"":""20201211170655"",
         ""txnPersonalProfile"":null,
         ""penalty"":null,
         ""advanceAmt"":0.0,
         ""personalUsePoints"":null,
         ""personalCounter"":null,
         ""zoneNo"":null,
         ""entryZone"":null,
         ""shiftStart"":null,
         ""shiftNo"":null,
         ""busxferPreTimestamp"":null,
         ""busxferPreSpId"":null,
         ""roundTripFlag"":null,
         ""extendParameters"":{
            ""issueId"":1,
            ""parameters"":[
               {
                  ""name"":""LineType"",
                  ""value"":""1""
               },
               {
                  ""name"":""ShiftStart"",
                  ""value"":""202007010717""
               },
               {
                  ""name"":""AreaCode"",
                  ""value"":""01""
               },
               {
                  ""name"":""Section"",
                  ""value"":""2""
               },
               {
                  ""name"":""SvceLocId"",
                  ""value"":""002""
               }
            ]
         }
      },
      ""qr80"":""0000000000000007777"",
      ""qr85"":""000000000000000000000000000000000000000000000000000666666"",
      ""qr8A"":""0000000000006666"",
      ""qr67"":""20201211170655""
   },
   ""sign"":""696ED6D5754FFAFCE439"",
   ""PlatformID"":null,
   ""MerchantID"":null,
   ""DeviceInfo"":null,
   ""DeviceID"":null,
   ""IsSimulator"":null,
   ""OS"":null,
   ""OSVersion"":null,
   ""Timestamp"":null,
   ""Vers"":null,
   ""AppName"":null,
   ""RealIP"":0,
   ""ProxyIP"":0
}";

       // public string PlatformID { get; set; }
       //public string MerchantID {get;set;}
       //public string WalletID { get; set; }
       //public string Barcode {get;set;}
       //public int Amount {get;set;}
       //public string StoreID { get; set; }
       //public string StoreName { get; set; }
       //public string PosRefNo { get; set; }
       //public string MerchantTID { get; set; }
       //public string MerchantTradeNo {get;set;}
       //public string MerchantTradeDate {get;set;}
       //public string CarrierType {get;set;}
       //public int ItemAmt {get;set;}
       //public int UtilityAmt {get;set;}
       //public int CommAmt {get;set;}
       //public int ExceptAmt1 {get;set;}
       //public int ExceptAmt2 {get;set;}
       //public int RedeemFlag {get;set;}
       //public int BonusAmt {get;set;}
       //public int DebitPoint {get;set;}
       //public int NonRedeemAmt {get;set;}
       //public int NonPointAmt {get;set;}
       //public List<WC006SubItemList> ItemList { get; set; }
       ////public string Invo_no { get; set; }
    }
}
