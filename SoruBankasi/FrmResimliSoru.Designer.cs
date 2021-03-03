namespace SoruBankasi
{
    partial class FrmResimliSoru
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResimliSoru));
            this.Resim = new System.Windows.Forms.PictureBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.CevapResim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DogruSık = new System.Windows.Forms.ComboBox();
            this.Konu = new System.Windows.Forms.ComboBox();
            this.Zorluk = new System.Windows.Forms.ComboBox();
            this.AltBaslık = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.REsimCevap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CevapResim)).BeginInit();
            this.SuspendLayout();
            // 
            // Resim
            // 
            this.Resim.Location = new System.Drawing.Point(12, 38);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(361, 224);
            this.Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resim.TabIndex = 0;
            this.Resim.TabStop = false;
            // 
            // Ekle
            // 
            this.Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ekle.Location = new System.Drawing.Point(114, 9);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(29, 23);
            this.Ekle.TabIndex = 1;
            this.Ekle.Text = "...";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // CevapResim
            // 
            this.CevapResim.Location = new System.Drawing.Point(393, 38);
            this.CevapResim.Name = "CevapResim";
            this.CevapResim.Size = new System.Drawing.Size(395, 224);
            this.CevapResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CevapResim.TabIndex = 0;
            this.CevapResim.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soru Resimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(389, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cevap Resimi:";
            // 
            // DogruSık
            // 
            this.DogruSık.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DogruSık.FormattingEnabled = true;
            this.DogruSık.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.DogruSık.Location = new System.Drawing.Point(70, 268);
            this.DogruSık.Name = "DogruSık";
            this.DogruSık.Size = new System.Drawing.Size(115, 21);
            this.DogruSık.TabIndex = 3;
            // 
            // Konu
            // 
            this.Konu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Konu.FormattingEnabled = true;
            this.Konu.Items.AddRange(new object[] {
            "MATEMATİK",
            "GEOMETRİ"});
            this.Konu.Location = new System.Drawing.Point(70, 295);
            this.Konu.Name = "Konu";
            this.Konu.Size = new System.Drawing.Size(115, 21);
            this.Konu.TabIndex = 3;
            // 
            // Zorluk
            // 
            this.Zorluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Zorluk.FormattingEnabled = true;
            this.Zorluk.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.Zorluk.Location = new System.Drawing.Point(70, 349);
            this.Zorluk.Name = "Zorluk";
            this.Zorluk.Size = new System.Drawing.Size(115, 21);
            this.Zorluk.TabIndex = 3;
            // 
            // AltBaslık
            // 
            this.AltBaslık.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AltBaslık.FormattingEnabled = true;
            this.AltBaslık.Items.AddRange(new object[] {
            "Türev",
            "İntegral"});
            this.AltBaslık.Location = new System.Drawing.Point(70, 322);
            this.AltBaslık.Name = "AltBaslık";
            this.AltBaslık.Size = new System.Drawing.Size(115, 21);
            this.AltBaslık.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doğru Şık:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zorluk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ders:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Alt Başlığı:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(709, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kayıt Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // REsimCevap
            // 
            this.REsimCevap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REsimCevap.Location = new System.Drawing.Point(507, 14);
            this.REsimCevap.Name = "REsimCevap";
            this.REsimCevap.Size = new System.Drawing.Size(30, 23);
            this.REsimCevap.TabIndex = 6;
            this.REsimCevap.Text = "...";
            this.REsimCevap.UseVisualStyleBackColor = true;
            this.REsimCevap.Click += new System.EventHandler(this.REsimCevap_Click);
            // 
            // FrmResimliSoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.REsimCevap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Zorluk);
            this.Controls.Add(this.AltBaslık);
            this.Controls.Add(this.Konu);
            this.Controls.Add(this.DogruSık);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.CevapResim);
            this.Controls.Add(this.Resim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmResimliSoru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmResimliSoru";
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CevapResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Resim;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.PictureBox CevapResim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DogruSık;
        private System.Windows.Forms.ComboBox Konu;
        private System.Windows.Forms.ComboBox Zorluk;
        private System.Windows.Forms.ComboBox AltBaslık;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button REsimCevap;
    }
}