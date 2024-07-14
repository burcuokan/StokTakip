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
    public partial class FrmMusteriListeleme : Form
    {
        public FrmMusteriListeleme()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

       private void Listele()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Musteriler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmMusteriListeleme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtAdres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtEmail.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select *from Tbl_Musteriler where MusteriTC like '%" + TxtTCAra.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Bu kitabı güncellemek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update Tbl_Musteriler set MusteriAd=@p1,MusteriSoyad=@p2,MusteriTelefon=@p4,MusteriAdres=@p5,MusteriEmail=@p6 where MusteriTC=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTC.Text);
                komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
                komut.Parameters.AddWithValue("@p5", TxtAdres.Text);
                komut.Parameters.AddWithValue("@p6", TxtEmail.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                Listele();
                MessageBox.Show("Müşteri Kaydı Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTC.Text = "";
            MskTelefon.Text = "";
            TxtAdres.Text = "";
            TxtEmail.Text = "";

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult diyalog;
            diyalog = MessageBox.Show("Bu kitabı silmek istediğinizden emin misiniz?", "Soru Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diyalog == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from Tbl_Musteriler where MusteriTC=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", MskTC.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                Listele();
                MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
                

        }
    }
}
