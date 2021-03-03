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
using System.Data.SqlClient;


namespace SoruBankasi
{
    public partial class FrmResimliSoru : Form
    {
        public FrmResimliSoru()
        {
            InitializeComponent();
            this.Text = "Soru Oluşturma Portalı";
        }
        string resimpath;
        string cressimpath;
        DataBase db = new DataBase();
        private void Ekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ResimCek = new OpenFileDialog();
            ResimCek.Title = "Yüklemek istediğiniz resmi şeçiniz";
            ResimCek.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Png Dosyası(*.png)|*.png";
            if(ResimCek.ShowDialog()==DialogResult.OK)
            {
                Resim.Image = Image.FromFile(ResimCek.FileName);
                resimpath = ResimCek.FileName.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // resim yüklmek
            FileStream fs = new FileStream(resimpath,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            ////
            FileStream cfs = new FileStream(cressimpath, FileMode.Open, FileAccess.Read);
            BinaryReader cbr = new BinaryReader(cfs);
            byte[] cresim = cbr.ReadBytes((int)cfs.Length);
            ///
            br.Close();
            fs.Close();
            cbr.Close();
            cfs.Close();
            // resimleri veri tabanına kayıt et 
            SqlCommand bag = new SqlCommand("insert into ResimliSorular(SoruResim,CevapResim,Konu,AltBaslık,Zorluk,DogruCevap) values( @image,@cimage,@Konu,@AltBaslık,@Zorluk,@DogruCevap)", db.baglanti);
            bag.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
            bag.Parameters.Add("@cimage", SqlDbType.Image, cresim.Length).Value = cresim;
            bag.Parameters.AddWithValue("@Konu", Konu.Text.ToString());
            bag.Parameters.AddWithValue("@AltBaslık", AltBaslık.Text.ToString());
            bag.Parameters.AddWithValue("@Zorluk", Zorluk.Text.ToString());
            bag.Parameters.AddWithValue("@DogruCevap", DogruSık.Text.ToString());

            try
            {
                if (Resim == null || CevapResim == null || Konu.Text == string.Empty || AltBaslık.Text == string.Empty || Zorluk.Text == string.Empty || DogruSık.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.baglanti.Open();
                    bag.ExecuteNonQuery();
                    MessageBox.Show("Soru havuzuna kayıt başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("" + hata);
            }
            finally
            {
                db.baglanti.Close();
            }
        }

        private void REsimCevap_Click(object sender, EventArgs e)
        {
            // resimi çek
            OpenFileDialog cResimCek = new OpenFileDialog();
            cResimCek.Title = "Yüklemek istediğiniz resmi şeçiniz";
            cResimCek.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Png Dosyası(*.png)|*.png";
            if (cResimCek.ShowDialog() == DialogResult.OK)
            {
                CevapResim.Image = Image.FromFile(cResimCek.FileName);
                cressimpath = cResimCek.FileName.ToString();
            }
        }
    }
}
