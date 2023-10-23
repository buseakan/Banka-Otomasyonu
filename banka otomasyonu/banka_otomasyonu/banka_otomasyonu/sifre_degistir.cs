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
    public partial class sifre_degistir : Form
    {
        // SQL bağlantısı için gerekli bilgileri burada ayarlayın
        private string connectionString = "Data Source = LAPTOP-JVBBL3AB; Database = banka_otomasyonu; Integrated Security = True";

        public sifre_degistir()
        {
            InitializeComponent();

        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtYeniSifre.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı adına göre veritabanında şifrenin güncellenmesi sorgusu
                    string query = "UPDATE yetkililer SET sifre= @sifre WHERE kullaniciAdi=@kullaniciAdi";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@sifre", sifre);
                        command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Şifre başarıyla güncellendi");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı bulunamadı veya parola güncelleme işlemi başarısız oldu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. " + ex.Message);
            }
        }

        private void btngerigit_Click(object sender, EventArgs e)
        {
            giris_ekrani Girisekrani = new giris_ekrani();
            this.Hide();
            Girisekrani.ShowDialog();
        }
    }
}
