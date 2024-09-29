using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_takip_1
{
    internal class Veritabanı
    {
            public static SqlConnection baglantı = new SqlConnection("Server=localhost;Database=Personel_Takip_1;User Id=Itydori;Integrated Security=True;");
        public static void ESG(SqlCommand cmd, string sql)
        {
            baglantı.Open();
            cmd.Connection = baglantı;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            baglantı.Close();
        }
        public static DataTable Listele_Ara (DataGridView gridview,string sql)
        {
            DataTable tbl = new DataTable();
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglantı);
            adtr.Fill(tbl);
            gridview.DataSource = tbl;
            baglantı.Close();
            return tbl;
        } 
    }
}
