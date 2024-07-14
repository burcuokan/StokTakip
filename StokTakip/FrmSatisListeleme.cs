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
    public partial class FrmSatisListeleme : Form
    {
        public FrmSatisListeleme()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void SatışListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Satis", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmSatisListeleme_Load(object sender, EventArgs e)
        {
            SatışListele();
        }
    }
}
