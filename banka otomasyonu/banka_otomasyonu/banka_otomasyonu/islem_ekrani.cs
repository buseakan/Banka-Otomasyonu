using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_otomasyonu
{
    public partial class islem_ekrani : Form
    {
        private string kullaniciAdi;
        public islem_ekrani(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
        }

        private void btnBankaislemleri_Click(object sender, EventArgs e)
        {
            bankaislemleri Bankaislemleri = new bankaislemleri();
            Bankaislemleri.Show();
            this.Hide();
        }

        private void btnHesapislemleri_Click(object sender, EventArgs e)
        {
            hesapislemleri Hesapislemleri = new hesapislemleri();
            Hesapislemleri.Show();
            this.Hide();
        }

        private void islem_ekrani_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = "Hoşgeldiniz Sayın," + kullaniciAdi + "!";
        }
    }
}
