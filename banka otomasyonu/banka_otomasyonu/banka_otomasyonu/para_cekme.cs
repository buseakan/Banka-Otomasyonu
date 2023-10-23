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
    public partial class para_cekme : Form
    {
        // SQL bağlantısı için gerekli bilgileri burada ayarlayın
        private string connectionString = " Data Source = LAPTOP-JVBBL3AB; Database = banka_otomasyonu; Integrated Security = True";

        public para_cekme()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            hesapislemleri Hesapislemleri = new hesapislemleri();
            this.Hide();
           Hesapislemleri.ShowDialog();
        }

        private void btnParacekme_Click(object sender, EventArgs e)
        {

            string id = txtId.Text;
            string adSoyad = txtadSoyad.Text;
            decimal cekilecektutar = decimal.Parse(txtTutar.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Müşteri bilgilerine göre veritabanında veritabanında bakiye güncellenme sorgusu
                    string query = "UPDATE musteriler SET bakiye= bakiye - @cekilecektutar WHERE ID= @id AND adSoyad=@adSoyad";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@cekilecektutar", cekilecektutar);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@adSoyad", adSoyad);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Para başarıyla çekildi.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hesap bulunamadı veya para çekme işlemi başarısız.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


    }
}

