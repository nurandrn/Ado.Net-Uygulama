using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedMimari1
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void KategoriListele()
        {
            SqlDataAdapter adr = new SqlDataAdapter("select * from Categories", conn);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            kategorileriListele.DataSource = dt;
            kategorileriListele.Columns["CategoryID"].Visible = false;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Categories(CategoryName,Description) Values(@CategoryName,@Description)",conn);
            conn.Open();
            if (string.IsNullOrWhiteSpace(txtcatname.Text) || string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("Kategori ismi Ve Description Boş Geçilemez");
            }
            else
            {
                komut.Parameters.AddWithValue("@CategoryName", txtcatname.Text);
                komut.Parameters.AddWithValue("@Description", txtDesc.Text);
                int sayi = komut.ExecuteNonQuery();
                if (sayi > 0)
                {
                    MessageBox.Show("Kategori Eklendi");
                    KategoriListele();
                    
                }
                else
                {
                    MessageBox.Show("Hata Var");
                }
            }
            conn.Close();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            //DataGridViewImageColumn img = new DataGridViewImageColumn();
            //Image image = Image.FromFile(@"C:\Users\iau\Desktop");
            //img.Image = image;
            //img.ValuesAreIcons = true;
            //kategorileriListele.Columns.Add(img);
            //img.HeaderText = "Image";
            //img.Name = "img";

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                SqlCommand komut = new SqlCommand("insert into Categories(Picture) Values(@Picture)", conn);
                komut.Parameters.AddWithValue("@picture", txtcatname.Text);


            }
        }
        }
}
