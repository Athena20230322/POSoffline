using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using ICPLib.POCO;
using Newtonsoft.Json.Linq;
using System.Net;

namespace 線下POS
{
    public partial class Form1 : Form
    {
        public string EncKeyID { get; set; }
        public string AES_IV { get; set; }
        public string AES_Key { get; set; }
        public string ServerPubCer { get; set; }
        public string ClientPriCer { get; set; }

        public Form1()
        {
            InitializeComponent();
            AES_IV = ReadConfig("AES_IV");
            AES_Key = ReadConfig("AES_Key");
            EncKeyID = ReadConfig("EncKeyID");
            ServerPubCer = ReadConfig("ServerPubCer");//FOR ENCRYPT
            ClientPriCer = ReadConfig("ClientPriCer");//FOR SIGN

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string Url = "https://icp-payment-stage.icashpay.com.tw/api/Payment/Pos/DeductICPOF";

            RsaHelper rsaHelper = new RsaHelper();
            AesHelper aesHelper = new AesHelper();

            #region 組Json電文
            string sjsData = File.ReadAllText("Json/ICPOF001.txt");
            WC006Req wc006Req = JsonConvert.DeserializeObject<WC006Req>(sjsData);

            int amt = int.Parse(tbPrice.Text) * 100;
            wc006Req.PlatformID = ConfigurationManager.AppSettings["PlatformID"];
            wc006Req.MerchantID = ConfigurationManager.AppSettings["MerchantID"];
            wc006Req.Amount = amt;
            wc006Req.ItemAmt = amt+1;
            wc006Req.Barcode = tbBarcode.Text;

            wc006Req.MerchantTradeNo = DateTime.Now.ToString("yyyyMMddHHmmss")+"01";
            wc006Req.ItemList = new List<WC006SubItemList>();

            string sWC006JsaonData = JsonConvert.SerializeObject(wc006Req);
            tbRequest.Text = JsonConvert.SerializeObject(wc006Req, Formatting.Indented);
            string sEncData = aesHelper.AesEncrypt(sWC006JsaonData, AES_Key, AES_IV);

            rsaHelper.ImportPemPrivateKey(ClientPriCer);
            string signData = rsaHelper.SignDataWithSha256(sEncData);
            #endregion 


            #region PostReqest
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Url);
            
            httpClient.DefaultRequestHeaders.Add("X-iCP-EncKeyID", EncKeyID);
            httpClient.DefaultRequestHeaders.Add("X-iCP-Signature", signData);

            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(new StringContent(sEncData), "EncData");
            HttpResponseMessage response = httpClient.PostAsync(Url, content).Result;
            string responseFromServer = response.Content.ReadAsStringAsync().Result;
            #endregion


            #region Response
            PosResponse httpres = null;
            if (responseFromServer != "")
                httpres = JsonConvert.DeserializeObject<PosResponse>(responseFromServer);

            string decrypt = decrypt = aesHelper.AesDecrypt(httpres.EncData, AES_Key, AES_IV);


            #endregion

            tbResponse.Text = BeautifyJson(responseFromServer);
            tbEncDecrypt.Text = BeautifyJson(decrypt);

        }

        private void btnCacel_Click(object sender, EventArgs e)
        {
            string url = "https://icp-payment-stage.icashpay.com.tw/api/Payment/Pos/DeductCancelICPOF";

            RsaHelper rsaHelper = new RsaHelper();
            AesHelper aesHelper = new AesHelper();

            #region 組Json電文
            string sjsData = File.ReadAllText("Json/ICPOF002.txt");
            ICPOF002Req iCPOF002Req = JsonConvert.DeserializeObject<ICPOF002Req>(sjsData);
            iCPOF002Req.PlatformID = ConfigurationManager.AppSettings["PlatformID"];
            iCPOF002Req.MerchantID = ConfigurationManager.AppSettings["MerchantID"];
            iCPOF002Req.MerchantTradeNo = tbMerTradeNo.Text;
            iCPOF002Req.TransactionID = tbTransID.Text;
            iCPOF002Req.MerchantTradeDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");


            string iCPOF002ReqJson = JsonConvert.SerializeObject(iCPOF002Req);
            tbRequest.Text = JsonConvert.SerializeObject(iCPOF002Req, Formatting.Indented);
            string sEncData = aesHelper.AesEncrypt(iCPOF002ReqJson, AES_Key, AES_IV);

            rsaHelper.ImportPemPrivateKey(ClientPriCer);
            string signData = rsaHelper.SignDataWithSha256(sEncData);
            #endregion

            #region PostReqest
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(url);

            httpClient.DefaultRequestHeaders.Add("X-iCP-EncKeyID",EncKeyID);
            httpClient.DefaultRequestHeaders.Add("X-iCP-Signature", signData);

            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(new StringContent(sEncData), "EncData");

            HttpResponseMessage response = httpClient.PostAsync(url, content).Result;
            string responseFromServer = response.Content.ReadAsStringAsync().Result;
            #endregion


            #region Response
            PosResponse posRes = null;
            if (responseFromServer != "")
            {
                posRes = JsonConvert.DeserializeObject<PosResponse>(responseFromServer);
            }
            string decrypt = aesHelper.AesDecrypt(posRes.EncData, AES_Key, AES_IV);
            #endregion

            tbResponse.Text =BeautifyJson(responseFromServer);
            tbEncDecrypt.Text = BeautifyJson(decrypt);

        }

