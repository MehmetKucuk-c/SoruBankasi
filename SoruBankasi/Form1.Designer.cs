namespace SoruBankasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pdfoku = new System.Windows.Forms.Button();
            this.yazar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.olusturucu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.konu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.anahtar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(873, 622);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // pdfoku
            // 
            this.pdfoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdfoku.Location = new System.Drawing.Point(1099, 655);
            this.pdfoku.Name = "pdfoku";
            this.pdfoku.Size = new System.Drawing.Size(96, 33);
            this.pdfoku.TabIndex = 1;
            this.pdfoku.Text = "PDF Yazdır";
            this.pdfoku.UseVisualStyleBackColor = true;
            this.pdfoku.Click += new System.EventHandler(this.Pdfoku_Click);
            // 
            // yazar
            // 
            this.yazar.Location = new System.Drawing.Point(1024, 66);
            this.yazar.Name = "yazar";
            this.yazar.Size = new System.Drawing.Size(171, 20);
            this.yazar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yazar";
            // 
            // olusturucu
            // 
            this.olusturucu.Location = new System.Drawing.Point(1024, 88);
            this.olusturucu.Name = "olusturucu";
            this.olusturucu.Size = new System.Drawing.Size(171, 20);
            this.olusturucu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(931, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oluşturucu";
            // 
            // konu
            // 
            this.konu.Location = new System.Drawing.Point(1024, 114);
            this.konu.Name = "konu";
            this.konu.Size = new System.Drawing.Size(171, 20);
            this.konu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(931, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Konu";
            // 
            // anahtar
            // 
            this.anahtar.Location = new System.Drawing.Point(1024, 140);
            this.anahtar.Name = "anahtar";
            this.anahtar.Size = new System.Drawing.Size(171, 20);
            this.anahtar.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(931, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Anahtar Kelime";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1207, 700);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anahtar);
            this.Controls.Add(this.konu);
            this.Controls.Add(this.olusturucu);
            this.Controls.Add(this.yazar);
            this.Controls.Add(this.pdfoku);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button pdfoku;
        private System.Windows.Forms.TextBox yazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox olusturucu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox konu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox anahtar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

