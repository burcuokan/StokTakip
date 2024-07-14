namespace StokTakip
{
    partial class FrmMusteriListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriListeleme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTCAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEmail.Location = new System.Drawing.Point(81, 234);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(121, 29);
            this.TxtEmail.TabIndex = 6;
            this.TxtEmail.UseWaitCursor = true;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdres.Location = new System.Drawing.Point(81, 199);
            this.TxtAdres.Multiline = true;
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(121, 29);
            this.TxtAdres.TabIndex = 5;
            this.TxtAdres.UseWaitCursor = true;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(81, 162);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(121, 31);
            this.MskTelefon.TabIndex = 4;
            this.MskTelefon.UseWaitCursor = true;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(81, 90);
            this.TxtSoyad.Multiline = true;
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(121, 29);
            this.TxtSoyad.TabIndex = 2;
            this.TxtSoyad.UseWaitCursor = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(81, 125);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(121, 31);
            this.MskTC.TabIndex = 3;
            this.MskTC.UseWaitCursor = true;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtAd
            // 
            this.TxtAd.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(81, 55);
            this.TxtAd.Multiline = true;
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(121, 29);
            this.TxtAd.TabIndex = 1;
            this.TxtAd.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad:";
            // 
            // TxtTCAra
            // 
            this.TxtTCAra.Location = new System.Drawing.Point(638, 13);
            this.TxtTCAra.Name = "TxtTCAra";
            this.TxtTCAra.Size = new System.Drawing.Size(132, 31);
            this.TxtTCAra.TabIndex = 27;
            this.TxtTCAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(568, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "TC Ara";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.White;
            this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnGuncelle.ImageIndex = 0;
            this.BtnGuncelle.ImageList = this.ımageList1;
            this.BtnGuncelle.Location = new System.Drawing.Point(62, 284);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(149, 44);
            this.BtnGuncelle.TabIndex = 31;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.White;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSil.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnSil.ImageIndex = 1;
            this.BtnSil.ImageList = this.ımageList1;
            this.BtnSil.Location = new System.Drawing.Point(62, 332);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(149, 44);
            this.BtnSil.TabIndex = 32;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "204-2047613_png-file-refresh-icon-black-png.png");
            this.ımageList1.Images.SetKeyName(1, "images.png");
            // 
            // FrmMusteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(830, 382);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTCAra);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMusteriListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme";
            this.Load += new System.EventHandler(this.FrmMusteriListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTCAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.ImageList ımageList1;
    }
}