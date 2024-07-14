namespace StokTakip
{
    partial class FrmMarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarka));
            this.BtnYeniEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbKategori = new System.Windows.Forms.ComboBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // BtnYeniEkle
            // 
            this.BtnYeniEkle.BackColor = System.Drawing.Color.White;
            this.BtnYeniEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYeniEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnYeniEkle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnYeniEkle.ImageIndex = 0;
            this.BtnYeniEkle.ImageList = this.ımageList1;
            this.BtnYeniEkle.Location = new System.Drawing.Point(113, 101);
            this.BtnYeniEkle.Name = "BtnYeniEkle";
            this.BtnYeniEkle.Size = new System.Drawing.Size(100, 44);
            this.BtnYeniEkle.TabIndex = 25;
            this.BtnYeniEkle.Text = "Ekle";
            this.BtnYeniEkle.UseVisualStyleBackColor = false;
            this.BtnYeniEkle.Click += new System.EventHandler(this.BtnYeniEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kategori:";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMarka.Location = new System.Drawing.Point(104, 62);
            this.TxtMarka.Multiline = true;
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(121, 31);
            this.TxtMarka.TabIndex = 2;
            this.TxtMarka.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Marka:";
            // 
            // CmbKategori
            // 
            this.CmbKategori.FormattingEnabled = true;
            this.CmbKategori.Location = new System.Drawing.Point(104, 25);
            this.CmbKategori.Name = "CmbKategori";
            this.CmbKategori.Size = new System.Drawing.Size(121, 31);
            this.CmbKategori.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "pngtree-blue-plus-concept-icon-on-white-background-png-image_5097450.png");
            // 
            // FrmMarka
            // 
            this.AcceptButton = this.BtnYeniEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(258, 160);
            this.Controls.Add(this.CmbKategori);
            this.Controls.Add(this.TxtMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnYeniEkle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Sayfası";
            this.Load += new System.EventHandler(this.FrmMarka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnYeniEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbKategori;
        private System.Windows.Forms.ImageList ımageList1;
    }
}