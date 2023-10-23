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
    public partial class havale : Form
    {
        // SQL bağlantısı için gerekli bilgileri burada ayarlayın

        private string connectionString = "Data Source = LAPTOP-JVBBL3AB; Database = banka_otomasyonu; Integrated Security = True";

        public havale()
        {
            InitializeComponent();
        }

        private void btnParaTransferi_Click(object sender, EventArgs e)
        {
            string gonderenid = txtgonderenid.Text;
            string gonderenadSoyad = txtgonderenadSoyad.Text;
            string aliciId = txtaliciId.Text;
            decimal tutar = decimal.Parse(txtTutar.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Gönderen ve alan müşteri bilgilerini veritabanında güncelleme sorguları
                    string sentQuery = "UPDATE müsteriler SET bakiye= bakiye - @tutar  WHERE ID= @ID AND adSoyad=@adSoyad";
                    string fieldQuery = "UPDATE müsteriler SET bakiye= bakiye + @tutar  WHERE ID= @ID";
                    using (SqlCommand sentCommand = new SqlCommand(sentQuery, connection))
                    using (SqlCommand fieldCommand = new SqlCommand(fieldQuery, connection))

                    {

                        sentCommand.Parameters.AddWithValue("@tutar", tutar);
                        sentCommand.Parameters.AddWithValue("@ID", gonderenid);
                        sentCommand.Parameters.AddWithValue("adSoyad", gonderenadSoyad);

                        fieldCommand.Parameters.AddWithValue("@tutar", tutar);
                        fieldCommand.Parameters.AddWithValue("@ID", aliciId);



                        int rowsAffectedsent = sentCommand.ExecuteNonQuery();
                        int rowsAffectedfield = fieldCommand.ExecuteNonQuery();

                        if (rowsAffectedsent > 0 && rowsAffectedfield > 0)
                        {
                            MessageBox.Show("Para transferi başarılı.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hesap bilgileri bulunamadı veya para transferi işlemi başarısız oldu.");
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
