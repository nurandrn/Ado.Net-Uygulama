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

namespace DisconnectedMimari1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

            UrunlerGoster();


        }

        private void UrunlerGoster()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Products where Discontinued=0", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ProductID"].Visible = false;//metotla yap
            dataGridView1.Columns["CategoryID"].Visible = false;
            dataGridView1.Columns["SupplierID"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            //StoredProcedure Kullanmadan
            //SqlCommand komut = new SqlCommand("insert into Products(ProductName,UnitPrice,UnitsInStock) VALUES(@ProductName, @UnitPrice, @UnitsInStock)", baglanti);
            //komut.CommandType = CommandType.Text;
            
            SqlCommand komut = new SqlCommand("AddProduct", baglanti);
            baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            if (string.IsNullOrWhiteSpace(textUrunAdı.Text) || numFiyat.Value < 0 || numStok.Value < 0)
            {
                MessageBox.Show("Ürün Bilgileri Boş Geçilemez");
            }
            else
            {
                komut.Parameters.AddWithValue("@ProductName", textUrunAdı.Text);
                komut.Parameters.AddWithValue("@UnitPrice", numFiyat.Value);
                komut.Parameters.AddWithValue("@UnitsInStock", numStok.Value);
                int sayı = komut.ExecuteNonQuery();
                if (sayı > 0)
                {
                    MessageBox.Show("Ürünü Başarıyla Eklediniz.");
                    UrunlerGoster();

                }            //execute return değerini bri değişkene alınacak messaje alınacak 
                             //string.formatlara çalışılacak ne anlama geliyor.
                else
                {
                    MessageBox.Show("Ters Giden Bişeyler Var");
                }
            }
            baglanti.Close();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textUrunAdı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textUrunAdı.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            numFiyat.Value = Convert.ToInt16(dataGridView1.CurrentRow.Cells["UnitPrice"].Value);
            numStok.Value = Convert.ToInt16(dataGridView1.CurrentRow.Cells["UnitsInStock"].Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ProductID = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ProductID"].Value);
            SqlCommand komut = new SqlCommand("Update Products set  ProductName=@ProductName,UnitPrice=@UnitPrice,UnitsInStock=@UnitsInStock where ProductID=@ProductID", baglanti);
            komut.Parameters.AddWithValue("@ProductName", textUrunAdı.Text);
            komut.Parameters.AddWithValue("@UnitPrice", numFiyat.Value);
            komut.Parameters.AddWithValue("@UnitsInStock", numStok.Value);
            komut.Parameters.AddWithValue("@ProductID", ProductID);


            baglanti.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün Güncellenmiştir");
            UrunlerGoster();
            baglanti.Close();
        }
        //public void OrdersDetailsSil()
        //{
        //    int ProductID = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ProductID"].Value);
        //    SqlCommand komut = new SqlCommand("Delete from Order Details where ProductID=@ProductID", baglanti);
        //    komut.Parameters.AddWithValue("@ProductID", ProductID);
        //    baglanti.Open();
        //    komut.ExecuteNonQuery();
        //    UrunlerGoster();
        //    baglanti.Close();
        //}


        private void SilMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            int ProductID = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ProductID"].Value);
            //storeprosedure kullanılmadan yapılan
            //string query = "DELETE FROM WHERE ProductID=@productID";
            try
            {
                SqlCommand komut = new SqlCommand("DeleteProduct", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ProductID", ProductID);
                baglanti.Open();
                int affectedRows = komut.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    UrunlerGoster();
                    MessageBox.Show("Selected row deleted successfully");

                }
            }
            catch (SqlException exc)
            {
                if (exc.Number == 547)
                {
                    DialogResult result = MessageBox.Show("Ürünleri Silmek istediğinizden emin misiniz", "Bilgilendirme", MessageBoxButtons.YesNoCancel);
                }
            }
                
                baglanti.Close();
                //try
                //{

                //    SilMetodu();


                //}
                //catch (SqlException ex)
                //{
                //    MessageBox.Show(ex.Message);
                //    DialogResult Secenek = new DialogResult();
                //    Secenek = MessageBox.Show("Ürünü Silmek İstediğinizden Emin Misiniz?", "Bilgilendirme ", MessageBoxButtons.YesNo);
                //    if (Secenek == DialogResult.Yes)
                //    {

                //        SilMetodu();

                //    }
                //    else
                //    {
                //                    MessageBox.Show("ürün Silinmedi");
                //                }



                //            }
                //        }

                //            private void SilMetodu()
                //{
                //    int ProductID = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ProductID"].Value);
                //    SqlCommand komut = new SqlCommand("Delete from Products where ProductID=@ProductID", baglanti);
                //    komut.Parameters.AddWithValue("@ProductID", ProductID);
                //    baglanti.Open();
                //    komut.ExecuteNonQuery();
                //    UrunlerGoster();
                //    baglanti.Close();
            }
        }
    }

