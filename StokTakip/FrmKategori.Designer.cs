namespace StokTakip
{
    partial class FrmKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategori));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.BtnYeniEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori:";
            // 
            // TxtKategori
            // 
            this.TxtKategori.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKategori.Location = new System.Drawing.Point(96, 26);
            this.TxtKategori.Multiline = true;
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(121, 31);
            this.TxtKategori.TabIndex = 21;
            this.TxtKategori.UseWaitCursor = true;
            // 
            // BtnYeniEkle
            // 
            this.BtnYeniEkle.BackColor = System.Drawing.Color.White;
            this.BtnYeniEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYeniEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnYeniEkle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnYeniEkle.ImageIndex = 0;
            this.BtnYeniEkle.ImageList = this.ımageList1;
            this.BtnYeniEkle.Location = new System.Drawing.Point(100, 63);
            this.BtnYeniEkle.Name = "BtnYeniEkle";
            this.BtnYeniEkle.Size = new System.Drawing.Size(113, 44);
            this.BtnYeniEkle.TabIndex = 22;
            this.BtnYeniEkle.Text = "Ekle";
            this.BtnYeniEkle.UseVisualStyleBackColor = false;
            this.BtnYeniEkle.Click += new System.EventHandler(this.BtnYeniEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add-list-icon--icon-search-engine-25.png");
            // 
            // FrmKategori
            // 
            this.AcceptButton = this.BtnYeniEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(247, 129);
            this.Controls.Add(this.BtnYeniEkle);
            this.Controls.Add(this.TxtKategori);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Button BtnYeniEkle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}