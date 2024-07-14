using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakip
{
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("Select*from Tbl_Urunler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (TxtBarkodNo.Text==dr[1].ToString() || TxtBarkodNo.Text=="")
                {
                    durum = false;
                }
                bgl.baglanti().Close();
            }
        }

        private void KategoriGetir()
        {
            SqlCommand komut = new SqlCommand("Select*from Tbl_Kategori", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbKategori.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();

        }
        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        private void CmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbMarka.Items.Clear();  // Daha Önceki Kayıtlar Silinsin.
            CmbMarka.Text = "";
            SqlCommand komut = new SqlCommand("Select*from Tbl_Marka where Kategori='" + CmbKategori.SelectedItem + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbMarka.Items.Add(dr[2].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnYeniEkle_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Yeni ürün eklemek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {

                barkodkontrol();
                if (durum == true)
                {
                    SqlCommand komut = new SqlCommand("insert into Tbl_Urunler(BarkodNo,Kategori,Marka,UrunAdi,Miktari,AlisFiyati,SatisFiyati,Tarih)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtBarkodNo.Text);
                    komut.Parameters.AddWithValue("@p2", CmbKategori.Text);
                    komut.Parameters.AddWithValue("@p3", CmbMarka.Text);
                    komut.Parameters.AddWithValue("@p4", TxtÜrünAdı.Text);
                    komut.Parameters.AddWithValue("@p5", int.Parse(TxtMiktarı.Text));
                    komut.Parameters.AddWithValue("@p6", double.Parse(TxtAlısFiyatı.Text));
                    komut.Parameters.AddWithValue("@p7", double.Parse(TxtSatısFiyatı.Text));
                    komut.Parameters.AddWithValue("@p8", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Böyle bir barkodno var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            CmbMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void TxtVarOlanbarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (TxtVarOlanbarkodNo.Text == "")  // Var Olan Barkodları Temizle
            {
                LblMiktari.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            SqlCommand komut = new SqlCommand("Select*from Tbl_Urunler where BarkodNo like '" + TxtVarOlanbarkodNo.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtVarOlanKategori.Text = dr[2].ToString();
                TxtVarOlanMarka.Text = dr[3].ToString();
                TxtVarOlanUrunAdi.Text = dr[4].ToString();
                LblMiktari.Text = dr[5].ToString();
                TxtVarOlanAlısFiyatı.Text = dr[6].ToString();
                TxtVarOlanSatısFiyatı.Text = dr[7].ToString();

            }
            bgl.baglanti().Close();
        }

        private void BtnVarOlanaEkle_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Ürün eklemek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update Tbl_Urunler set Miktari=Miktari+'" + int.Parse(TxtVarOlanMiktarı.Text) + "' where BarkodNo='" + TxtVarOlanbarkodNo.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Var Olan Ürüne Ekleme Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            
        }
        }
    }
}
