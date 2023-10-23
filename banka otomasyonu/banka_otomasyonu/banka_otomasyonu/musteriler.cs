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
    public partial class musteriler : Form
    {
        // SQL bağlantısı için gerekli bilgileri burada ayarlayın
        private string connectionString = "Data Source = LAPTOP-JVBBL3AB; Database = banka_otomasyonu; Integrated Security = True";


        public musteriler()
        {
            InitializeComponent();
            müsterileriyukle();
        }
        private void müsterileriyukle()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Müşteriler tablosundan müşteri bilgilerini çekme sorgusu
                    string query = "SELECT ID, adSoyad, telefonNumarasi, adres, cinsiyet, email, müsteriTipi, bakiye FROM müsteriler";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgvmüsteriler.DataSource = dataTable;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            // Müşteri ekleme formunu açmak için gerekli işlemler

            musteriekle Musteriekle = new musteriekle();
            DialogResult result = Musteriekle.ShowDialog();

            if (result == DialogResult.OK)
            {
                müsterileriyukle(); // Form yenilendiğinde müşteri listesini güncelleyin
            }
        }
    }
}
