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
    public partial class Seviye : Form
    {
        public Seviye()
        {
            InitializeComponent();
            this.Text = "Soru Oluşturma Portalı";
        }

        private void Onay_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            if(CmbSeviye.Text==string.Empty||SecimYap.Text==string.Empty || DErs.Text==string.Empty || AltKonu.Text==string.Empty)
            {
                MessageBox.Show("Lütfen tüm seçimleri yapınız.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (SecimYap.Text == "Soru")
                {
                    frm.SoruOlustur(CmbSeviye.Text,DErs.Text,AltKonu.Text);
                    frm.Show();
                    this.Hide();  
                }
                else
                {
                    ResimliSoru rs = new ResimliSoru();
                    rs.ResimliSoruOlustur(CmbSeviye.Text,DErs.Text,AltKonu.Text);
                    rs.Show();
                    this.Hide();
                }
            }
        }
    }
}
