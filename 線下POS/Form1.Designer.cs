namespace 線下POS
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeduct = new System.Windows.Forms.Button();
            this.btnCacel = new System.Windows.Forms.Button();
            this.tbMerTradeNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEncDecrypt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTransID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefund = new System.Windows.Forms.Button();
            this.tb_refundAmt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbRSAPriKey = new System.Windows.Forms.TextBox();
            this.deCryData = new System.Windows.Forms.TextBox();
            this.tbDecrypt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRSADecrypt = new System.Windows.Forms.Button();
            this.btnAESDecrypt = new System.Windows.Forms.Button();
            this.tbAESIV = new System.Windows.Forms.TextBox();
            this.tbAESkey = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbMul = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbPrice.Location = new System.Drawing.Point(146, 20);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(124, 25);
            this.tbPrice.TabIndex = 0;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbBarcode.Location = new System.Drawing.Point(146, 48);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(124, 25);
            this.tbBarcode.TabIndex = 1;
            // 
            // tbResponse
            // 
            this.tbResponse.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbResponse.Location = new System.Drawing.Point(586, 28);
            this.tbResponse.Multiline = true;
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResponse.Size = new System.Drawing.Size(376, 179);
            this.tbResponse.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(48, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barcode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(583, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Response";
            // 
            // btnDeduct
            // 
            this.btnDeduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeduct.Location = new System.Drawing.Point(276, 20);
            this.btnDeduct.Name = "btnDeduct";
            this.btnDeduct.Size = new System.Drawing.Size(111, 50);
            this.btnDeduct.TabIndex = 2;
            this.btnDeduct.Text = "扣款\r\nICPOF001";
            this.btnDeduct.UseVisualStyleBackColor = true;
            this.btnDeduct.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCacel
            // 
            this.btnCacel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCacel.Location = new System.Drawing.Point(276, 97);
            this.btnCacel.Name = "btnCacel";
            this.btnCacel.Size = new System.Drawing.Size(111, 64);
            this.btnCacel.TabIndex = 5;
            this.btnCacel.Text = "交易取消Cancel\r\nICPOF002\r\n(APP 交易失敗)";
            this.btnCacel.UseVisualStyleBackColor = true;
            this.btnCacel.Click += new System.EventHandler(this.btnCacel_Click);
            // 
            // tbMerTradeNo
            // 
            this.tbMerTradeNo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbMerTradeNo.Location = new System.Drawing.Point(146, 101);
            this.tbMerTradeNo.Name = "tbMerTradeNo";
            this.tbMerTradeNo.Size = new System.Drawing.Size(124, 25);
            this.tbMerTradeNo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(20, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "MerchantTradeNo:\r\n(Client)";
            // 
            // tbEncDecrypt
            // 
            this.tbEncDecrypt.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbEncDecrypt.Location = new System.Drawing.Point(586, 230);
            this.tbEncDecrypt.Multiline = true;
            this.tbEncDecrypt.Name = "tbEncDecrypt";
            this.tbEncDecrypt.Size = new System.Drawing.Size(376, 194);
            this.tbEncDecrypt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(583, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "EncData";
            // 
            // tbRequest
            // 
            this.tbRequest.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbRequest.Location = new System.Drawing.Point(33, 269);
            this.tbRequest.Multiline = true;
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRequest.Size = new System.Drawing.Size(350, 155);
            this.tbRequest.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(30, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Request";
            // 
            // tbTransID
            // 
            this.tbTransID.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbTransID.Location = new System.Drawing.Point(146, 131);
            this.tbTransID.Name = "tbTransID";
            this.tbTransID.Size = new System.Drawing.Size(124, 25);
            this.tbTransID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(20, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 34);
            this.label7.TabIndex = 4;
            this.label7.Text = "TransactionID:\r\n(ICPx20) -optional";
            // 
            // btnRefund
            // 
            this.btnRefund.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefund.Location = new System.Drawing.Point(276, 187);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(111, 62);
            this.btnRefund.TabIndex = 7;
            this.btnRefund.Text = "退貨Refund\r\nICPO004\r\n(APP 退款)";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // tb_refundAmt
            // 
            this.tb_refundAmt.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_refundAmt.Location = new System.Drawing.Point(146, 187);
            this.tb_refundAmt.Name = "tb_refundAmt";
            this.tb_refundAmt.Size = new System.Drawing.Size(124, 25);
            this.tb_refundAmt.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(29, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "RefundAmt:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 468);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnRefund);
            this.tabPage1.Controls.Add(this.tbPrice);
            this.tabPage1.Controls.Add(this.btnCacel);
            this.tabPage1.Controls.Add(this.tb_refundAmt);
            this.tabPage1.Controls.Add(this.btnDeduct);
            this.tabPage1.Controls.Add(this.tbBarcode);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbMerTradeNo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbTransID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbResponse);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbRequest);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbEncDecrypt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(409, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 156);
            this.label14.TabIndex = 10;
            this.label14.Text = "1.扣款\r\n輸入[Amount],\r\n        [Barcode]\r\n\r\n2.交易取消\r\n輸入[MerchantTradeNo],\r\n        [Tr" +
    "ansactionID](可選)\r\n\r\n3.退貨\r\n輸入[MerchantTradeNo],\r\n        [TransactionID],\r\n      " +
    "  [RefundAmt]";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbRSAPriKey);
            this.tabPage2.Controls.Add(this.deCryData);
            this.tabPage2.Controls.Add(this.tbDecrypt);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnRSADecrypt);
            this.tabPage2.Controls.Add(this.btnAESDecrypt);
            this.tabPage2.Controls.Add(this.tbAESIV);
            this.tabPage2.Controls.Add(this.tbAESkey);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1001, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbRSAPriKey
            // 
            this.tbRSAPriKey.Location = new System.Drawing.Point(446, 42);
            this.tbRSAPriKey.Multiline = true;
            this.tbRSAPriKey.Name = "tbRSAPriKey";
            this.tbRSAPriKey.Size = new System.Drawing.Size(181, 52);
            this.tbRSAPriKey.TabIndex = 3;
            // 
            // deCryData
            // 
            this.deCryData.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deCryData.Location = new System.Drawing.Point(475, 127);
            this.deCryData.Multiline = true;
            this.deCryData.Name = "deCryData";
            this.deCryData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.deCryData.Size = new System.Drawing.Size(396, 307);
            this.deCryData.TabIndex = 2;
            // 
            // tbDecrypt
            // 
            this.tbDecrypt.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbDecrypt.Location = new System.Drawing.Point(83, 127);
            this.tbDecrypt.Multiline = true;
            this.tbDecrypt.Name = "tbDecrypt";
            this.tbDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDecrypt.Size = new System.Drawing.Size(386, 307);
            this.tbDecrypt.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(472, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "DecryptData:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(82, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "EncData:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(370, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 34);
            this.label13.TabIndex = 1;
            this.label13.Text = "RSA\r\nPrivateKey:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(55, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "IV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(20, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "AES Key:";
            // 
            // btnRSADecrypt
            // 
            this.btnRSADecrypt.Location = new System.Drawing.Point(633, 42);
            this.btnRSADecrypt.Name = "btnRSADecrypt";
            this.btnRSADecrypt.Size = new System.Drawing.Size(82, 52);
            this.btnRSADecrypt.TabIndex = 0;
            this.btnRSADecrypt.Text = "RSA Decrypt";
            this.btnRSADecrypt.UseVisualStyleBackColor = true;
            this.btnRSADecrypt.Click += new System.EventHandler(this.btnRSADecrypt_Click);
            // 
            // btnAESDecrypt
            // 
            this.btnAESDecrypt.Location = new System.Drawing.Point(278, 42);
            this.btnAESDecrypt.Name = "btnAESDecrypt";
            this.btnAESDecrypt.Size = new System.Drawing.Size(82, 52);
            this.btnAESDecrypt.TabIndex = 0;
            this.btnAESDecrypt.Text = "AES Decrypt";
            this.btnAESDecrypt.UseVisualStyleBackColor = true;
            this.btnAESDecrypt.Click += new System.EventHandler(this.btnAESDecrypt_Click);
            // 
            // tbAESIV
            // 
            this.tbAESIV.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::線下POS.Properties.Settings.Default, "DefaultAESIV", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbAESIV.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAESIV.Location = new System.Drawing.Point(85, 72);
            this.tbAESIV.Name = "tbAESIV";
            this.tbAESIV.Size = new System.Drawing.Size(187, 25);
            this.tbAESIV.TabIndex = 2;
            this.tbAESIV.Text = global::線下POS.Properties.Settings.Default.DefaultAESIV;
            // 
            // tbAESkey
            // 
            this.tbAESkey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::線下POS.Properties.Settings.Default, "DefaultAESkey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbAESkey.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAESkey.Location = new System.Drawing.Point(85, 42);
            this.tbAESkey.Name = "tbAESkey";
            this.tbAESkey.Size = new System.Drawing.Size(187, 25);
            this.tbAESkey.TabIndex = 2;
            this.tbAESkey.Text = global::線下POS.Properties.Settings.Default.DefaultAESkey;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.tbResult);
            this.tabPage3.Controls.Add(this.tbMul);
            this.tabPage3.Controls.Add(this.tbTotal);
            this.tabPage3.Controls.Add(this.tb_num);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.btn_sum);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1001, 442);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(498, 322);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 23);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "最低消費不算";
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbResult.Location = new System.Drawing.Point(585, 390);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(75, 23);
            this.tbResult.TabIndex = 2;
            this.tbResult.Text = "Result";
            // 
            // tbMul
            // 
            this.tbMul.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbMul.Location = new System.Drawing.Point(585, 322);
            this.tbMul.Name = "tbMul";
            this.tbMul.Size = new System.Drawing.Size(75, 23);
            this.tbMul.TabIndex = 2;
            this.tbMul.Text = "回饋率0.03";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbTotal.Location = new System.Drawing.Point(498, 390);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(81, 23);
            this.tbTotal.TabIndex = 2;
            this.tbTotal.Text = "Total";
            // 
            // tb_num
            // 
            this.tb_num.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_num.Location = new System.Drawing.Point(20, 20);
            this.tb_num.Multiline = true;
            this.tb_num.Name = "tb_num";
            this.tb_num.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_num.Size = new System.Drawing.Size(363, 392);
            this.tb_num.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(417, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "PASTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(585, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "計算乘積";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Mul);
            // 
            // btn_sum
            // 
            this.btn_sum.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sum.Location = new System.Drawing.Point(498, 350);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(81, 29);
            this.btn_sum.TabIndex = 0;
            this.btn_sum.Text = "計算加總";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1001, 442);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "轉十進位";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "轉二進位";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(539, 324);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(29, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 386);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.textBox5);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.textBox6);
            this.tabPage5.Controls.Add(this.textBox4);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1001, 442);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "Dollar";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(81, 22);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "15";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(38, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 68);
            this.button6.TabIndex = 2;
            this.button6.Text = "公車支付\r\n1682022000007133\r\n(大都會)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_ClickAsync);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox6.Location = new System.Drawing.Point(622, 64);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(322, 372);
            this.textBox6.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(229, 62);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(387, 372);
            this.textBox4.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(38, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 64);
            this.button5.TabIndex = 0;
            this.button5.Text = "UCS-2LE TO UTF-8\r\n(SQL script轉碼)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "Request";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(620, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "Response";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 468);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeduct;
        private System.Windows.Forms.Button btnCacel;
        private System.Windows.Forms.TextBox tbMerTradeNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEncDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTransID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.TextBox tb_refundAmt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbDecrypt;
        private System.Windows.Forms.TextBox tbAESIV;
        private System.Windows.Forms.TextBox tbAESkey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAESDecrypt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRSADecrypt;
        private System.Windows.Forms.TextBox tbRSAPriKey;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbMul;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox deCryData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
    }
}

