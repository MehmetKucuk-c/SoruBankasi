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
using iTextSharp.text.pdf;
using iTextSharp.text;
using Image = System.Drawing.Image;

namespace SoruBankasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "PDF Soru Oluşturucu";
        }
        List<string> sorular = new List<string>();
        public string ceksoru { set; get; }
        public string asıkkı { set; get; }
        public string bsıkkı { set; get; }
        public string csıkkı { set; get; }
        public string dsıkkı { set; get; }
        public string esıkkı { set; get; }
        public string cevap { set; get; }
        
        DataBase db = new DataBase();
        public void SoruOlustur(string zorluk_seviyesi,string ders,string altKonu)
        {
            
            if(db.baglanti.State==ConnectionState.Open)
            {
                db.baglanti.Close();
            }

            try
            {
                
                

                    for (int i = 0; i <= 4; i++)
                    {
                        db.baglanti.Open();
                        //Rastgele soru cekiliyor
                        SqlCommand SoruCek = new SqlCommand("SELECT TOP 1 * FROM sorular where Zorluk = @Zorluk and Konu=@Konu and AltBaslik=@AltBaslik  ORDER BY NEWID()", db.baglanti);
                        SoruCek.Parameters.AddWithValue("@Zorluk", zorluk_seviyesi.ToString());
                        SoruCek.Parameters.AddWithValue("@Konu", ders.ToString());
                        SoruCek.Parameters.AddWithValue("@AltBaslik", altKonu.ToString());
                        SqlDataReader SoruOku = SoruCek.ExecuteReader();
                        while (SoruOku.Read())
                        {
                            // kont.Add(ceksoru = SoruOku["Soru"].ToString());
                            ceksoru = SoruOku["Soru"].ToString();
                            asıkkı = SoruOku["Asıkkı"].ToString();
                            bsıkkı = SoruOku["Bsıkkı"].ToString();
                            csıkkı = SoruOku["Csıkkı"].ToString();
                            dsıkkı = SoruOku["Dsıkkı"].ToString();
                            esıkkı = SoruOku["Esıkkı"].ToString();
                            cevap = SoruOku["DogruCevap"].ToString();
                        }

                        //list e soru atılıyor.
                        sorular.Add(ceksoru + Environment.NewLine + asıkkı + "          " + bsıkkı + "          " + csıkkı + Environment.NewLine + dsıkkı + "           " + esıkkı + Environment.NewLine);
                        db.baglanti.Close();
                    }
                    //richbox listen soru yazılıyor
                    int j = 0;


                    foreach (var sor in sorular)
                    {
                        richTextBox1.AppendText(j + 1 + ".Soru:" + Environment.NewLine + sor + Environment.NewLine);
                        j++;

                    }

                ///*db.baglanti.Open();*/
                //SqlCommand listele = new SqlCommand("SELECT TOP 1 * FROM ResimliSorular where Zorluk = @Zorluk  ORDER BY NEWID()", db.baglanti);
                //listele.Parameters.AddWithValue("@Zorluk", zorluk_seviyesi.ToString());
                //SqlDataReader ListeOku = listele.ExecuteReader();

                //while (ListeOku.Read())
                //{
                //    byte[] ResimliSorular = (byte[])ListeOku[1];
                //    MemoryStream ms = new MemoryStream();
                //    ms.Write(ResimliSorular, 0, ResimliSorular.Length);
                //    pictureBox1.Image = Image.FromStream(ms);
                //}


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

        private void Pdfoku_Click(object sender, EventArgs e)
        {
            //türkçe karekter oluşturma
            BaseFont STF_Helvetica_Turkish = BaseFont.CreateFont("Helvetica", "CP1254",BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);
            //PDF oluşturma
            Document rapor = new Document();
            PdfWriter.GetInstance(rapor, new FileStream("C:Sorubankası.Pdf", FileMode.Create));
            rapor.AddAuthor(yazar.Text);
            rapor.AddCreationDate();
            rapor.AddCreator(olusturucu.Text);
            rapor.AddSubject(konu.Text);
            rapor.AddKeywords(anahtar.Text);
            if(rapor.IsOpen()==false)
            {
                rapor.Open();
            }
            rapor.Add(new Paragraph(richTextBox1.Text,fontNormal));
            MessageBox.Show("PDF Oluştruldu","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            rapor.Close();
        }
    }
}