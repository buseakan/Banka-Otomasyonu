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
    public partial class bankaislemleri : Form
    {
        public bankaislemleri()
        {
            InitializeComponent();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (rbMusteriekle.Checked)
            {
                musteriekle MusteriEkle = new musteriekle();
                MusteriEkle.Show();
            }
            else if (rbMusterisil.Checked)
            {
                musteri_sil MusteriSil = new musteri_sil();
                MusteriSil.Show();
            }
            else if (rbMusteriler.Checked)
            {
                musteriler Musteriler = new musteriler();
                Musteriler.Show();
            }
        }

    }
}
