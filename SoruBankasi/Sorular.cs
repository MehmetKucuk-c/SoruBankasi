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

namespace SoruBankasi
{
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
            this.Text = "Soru Oluşturma Portalı";
        }
        DataBase db = new DataBase();
        private void SoruyuKaydet_Click(object sender, EventArgs e)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into sorular values(@soru,@Asıkkı,@Bsıkkı,@Csıkkı,@Dsıkkı,@Esıkkı,@DogruCevap,@Zorluk,@AltBaslik,@Konu)", db.baglanti);
                ekle.Parameters.AddWithValue("@soru", soru.Text.ToString());
                ekle.Parameters.AddWithValue("@Asıkkı", Asıkkı.Text.ToString());
                ekle.Parameters.AddWithValue("@Bsıkkı", Bsıkkı.Text.ToString());
                ekle.Parameters.AddWithValue("@Csıkkı", Csıkkı.Text.ToString());
                ekle.Parameters.AddWithValue("@Dsıkkı", Dsıkkı.Text.ToString());
                ekle.Parameters.AddWithValue("@Esıkkı", Esıkkı.Text.ToString());
                ekle.Parameters.AddWithValue("@DogruCevap", DogruCevap.Text.ToString());
                ekle.Parameters.AddWithValue("@Zorluk", Zorluk.Text.ToString());
                ekle.Parameters.AddWithValue("@AltBaslik", comboBox1.Text.ToString());
                ekle.Parameters.AddWithValue("@Konu", comboBox2.Text.ToString());
                ekle.ExecuteNonQuery();
                MessageBox.Show("Soru " + Zorluk.Text.ToString() + " dereceli zorluk seviyesine kayıt edilmiştir.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ekle.Dispose();
                //Text ve combobox boşaltma
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox )
                    {
                        item.Text = "";
                    }
                    if(item is ComboBox)
                    {
                        item.Text = "";
                    }
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
    }
}
