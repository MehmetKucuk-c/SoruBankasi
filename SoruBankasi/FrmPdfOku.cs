using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoruBankasi
{
    public partial class FrmPdfOku : Form
    {
        public FrmPdfOku()
        {
            InitializeComponent();
            this.Text = "PDF Okuyucu";
        }

        private void Okupdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdfac = new OpenFileDialog();
            pdfac.Title = "PDF Aç";
            pdfac.Filter = "PDF Dosyaları(*.Pdf | *.Pdf";
            if(pdfac.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = pdfac.FileName;
                axAcroPDF1.LoadFile(pdfac.FileName);
            }
        }
    }
}
