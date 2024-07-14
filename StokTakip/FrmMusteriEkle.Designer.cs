namespace StokTakip
{
    partial class FrmMusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(97, 131);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(121, 31);
            this.MskTelefon.TabIndex = 4;
            this.MskTelefon.UseWaitCursor = true;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(97, 59);
            this.TxtSoyad.Multiline = true;
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(121, 29);
            this.TxtSoyad.TabIndex = 2;
            this.TxtSoyad.UseWaitCursor = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(97, 94);
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
            this.TxtAd.Location = new System.Drawing.Point(97, 24);
            this.TxtAd.Multiline = true;
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(121, 29);
            this.TxtAd.TabIndex = 1;
            this.TxtAd.UseWaitCursor = true;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdres.Location = new System.Drawing.Point(97, 168);
            this.TxtAdres.Multiline = true;
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(121, 29);
            this.TxtAdres.TabIndex = 5;
            this.TxtAdres.UseWaitCursor = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEmail.Location = new System.Drawing.Point(97, 203);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(121, 29);
            this.TxtEmail.TabIndex = 6;
            this.TxtEmail.UseWaitCursor = true;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.White;
            this.BtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnEkle.ImageIndex = 0;
            this.BtnEkle.ImageList = this.ımageList1;
            this.BtnEkle.Location = new System.Drawing.Point(97, 238);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(121, 44);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add-user.png");
            // 
            // FrmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(322, 337);
            this.Controls.Add(this.BtnEkle);
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
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}