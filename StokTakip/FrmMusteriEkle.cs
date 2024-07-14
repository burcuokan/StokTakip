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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        bool durum;
        private void uyekontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("Select*from TBL_Musteriler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (MskTC.Text == dr[3].ToString() || MskTC.Text == "")
                {
                    durum = false;
                }
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Müşteri eklemek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                uyekontrol();
                if (durum == true)
                {
                    SqlCommand komut = new SqlCommand("insert into Tbl_Musteriler(MusteriAd,MusteriSoyad,MusteriTC,MusteriTelefon,MusteriAdres,MusteriEmail) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", MskTC.Text);
                    komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
                    komut.Parameters.AddWithValue("@p5", TxtAdres.Text);
                    komut.Parameters.AddWithValue("@p6", TxtEmail.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Müşteri Kaydı Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Önce bilgiler eklenmelidir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                TxtAd.Text = "";
                TxtSoyad.Text = "";
                MskTC.Text = "";
                MskTelefon.Text = "";
                TxtAdres.Text = "";
                TxtEmail.Text = "";
            }
        }
    }
}