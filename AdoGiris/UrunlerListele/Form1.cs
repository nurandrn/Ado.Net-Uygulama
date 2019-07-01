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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Ürünler";
            baglantı.ConnectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select ProductName,UnitPrice,UnitsInStock from Products",baglantı);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                string ad = string.Format("{0}-{1}-{2}", rdr["ProductName"], rdr["UnitPrice"], rdr["UnitsInStock"]);
                listBox1.Items.Add(ad);
                


            }
            rdr.Close();
            
            baglantı.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.Show();
        }
    }
}
