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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void SepetListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Sepet", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }
        private void BtnMüsteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle fr = new FrmMusteriEkle();
            fr.Show();
        }

        private void BtnMusteriListeleme_Click(object sender, EventArgs e)
        {
            FrmMusteriListeleme fr = new FrmMusteriListeleme();
            fr.Show();
        }

        private void BtnÜrünEkleme_Click(object sender, EventArgs e)
        {
            FrmUrunEkle fr = new FrmUrunEkle();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKategori fr = new FrmKategori();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMarka fr = new FrmMarka();
            fr.Show();
        }

        private void BtnÜrünListeleme_Click(object sender, EventArgs e)
        {
            FrmUrunListelemeSayfası fr = new FrmUrunListelemeSayfası();
            fr.Show();
        }

        private void Hesapla()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select sum(ToplamFiyati) from Tbl_Sepet", bgl.baglanti());
                LblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void MskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (MskTC.Text == "") // Boş olduğunda ad,soyad temizlensin.
            {
                TxtAd.Text = "";
                TxtSoyad.Text = "";
                MskTelefon.Text = "";
            }
            SqlCommand komut = new SqlCommand("Select*from Tbl_Musteriler where MusteriTC like '" + MskTC.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTelefon.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();
        }


        private void TxtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            SqlCommand komut = new SqlCommand("Select*from Tbl_Urunler where BarkodNo like '" + TxtBarkodNo.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtÜrünAdı.Text = dr[4].ToString();
                TxtSatışFiyatı.Text = dr[7].ToString();
            }
            bgl.baglanti().Close();
        }

        private void Temizle()
        {
            if (TxtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != TxtMiktarı)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        bool durum;

        private void barkodkontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("Select*from Tbl_Sepet", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (TxtBarkodNo.Text == dr[3].ToString()) // Eğer aynı numaralı barkod ürün varsa alt alta ekleme yapma miktar üzerine ekleme yap.
                {
                    durum = false;
                }
                bgl.baglanti().Close();
            }
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepet (Ad,Soyad,TC,BarkodNo,UrunAdi,Miktari,SatisFiyati,ToplamFiyati,Tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTC.Text);
                komut.Parameters.AddWithValue("@p4", TxtBarkodNo.Text);
                komut.Parameters.AddWithValue("@p5", TxtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@p6", int.Parse(TxtMiktarı.Text));
                komut.Parameters.AddWithValue("@p7", double.Parse(TxtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@p8", double.Parse(TxtToplamFiyatı.Text));
                komut.Parameters.AddWithValue("@p9", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün İşlemleri Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("Update Tbl_Sepet set Miktari=Miktari+'" + int.Parse(TxtMiktarı.Text) + "' where BarkodNo ='" + TxtBarkodNo.Text + "'", bgl.baglanti());
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("Update Tbl_Sepet set ToplamFiyati=Miktari*SatisFiyati where BarkodNo='" + TxtBarkodNo.Text + "'", bgl.baglanti());
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            TxtMiktarı.Text = "1";
            SepetListele();
            Hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != TxtMiktarı)
                    {
                        item.Text = "";
                    }
                }
            }
        }
        private void TxtMiktarı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtToplamFiyatı.Text = (double.Parse(TxtMiktarı.Text) * double.Parse(TxtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void TxtSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtToplamFiyatı.Text = (int.Parse(TxtMiktarı.Text) * double.Parse(TxtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Sepet where BarkodNo='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sepetten Çıkarıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SepetListele();
            Hesapla();
        }

        private void Btnsatışİptal_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Sepet", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SepetListele();
            Hesapla();
        }

        private void BtnSatışlarıListeleme_Click(object sender, EventArgs e)
        {
            FrmSatisListeleme fr = new FrmSatisListeleme();
            fr.Show();
        }

        private void BtnSatışYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Satis (Ad,Soyad,TC,BarkodNo,UrunAdi,Miktari,SatisFiyati,ToplamFiyati,Tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTC.Text);
                komut.Parameters.AddWithValue("@p4", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                komut.Parameters.AddWithValue("@p5", dataGridView1.Rows[i].Cells["UrunAdi"].Value.ToString());
                komut.Parameters.AddWithValue("@p6", int.Parse(dataGridView1.Rows[i].Cells["Miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@p7", double.Parse(dataGridView1.Rows[i].Cells["SatisFiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@p8", double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@p9", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("Update Tbl_Urunler set Miktari=Miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["Miktari"].Value.ToString()) + "' where BarkodNo='" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", bgl.baglanti());
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                
            }
            SqlCommand komut3 = new SqlCommand("Delete from Tbl_Sepet", bgl.baglanti());
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            SepetListele();
            Hesapla();
        }
    }
}
    


