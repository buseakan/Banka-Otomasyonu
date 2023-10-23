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

namespace banka_otomasyonu
{
    public partial class bakiye_goruntule : Form
    {
        // SQL bağlantısı için gerekli bilgileri burada ayarlayın
        private string connectionString = "Data Source = LAPTOP-JVBBL3AB; Database = banka_otomasyonu; Integrated Security = True";

        public bakiye_goruntule()
        {
            InitializeComponent();
        }

        private void btnbakiyegoster_Click(object sender, EventArgs e)
        {

            string id = txtid.Text;
            string adsoyad = txtadsoyad.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Müşteri bilgilerine göre veritabanında bakiye sorgusu
                    string query = "SELECT bakiye FROM müsteriler WHERE ID= @id AND adSoyad=@adSoyad";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@adSoyad", adsoyad);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            decimal bakiye = Convert.ToDecimal(result);
                            lblBakiye.Text = bakiye.ToString("C2");//Para birimi formatıyla göstermek için "C2" formatı kullanıyoruz.
                        }
                        else
                        {
                            lblBakiye.Text = "Müşteri Bulunamadı.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu.: " + ex.Message);
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            hesapislemleri Hesapislemleri = new hesapislemleri();
            this.Hide();
            Hesapislemleri.ShowDialog();
        }
    }
}
