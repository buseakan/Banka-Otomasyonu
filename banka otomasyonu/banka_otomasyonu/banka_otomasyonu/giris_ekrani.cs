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
    public partial class giris_ekrani : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source = LAPTOP-JVBBL3AB; Database = banka_otomasyonu; Integrated Security = True";
        public giris_ekrani()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (ConfirmUser(kullaniciAdi, sifre))
            {
                /* MessageBox.Show("Giriş başarılı! İşlem ekranına yönlendiriliyorsunuz."); */

                islem_ekrani İslemekrani = new islem_ekrani(kullaniciAdi);
                this.Hide();
                İslemekrani.ShowDialog();
            }
            else if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }
      

        private bool ConfirmUser(string kullaniciAdi, string sifre)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM yetkililer WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre", connection);
                command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("@sifre", sifre);
                int result = (int)command.ExecuteScalar();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
            }
            else if (checkBox.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
        }
            private void linklblSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifre_degistir SifreDegistir = new sifre_degistir();
            SifreDegistir.Show();
            this.Hide();
        }

    }
}
