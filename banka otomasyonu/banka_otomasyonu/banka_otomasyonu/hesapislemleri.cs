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
    public partial class hesapislemleri : Form
    {
        public hesapislemleri()
        {
            InitializeComponent();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (rbParaYatirma.Checked)
            {
                para_yatirma Parayatirma = new para_yatirma();
                Parayatirma.Show();
            }
            else if (rbParaCekme.Checked)
            {
                para_cekme Withdrawals = new para_cekme();
                Withdrawals.Show();
            }
            else if (rbHavale.Checked)
            {
                havale Havale = new havale();
                Havale.Show();
            }
            else if (rbBakiyeGoruntule.Checked)
            {
                bakiye_goruntule BakiyeGoruntule = new bakiye_goruntule();
                BakiyeGoruntule.Show();
            }
            else if (rbHesabiSil.Checked)
            {
                hesap_kapat HesabiKapat = new hesap_kapat();
                HesabiKapat.Show();
            }
        }

       /* private void btngeri_Click(object sender, EventArgs e)
        {
            islem_ekrani İslemekrani = new islem_ekrani();
            this.Hide();
            İslemekrani.ShowDialog();
        } */
    }
}