        private string ReadConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }


        public string BeautifyJson(string jsonString)
        {
            if (jsonString is null) return "NULL";
     
            JToken parsedJson = JToken.Parse(jsonString);
            var beautified = parsedJson.ToString(Formatting.Indented);
            return beautified;
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            string url = "https://icp-payment-stage.icashpay.com.tw/api/Payment/Cashier/RefundICPO";

            RsaHelper rsaHelper = new RsaHelper();
            AesHelper aesHelper = new AesHelper();

            #region 組Json電文
            string sjsData = File.ReadAllText("Json/ICPO004.txt");
            ICPO004Req iCPO004Req = JsonConvert.DeserializeObject<ICPO004Req>(sjsData);
            iCPO004Req.PlatformID = ConfigurationManager.AppSettings["PlatformID"];
            iCPO004Req.MerchantID = ConfigurationManager.AppSettings["MerchantID"];
            iCPO004Req.MerchantTradeNo = DateTime.Now.ToString("yyyyMMddHHmmss") + "02";
            iCPO004Req.OMerchantTradeNo = tbMerTradeNo.Text;
            iCPO004Req.TransactionID = tbTransID.Text;
            iCPO004Req.Amount= tb_refundAmt.Text;
            iCPO004Req.MerchantTradeDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            string iCPO004ReqJson = JsonConvert.SerializeObject(iCPO004Req);
            tbRequest.Text = JsonConvert.SerializeObject(iCPO004Req, Formatting.Indented);
            string sEncData = aesHelper.AesEncrypt(iCPO004ReqJson, AES_Key, AES_IV);

            rsaHelper.ImportPemPrivateKey(ClientPriCer);
            string signData = rsaHelper.SignDataWithSha256(sEncData);
            #endregion

            #region PostReqest
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(url);

            httpClient.DefaultRequestHeaders.Add("X-iCP-EncKeyID", EncKeyID);
            httpClient.DefaultRequestHeaders.Add("X-iCP-Signature", signData);

            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(new StringContent(sEncData), "EncData");

            HttpResponseMessage response = httpClient.PostAsync(url, content).Result;
            string responseFromServer = response.Content.ReadAsStringAsync().Result;
            #endregion


            #region Response
            PosResponse posRes = null;
            if (responseFromServer != "")
            {
                posRes = JsonConvert.DeserializeObject<PosResponse>(responseFromServer);
            }
            string decrypt = aesHelper.AesDecrypt(posRes.EncData, AES_Key, AES_IV);
            #endregion

            tbResponse.Text = BeautifyJson(responseFromServer);
            tbEncDecrypt.Text = BeautifyJson(decrypt);


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void btnAESDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                AesHelper aesHelper = new AesHelper();
                string decrypt = aesHelper.AesDecrypt(tbDecrypt.Text, tbAESkey.Text, tbAESIV.Text);
                deCryData.Text = BeautifyJson(decrypt);
            }
            catch (Exception)
            {
                deCryData.Text = "解密失敗";
            }

        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            var text = tb_num.Text;
            string[] stringSeparators = new string[] { "\r\n" };
            string[] lines = text.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            double total = 0;
            if (textBox3.Text=="最低消費")
            {
                foreach (var item in lines)
                {
                    total += double.Parse(item);
                };
            }
            else
            {
                var min=int.Parse(textBox3.Text);
                foreach (var item in lines)
                {
                    var value = double.Parse(item);
                    if (value>=min)
                    {
                        total += value;
                    }
                   
                };
            }

       

           tbTotal.Text= total.ToString();


        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            tb_num.Text=Clipboard.GetText();
        }

        private void btnRSADecrypt_Click(object sender, EventArgs e)
        {
            RsaHelper rsaHelper = new RsaHelper();
            rsaHelper.ImportPemPrivateKey(tbRSAPriKey.Text);
            string decrypt = rsaHelper.Decrypt(tbDecrypt.Text);
            tbDecrypt.Text = BeautifyJson(decrypt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var val = int.Parse(textBox2.Text);
            string binary = System.Convert.ToString(val, 2).PadLeft(16, '0');
            textBox1.Text += Environment.NewLine +binary+"|| "+ val;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var val = int.Parse(textBox2.Text);
            int t = Convert.ToInt32(val.ToString(),2);
            textBox1.Text += Environment.NewLine + val.ToString().PadLeft(16, '0') + "|| " + t;
        }

        private void btn_Mul(object sender, EventArgs e)
        {
           var tbT= double.Parse(tbTotal.Text);
           var tbM= double.Parse(tbMul.Text);
            tbResult.Text= (tbT* tbM ).ToString() ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            //string filename = "";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                foreach (var thisFileName in openFileDialog1.FileNames)
                {
                  string  filename = thisFileName; //取得檔名
                                                         // Encoding enc = Encoding.GetEncoding("big5"); //設定檔案的編碼
                                                         // tbResult.Text = System.IO.File.ReadAllText(theFile, enc); //以指定的編碼方式讀取檔案

                    var filestream = File.OpenRead(filename);

                    var BOM = new byte[3];

                    filestream.Read(BOM, 0, BOM.Length);

                    if (BOM[0] != (byte)255 && BOM[1] != (byte)254) //0xff 0xfe 0x48
                    {
                        //Console.WriteLine("This isn't UCS-2LE");
                        continue;
                        // return;
                    }
                    else if (BOM[0] == 0xEF && BOM[1] == 0xBB && BOM[2] == 0xBF)
                    {
                       // Console.WriteLine("This is UTF-8");
                        continue;
                        //return;
                    }

                    filestream.Close();

                    byte[] content = File.ReadAllBytes(filename);

                    byte[] utf8Bytes = System.Text.Encoding.Convert(System.Text.Encoding.Unicode, System.Text.Encoding.UTF8, content);

                    byte[] newArray = new byte[utf8Bytes.Length - 3];

                    Array.Copy(utf8Bytes, 3, newArray, 0, newArray.Length);

                    File.WriteAllBytes(filename, newArray);
                }
            }

            MessageBox.Show("complete");


        }

        private async void button6_ClickAsync(object sender, EventArgs e)
        {
            //string url = "https://103.234.83.145/TraTest/api/Payment/Traffic/DoPayment";
            string url = "https://icp-payment-stage.icashpay.com.tw/api/Payment/Traffic/DoPayment";

            
            var base64Str=textBox4.Text;

            // base64Str = @"UQZUV1RWMDFSOmEBMWIMMTIzNDU2Nzg5QUJaYwEyZA4yMDIwMTIxNDE4NDkxN2UUQ0QzMDFDRjZGRTZEMEE3MDA5Q0RUQ0EBM0IQMTY4MTkxMTAwMDAwMDA2NUMKMTI5MTMxMDMxN0QBMUYUMDAwMDAwMDAwMDAwMDAwMDAwMzVIByswMDEyMzVVaXEFMDEuMDCAEzAwMDAwMDAwMDAwMDAwMDAwMDCFOTAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMIoQMDAwMDAwMDAwMDAwMDAwMA ==";


            var hexStr = Base64ToHex(base64Str);//216-257
            var qr46Hex = hexStr.Substring(214, 42);
            var qrcodeTID=Hex2ASCII(qr46Hex).Substring(1);
            textBox4.Text = qrcodeTID;

            var jObj=JsonConvert.DeserializeObject(TrafficDoPayment.TrafficJsonSample);

            dynamic dyna = JObject.Parse(TrafficDoPayment.TrafficJsonSample);
            dyna.record.orgQrcode = qrcodeTID;
            dyna.record.terminalPosParam.recordId = 03330520190827 + DateTime.Now.ToString("HHmmss");
            dyna.record.terminalPosParam.transactionAmount = textBox5.Text;
            var reqJsonStr = dyna.ToString(Formatting.None);
            textBox4.Text = BeautifyJson(reqJsonStr);

            string Result = "";

            HttpClient client = new HttpClient();
            //GetSecurityProtocol();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
            requestMessage.Content = new StringContent(reqJsonStr, Encoding.UTF8, "application/json");

            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            HttpResponseMessage response = client.SendAsync(requestMessage).GetAwaiter().GetResult();

            if (response.StatusCode.ToString() == "OK")
            {
                string r = response.Content.ReadAsStringAsync().Result.ToString();
                // Message MS = JsonConvert.DeserializeObject<Message>(r);
                // Result = JsonConvert.SerializeObject(r);
                textBox6.Text = BeautifyJson(r);

            }
            else
            {
                Result = "伺服器連線異常";
            }

        }

        private static SecurityProtocolType GetSecurityProtocol()
        {
            var result = 0;
            foreach (var value in Enum.GetValues(typeof(SecurityProtocolType)))
                result += (int)value;
            return (SecurityProtocolType)result;
        }

        public string Base64ToHex(string base64Str)
        {
            try
            {
                var bytes = Convert.FromBase64String(base64Str);
                var hex = BitConverter.ToString(bytes);
                return hex.Replace("-", "").ToLower();
            }
            catch (Exception)
            {
                return "-1";
            }
        }

        public string Hex2ASCII(string hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }
    }
}

    

