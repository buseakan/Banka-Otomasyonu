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
    public partial class musteriekle : Form
    {
        // SQL bağlantısı için gerekli bilgileri burada ayarlayın
        private string connectionString = "Data Source = LAPTOP-JVBBL3AB; Database = banka_otomasyonu; Integrated Security = True";

        public musteriekle()
        {
            InitializeComponent();
        }

        

        private void btnGeri_Click(object sender, EventArgs e)
        {
            bankaislemleri Bankaislemleri = new bankaislemleri();
            this.Hide();
            Bankaislemleri.ShowDialog();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ID = txtId.Text;
            string adSoyad = txtAdSoyad.Text;
            string telefonNumarasi = txtTelno.Text;
            string adres = txtAdres.Text;
            string email = txtEmail.Text;
            string cinsiyet = cmbCinsiyet.SelectedItem.ToString();
            string müsteriTipi = rbBireysel.Checked ? "Bireysel" : "Ticari";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Müşteri bilgilerini SQL tablosuna ekleme sorgusu
                    string query = "INSERT INTO müsteriler (ID, adSoyad, telefonNumarasi, adres, email, cinsiyet, müsteriTipi) VALUES (@ID, @adSoyad, @telefonNumarasi, @adres, @email, @cinsiyet, @müsteriTipi)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@adSoyad", adSoyad);
                        command.Parameters.AddWithValue("@telefonNumarasi", telefonNumarasi);
                        command.Parameters.AddWithValue("@adres", adres);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        command.Parameters.AddWithValue("@müsteriTipi", müsteriTipi);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Müşteri başarıyla eklendi.");
                            this.Close();
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
