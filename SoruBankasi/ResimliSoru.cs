using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;
using MessagingToolkit.QRCode.Codec;

namespace SoruBankasi
{
    public partial class ResimliSoru : Form
    {
        
        public ImageList sor = new ImageList();
        public  ImageList cevap = new ImageList();
        public ResimliSoru()
        {
            InitializeComponent();
            this.Text = "Sınav Kağıdı";
        }
        public void ResimliSoruOlustur(string zorluk_seviye,string ders,string Altkonu)
        {
            QrCode.Visible = false;
            DataBase db = new DataBase();
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                sor.ImageSize = new Size(256, 190);
                sor.ColorDepth = ColorDepth.Depth32Bit;
                cevap.ImageSize = new Size(256, 190);
                cevap.ColorDepth = ColorDepth.Depth32Bit;
                db.baglanti.Open();
                // not burayı kullanıcı giricek
                for (int i = 0; i < 18; i++)
                {
                    // resimleri çekiyoruz
                    SqlCommand listele = new SqlCommand("SELECT TOP 1 * FROM ResimliSorular where Zorluk=@Zorluk and Konu=@Konu and AltBaslık=@AltBaslık  ORDER BY NEWID() ", db.baglanti);
                    listele.Parameters.AddWithValue("@Zorluk", zorluk_seviye.ToString());
                    listele.Parameters.AddWithValue("@Konu", ders.ToString());
                    listele.Parameters.AddWithValue("@AltBaslık", Altkonu.ToString());
                    SqlDataReader ListeOku = listele.ExecuteReader();
                    while (ListeOku.Read())
                    {
                        byte[] ResimliSorular = (byte[])ListeOku[1];//1. indise soru 2. indise cevap kayıt oluyor
                        MemoryStream ms = new MemoryStream();
                        ms.Write(ResimliSorular, 0, ResimliSorular.Length);
                        sor.Images.Add(Image.FromStream(ms));
                        //
                        byte[] ResimliCevap = (byte[])ListeOku[2];
                        MemoryStream mc = new MemoryStream();
                        mc.Write(ResimliCevap, 0, ResimliCevap.Length);
                        cevap.Images.Add(Image.FromStream(mc));
                    }
                }
                //Resimleri pictureBox yazıdırıyorum
                int x = 20;
                int y = 20;
                int maxHeight= -1;
                for (int j=0; j < 18; j++)
                {
                    PictureBox pic = new PictureBox
                    {
                        Image = sor.Images[j],
                        Location = new Point(x-20, y-20),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(256, 185)
                    };
                    x += pic.Width + 1;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if(x>this.ClientSize.Width-185)
                    {
                        x = 20;
                        y += maxHeight + 1;
                    }
                    this.pictureBox1.Controls.Add(pic);
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
        //buton yazıdrma işlemi
        private void BtnYazıdr_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            //doc.PrintPage+= yaz  TAB bas
            doc.PrintPage += Doc_PrintPage;
            doc.DocumentName = "Sınav";
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        //yazdırma işleme 
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 10, 10);
            bm.Dispose();

        }
        //QR Code
        private void QR_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encode = new QRCodeEncoder();
            //yt = pictureBox1.Image;
            QrCode.Image = encode.Encode("Örnek site veya Örnek url girilicek");
            QrCode.Visible = true;
        }

        private void CevapYaz_Click(object sender, EventArgs e)
        {
            int x = 20;
            int y = 20;
            int maxHeight = -1;
            for (int k = 0; k < 18; k++)
            {
                PictureBox picCevap = new PictureBox
                {
                    Image = cevap.Images[k],
                    Location = new Point(x-20, y-20),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(256, 185)
                };
                x += picCevap.Width + 1;
                maxHeight = Math.Max(picCevap.Height, maxHeight);
                if (x > this.ClientSize.Width - 185)
                {
                    x = 20;
                    y += maxHeight + 1;
                }
                this.CevapKagit.Controls.Add(picCevap);
            }
            pictureBox1.Visible = false;
            PrintDialog pc = new PrintDialog();
            PrintDocument docCevap = new PrintDocument();
            //doc.PrintPage+= yaz  TAB bas
            docCevap.PrintPage += DocCevap_PrintPage;
            docCevap.DocumentName = "Cevap Anahtarı";
            pc.Document = docCevap;
            if (pc.ShowDialog() == DialogResult.OK)
            {
                docCevap.Print();
            }
        }

        private void DocCevap_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bc = new Bitmap(CevapKagit.Width, CevapKagit.Height);
            CevapKagit.DrawToBitmap(bc, new Rectangle(0, 0, CevapKagit.Width, CevapKagit.Height));
            e.Graphics.DrawImage(bc, 10, 10);
            bc.Dispose();
        }
    }
}