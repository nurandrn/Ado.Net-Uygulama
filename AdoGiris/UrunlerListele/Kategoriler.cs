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

namespace UrunlerListele
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
       
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select CategoryName,Description from Categories", conn);
            SqlDataReader   rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                string yaz = string.Format("{0}-{1}", rdr["CategoryName"], rdr["Description"]);
                listBox1.Items.Add(yaz);

            }
            rdr.Close();
            conn.Close();
            

        }
    }
}
