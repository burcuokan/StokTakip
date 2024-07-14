using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StokTakip
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=Okan;Initial Catalog=StokTakip;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
