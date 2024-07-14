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
    public partial class FrmMarka : Form
    {
        public FrmMarka()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        bool durum;
        private void markakontrol()
        {
            durum = true;
            SqlCommand komut = new SqlCommand("Select*from Tbl_Marka", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (CmbKategori.Text == dr[1].ToString() && TxtMarka.Text == dr[2].ToString() || CmbKategori.Text == "" || TxtMarka.Text == "")
                {
                    durum = false;
                }
                bgl.baglanti().Close();
            }
        }
           
            private void BtnYeniEkle_Click(object sender, EventArgs e)
            {
            markakontrol();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Marka(Kategori,Marka) values('" + CmbKategori.Text + "','" + TxtMarka.Text + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                TxtMarka.Text = "";
                CmbKategori.Text = "";
                MessageBox.Show("Marka Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori ve marka var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            TxtMarka.Text = "";
            CmbKategori.Text = "";
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

        private void FrmMarka_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }
    }
}
    
