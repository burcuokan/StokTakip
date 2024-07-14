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
    public partial class FrmUrunListelemeSayfası : Form
    {
        public FrmUrunListelemeSayfası()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

       
        private void ÜrünListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urunler",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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
        private void FrmUrunListelemeSayfası_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            KategoriGetir();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtBarkodNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtKategori.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtMarka.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtUrunAdi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMiktarı.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtAlısFiyatı.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtSatısFiyatı.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Urunler set Urunadi=@p2, Miktari=@p3, AlisFiyati=@p4, SatisFiyati=@p5 where BarkodNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBarkodNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtUrunAdi.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(TxtMiktarı.Text));
            komut.Parameters.AddWithValue("@p4", double.Parse(TxtAlısFiyatı.Text));
            komut.Parameters.AddWithValue("@p5", double.Parse(TxtSatısFiyatı.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Listeleme Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            
        }

        private void BtnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Urunler set Kategori=@p2, Marka=@p3 where BarkodNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBarkodNo.Text);
            komut.Parameters.AddWithValue("@p2", CmbKategori.Text);
            komut.Parameters.AddWithValue("@p3", CmbMarka.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Listeleme Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
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

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Urunler where BarkodNo=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBarkodNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            
        }

        private void TxtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *from Tbl_Urunler where BarkodNo like '%" + TxtBarkodNoAra.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
    }
