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
    public partial class hesap_kapat : Form
    {
        // SQL bağlantısı için gerekli bilgileri burada ayarlayın

        private string connectionString = "Data Source = LAPTOP-JVBBL3AB; Database = banka_otomasyonu; Integrated Security = True";

        public hesap_kapat()
        {
            InitializeComponent();
        }

        private void btnhesapkapat_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string adSoyad = txtadSoyad.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Müşteriyi veritabanından silme sorgusu
                    string query = "DELETE FROM musteriler WHERE ID= @id AND adSoyad=@adSoyad";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@adSoyad", adSoyad);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Hesap başarıyla kapatıldı.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hesap bilgileri bulunamadı veya hesap kapatma işlemi başarısız oldu.");
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
