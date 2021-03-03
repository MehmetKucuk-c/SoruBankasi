using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruBankasi
{
    public partial class anaEkranFrm : Form
    {
        public anaEkranFrm()
        {
            InitializeComponent();
            this.Text = "Soru Bankası";
        }

        private void SoruEkle_Click(object sender, EventArgs e)
        {
            Sorular soru = new Sorular();
            soru.Show();
            this.Hide();
        }

        private void PdfOlustur_Click(object sender, EventArgs e)
        {
            Seviye Sev = new Seviye();
            Sev.Show();
            this.Hide();
        }

        private void Pdfoku_Click(object sender, EventArgs e)
        {
            FrmPdfOku pf = new FrmPdfOku();
            pf.Show();
            this.Hide();
        }

        private void ResimSorulu_Click(object sender, EventArgs e)
        {
            FrmResimliSoru resim = new FrmResimliSoru();
            resim.Show();
            this.Hide();
        }
    }
}
