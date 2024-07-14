namespace StokTakip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtMiktarı = new System.Windows.Forms.TextBox();
            this.TxtToplamFiyatı = new System.Windows.Forms.TextBox();
            this.TxtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.TxtÜrünAdı = new System.Windows.Forms.TextBox();
            this.TxtBarkodNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblGenelToplam = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnMüsteriEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSatışlarıListeleme = new System.Windows.Forms.Button();
            this.BtnMusteriListeleme = new System.Windows.Forms.Button();
            this.BtnÜrünListeleme = new System.Windows.Forms.Button();
            this.BtnÜrünEkleme = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSatışYap = new System.Windows.Forms.Button();
            this.Btnsatışİptal = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MskTelefon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.MskTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(2, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            this.groupBox1.UseWaitCursor = true;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(90, 122);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(121, 31);
            this.MskTelefon.TabIndex = 4;
            this.MskTelefon.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad:";
            this.label1.UseWaitCursor = true;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(90, 54);
            this.TxtSoyad.Multiline = true;
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(121, 29);
            this.TxtSoyad.TabIndex = 2;
            this.TxtSoyad.UseWaitCursor = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(90, 87);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(121, 31);
            this.MskTC.TabIndex = 3;
            this.MskTC.UseWaitCursor = true;
            this.MskTC.ValidatingType = typeof(int);
            this.MskTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTC_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC:";
            this.label3.UseWaitCursor = true;
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(90, 21);
            this.TxtAd.Multiline = true;
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(121, 29);
            this.TxtAd.TabIndex = 1;
            this.TxtAd.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            this.label4.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtMiktarı);
            this.groupBox2.Controls.Add(this.TxtToplamFiyatı);
            this.groupBox2.Controls.Add(this.TxtSatışFiyatı);
            this.groupBox2.Controls.Add(this.TxtÜrünAdı);
            this.groupBox2.Controls.Add(this.TxtBarkodNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(2, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            this.groupBox2.UseWaitCursor = true;
            // 
            // TxtMiktarı
            // 
            this.TxtMiktarı.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMiktarı.Location = new System.Drawing.Point(126, 83);
            this.TxtMiktarı.Multiline = true;
            this.TxtMiktarı.Name = "TxtMiktarı";
            this.TxtMiktarı.Size = new System.Drawing.Size(121, 26);
            this.TxtMiktarı.TabIndex = 21;
            this.TxtMiktarı.Text = "1";
            this.TxtMiktarı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtMiktarı.UseWaitCursor = true;
            this.TxtMiktarı.TextChanged += new System.EventHandler(this.TxtMiktarı_TextChanged);
            // 
            // TxtToplamFiyatı
            // 
            this.TxtToplamFiyatı.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtToplamFiyatı.Location = new System.Drawing.Point(126, 145);
            this.TxtToplamFiyatı.Multiline = true;
            this.TxtToplamFiyatı.Name = "TxtToplamFiyatı";
            this.TxtToplamFiyatı.Size = new System.Drawing.Size(121, 26);
            this.TxtToplamFiyatı.TabIndex = 24;
            this.TxtToplamFiyatı.UseWaitCursor = true;
            // 
            // TxtSatışFiyatı
            // 
            this.TxtSatışFiyatı.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSatışFiyatı.Location = new System.Drawing.Point(126, 114);
            this.TxtSatışFiyatı.Multiline = true;
            this.TxtSatışFiyatı.Name = "TxtSatışFiyatı";
            this.TxtSatışFiyatı.Size = new System.Drawing.Size(121, 26);
            this.TxtSatışFiyatı.TabIndex = 23;
            this.TxtSatışFiyatı.UseWaitCursor = true;
            this.TxtSatışFiyatı.TextChanged += new System.EventHandler(this.TxtSatışFiyatı_TextChanged);
            // 
            // TxtÜrünAdı
            // 
            this.TxtÜrünAdı.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtÜrünAdı.Location = new System.Drawing.Point(126, 52);
            this.TxtÜrünAdı.Multiline = true;
            this.TxtÜrünAdı.Name = "TxtÜrünAdı";
            this.TxtÜrünAdı.Size = new System.Drawing.Size(121, 26);
            this.TxtÜrünAdı.TabIndex = 20;
            this.TxtÜrünAdı.UseWaitCursor = true;
            // 
            // TxtBarkodNo
            // 
            this.TxtBarkodNo.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBarkodNo.Location = new System.Drawing.Point(126, 21);
            this.TxtBarkodNo.Multiline = true;
            this.TxtBarkodNo.Name = "TxtBarkodNo";
            this.TxtBarkodNo.Size = new System.Drawing.Size(121, 26);
            this.TxtBarkodNo.TabIndex = 19;
            this.TxtBarkodNo.UseWaitCursor = true;
            this.TxtBarkodNo.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "BarkodNo:";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ürün Adı:";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Miktarı:";
            this.label7.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Satış Fiyatı:";
            this.label8.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Toplam Fiyatı:";
            this.label9.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 243);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // LblGenelToplam
            // 
            this.LblGenelToplam.AutoSize = true;
            this.LblGenelToplam.Location = new System.Drawing.Point(795, 406);
            this.LblGenelToplam.Name = "LblGenelToplam";
            this.LblGenelToplam.Size = new System.Drawing.Size(0, 23);
            this.LblGenelToplam.TabIndex = 12;
            this.LblGenelToplam.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(667, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Genel Toplam:";
            this.label12.UseWaitCursor = true;
            // 
            // BtnMüsteriEkle
            // 
            this.BtnMüsteriEkle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMüsteriEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMüsteriEkle.ImageIndex = 0;
            this.BtnMüsteriEkle.ImageList = this.ımageList1;
            this.BtnMüsteriEkle.Location = new System.Drawing.Point(-1, 27);
            this.BtnMüsteriEkle.Name = "BtnMüsteriEkle";
            this.BtnMüsteriEkle.Size = new System.Drawing.Size(164, 73);
            this.BtnMüsteriEkle.TabIndex = 20;
            this.BtnMüsteriEkle.Text = "Müşteri Ekleme";
            this.BtnMüsteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMüsteriEkle.UseVisualStyleBackColor = true;
            this.BtnMüsteriEkle.UseWaitCursor = true;
            this.BtnMüsteriEkle.Click += new System.EventHandler(this.BtnMüsteriEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "müşteri ekleme.png");
            this.ımageList1.Images.SetKeyName(1, "müşteri listeleme.png");
            this.ımageList1.Images.SetKeyName(2, "ürün ekleme.png");
            this.ımageList1.Images.SetKeyName(3, "ürün listeleme.png");
            this.ımageList1.Images.SetKeyName(4, "satış 2.png");
            this.ımageList1.Images.SetKeyName(5, "kaetgpri.png");
            this.ımageList1.Images.SetKeyName(6, "marka 1.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnSatışlarıListeleme);
            this.panel1.Controls.Add(this.BtnMusteriListeleme);
            this.panel1.Controls.Add(this.BtnÜrünListeleme);
            this.panel1.Controls.Add(this.BtnÜrünEkleme);
            this.panel1.Controls.Add(this.BtnMüsteriEkle);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 125);
            this.panel1.TabIndex = 21;
            this.panel1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 5;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(820, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 73);
            this.button2.TabIndex = 26;
            this.button2.Text = "Kategori";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(989, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 73);
            this.button1.TabIndex = 25;
            this.button1.Text = "Marka";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSatışlarıListeleme
            // 
            this.BtnSatışlarıListeleme.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatışlarıListeleme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSatışlarıListeleme.ImageIndex = 4;
            this.BtnSatışlarıListeleme.ImageList = this.ımageList1;
            this.BtnSatışlarıListeleme.Location = new System.Drawing.Point(653, 27);
            this.BtnSatışlarıListeleme.Name = "BtnSatışlarıListeleme";
            this.BtnSatışlarıListeleme.Size = new System.Drawing.Size(168, 73);
            this.BtnSatışlarıListeleme.TabIndex = 24;
            this.BtnSatışlarıListeleme.Text = "Satışları Listeleme";
            this.BtnSatışlarıListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSatışlarıListeleme.UseVisualStyleBackColor = true;
            this.BtnSatışlarıListeleme.UseWaitCursor = true;
            this.BtnSatışlarıListeleme.Click += new System.EventHandler(this.BtnSatışlarıListeleme_Click);
            // 
            // BtnMusteriListeleme
            // 
            this.BtnMusteriListeleme.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriListeleme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMusteriListeleme.ImageIndex = 1;
            this.BtnMusteriListeleme.ImageList = this.ımageList1;
            this.BtnMusteriListeleme.Location = new System.Drawing.Point(163, 27);
            this.BtnMusteriListeleme.Name = "BtnMusteriListeleme";
            this.BtnMusteriListeleme.Size = new System.Drawing.Size(164, 73);
            this.BtnMusteriListeleme.TabIndex = 23;
            this.BtnMusteriListeleme.Text = "Müşteri Listeleme";
            this.BtnMusteriListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMusteriListeleme.UseVisualStyleBackColor = true;
            this.BtnMusteriListeleme.UseWaitCursor = true;
            this.BtnMusteriListeleme.Click += new System.EventHandler(this.BtnMusteriListeleme_Click);
            // 
            // BtnÜrünListeleme
            // 
            this.BtnÜrünListeleme.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnÜrünListeleme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnÜrünListeleme.ImageIndex = 3;
            this.BtnÜrünListeleme.ImageList = this.ımageList1;
            this.BtnÜrünListeleme.Location = new System.Drawing.Point(490, 27);
            this.BtnÜrünListeleme.Name = "BtnÜrünListeleme";
            this.BtnÜrünListeleme.Size = new System.Drawing.Size(164, 73);
            this.BtnÜrünListeleme.TabIndex = 22;
            this.BtnÜrünListeleme.Text = "Ürün Listeleme";
            this.BtnÜrünListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnÜrünListeleme.UseVisualStyleBackColor = true;
            this.BtnÜrünListeleme.UseWaitCursor = true;
            this.BtnÜrünListeleme.Click += new System.EventHandler(this.BtnÜrünListeleme_Click);
            // 
            // BtnÜrünEkleme
            // 
            this.BtnÜrünEkleme.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnÜrünEkleme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnÜrünEkleme.ImageIndex = 2;
            this.BtnÜrünEkleme.ImageList = this.ımageList1;
            this.BtnÜrünEkleme.Location = new System.Drawing.Point(327, 27);
            this.BtnÜrünEkleme.Name = "BtnÜrünEkleme";
            this.BtnÜrünEkleme.Size = new System.Drawing.Size(164, 73);
            this.BtnÜrünEkleme.TabIndex = 21;
            this.BtnÜrünEkleme.Text = "Ürün Ekleme";
            this.BtnÜrünEkleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnÜrünEkleme.UseVisualStyleBackColor = true;
            this.BtnÜrünEkleme.UseWaitCursor = true;
            this.BtnÜrünEkleme.Click += new System.EventHandler(this.BtnÜrünEkleme_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.White;
            this.BtnEkle.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnEkle.ImageIndex = 0;
            this.BtnEkle.ImageList = this.ımageList2;
            this.BtnEkle.Location = new System.Drawing.Point(899, 168);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(153, 44);
            this.BtnEkle.TabIndex = 30;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.UseWaitCursor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSatışYap
            // 
            this.BtnSatışYap.BackColor = System.Drawing.Color.White;
            this.BtnSatışYap.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BtnSatışYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSatışYap.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnSatışYap.ImageIndex = 3;
            this.BtnSatışYap.ImageList = this.ımageList2;
            this.BtnSatışYap.Location = new System.Drawing.Point(899, 316);
            this.BtnSatışYap.Name = "BtnSatışYap";
            this.BtnSatışYap.Size = new System.Drawing.Size(153, 44);
            this.BtnSatışYap.TabIndex = 31;
            this.BtnSatışYap.Text = "Satış yap";
            this.BtnSatışYap.UseVisualStyleBackColor = false;
            this.BtnSatışYap.UseWaitCursor = true;
            this.BtnSatışYap.Click += new System.EventHandler(this.BtnSatışYap_Click);
            // 
            // Btnsatışİptal
            // 
            this.Btnsatışİptal.BackColor = System.Drawing.Color.White;
            this.Btnsatışİptal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Btnsatışİptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnsatışİptal.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btnsatışİptal.ImageIndex = 2;
            this.Btnsatışİptal.ImageList = this.ımageList2;
            this.Btnsatışİptal.Location = new System.Drawing.Point(899, 268);
            this.Btnsatışİptal.Name = "Btnsatışİptal";
            this.Btnsatışİptal.Size = new System.Drawing.Size(153, 44);
            this.Btnsatışİptal.TabIndex = 32;
            this.Btnsatışİptal.Text = "Satış İptal";
            this.Btnsatışİptal.UseVisualStyleBackColor = false;
            this.Btnsatışİptal.UseWaitCursor = true;
            this.Btnsatışİptal.Click += new System.EventHandler(this.Btnsatışİptal_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.White;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSil.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnSil.ImageIndex = 1;
            this.BtnSil.ImageList = this.ımageList2;
            this.BtnSil.Location = new System.Drawing.Point(899, 218);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(153, 44);
            this.BtnSil.TabIndex = 33;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.UseWaitCursor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "992651.png");
            this.ımageList2.Images.SetKeyName(1, "images.png");
            this.ımageList2.Images.SetKeyName(2, "png-transparent-cancel-delete-cross-check-box-check-tick-icon-red-forbidden-block" +
        "ed-thumbnail.png");
            this.ımageList2.Images.SetKeyName(3, "png-transparent-check-mark-afacere-others-miscellaneous-text-logo.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1113, 499);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.Btnsatışİptal);
            this.Controls.Add(this.BtnSatışYap);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblGenelToplam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblGenelToplam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnMüsteriEkle;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtMiktarı;
        private System.Windows.Forms.TextBox TxtToplamFiyatı;
        private System.Windows.Forms.TextBox TxtSatışFiyatı;
        private System.Windows.Forms.TextBox TxtÜrünAdı;
        private System.Windows.Forms.TextBox TxtBarkodNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSatışlarıListeleme;
        private System.Windows.Forms.Button BtnMusteriListeleme;
        private System.Windows.Forms.Button BtnÜrünListeleme;
        private System.Windows.Forms.Button BtnÜrünEkleme;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSatışYap;
        private System.Windows.Forms.Button Btnsatışİptal;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}

