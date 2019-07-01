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
using System.Configuration;


namespace AdoGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);  
            }
          //  con = new SqlConnection(Properties.Settings.Default.connection);
            catch(System.ApplicationException ex)
            {
                Console.WriteLine("Error Reading from {0}. Message={1}" ,ex.Source,ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
            /*
             * veritabanına üzerinde işlem yapabilmek için :
             * hangi server a
             * hangi veritabanına
             * hangi güvenlik kurallarıyla
             * bilgilerini içeren  bir bağlantı cumlesi yazılır.
             * bağlantı türleri için connectionstrings.com adresinden farklı örneklerine bakılabilir.
             */
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                MessageBox.Show("Bağlatı Açıldı");
            }
            else
            {
                MessageBox.Show("Açık bir Bağlantı var");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                MessageBox.Show("Bağlantı kapatıldı");
                                        }
            else
            {
                MessageBox.Show("Bağlantı Açık Değil");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    MessageBox.Show("Bağantı Açıldı");
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Bağlantı Kapandı");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
