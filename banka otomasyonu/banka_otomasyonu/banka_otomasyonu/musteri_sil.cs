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
    public partial class musteri_sil : Form
    {
        // SQL bağlantısı için gerekli bilgileri burada ayarlayın

        private string connectionString = "Data Source = LAPTOP-JVBBL3AB; Database = banka_otomasyonu; Integrated Security = True";

        public musteri_sil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string adSoyad = txtAdSoyad.Text;
            string telefonNumarasi = lblTelefonNumarasi.Text;
            string email = txtEmail.Text;
            string müsteriTipi = rbBireysel.Checked ? "Bireysel" : "Ticari";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Müşteri bilgilerini SQL tablosunndan silme sorgusu

                    string query = "DELETE FROM müsteriler WHERE ID=@id AND adSoyad=@adSoyad AND telefonNumarasi=@telefonNumarasi AND Email=@email AND müsteriTipi=@müsteriTipi";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@adSoyad", adSoyad);
                        command.Parameters.AddWithValue("@telefonNumarasi", telefonNumarasi);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@müsteriTipi", müsteriTipi);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Müşteri başarıyla silindi.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Müşteri bulunamadı veya silme işlemi başarısız oldu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {

            bankaislemleri Bankaislemleri = new bankaislemleri();
            this.Hide();
            Bankaislemleri.ShowDialog();

        }
    }
}
