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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        bool durum;

        private void kategorikontrol()
        {
            SqlCommand komut = new SqlCommand("Select*from Tbl_Kategori", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (TxtKategori.Text==dr[1].ToString() || TxtKategori.Text=="")
                {
                    durum = false;
                }
                bgl.baglanti().Close();
            }
        }
        private void BtnYeniEkle_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            if (durum==true)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Kategori(Kategori) values('" + TxtKategori.Text + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                TxtKategori.Text = "";
                MessageBox.Show("Kategori Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            TxtKategori.Text = "";
        }

        
    }
}
