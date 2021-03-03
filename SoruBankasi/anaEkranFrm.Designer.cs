namespace SoruBankasi
{
    partial class anaEkranFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaEkranFrm));
            this.SoruEkle = new System.Windows.Forms.Button();
            this.PdfOlustur = new System.Windows.Forms.Button();
            this.Pdfoku = new System.Windows.Forms.Button();
            this.ResimSorulu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoruEkle
            // 
            this.SoruEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoruEkle.Location = new System.Drawing.Point(45, 32);
            this.SoruEkle.Name = "SoruEkle";
            this.SoruEkle.Size = new System.Drawing.Size(151, 23);
            this.SoruEkle.TabIndex = 0;
            this.SoruEkle.Text = "Soru Ekle";
            this.SoruEkle.UseVisualStyleBackColor = true;
            this.SoruEkle.Click += new System.EventHandler(this.SoruEkle_Click);
            // 
            // PdfOlustur
            // 
            this.PdfOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PdfOlustur.ForeColor = System.Drawing.Color.Black;
            this.PdfOlustur.Location = new System.Drawing.Point(45, 95);
            this.PdfOlustur.Name = "PdfOlustur";
            this.PdfOlustur.Size = new System.Drawing.Size(151, 23);
            this.PdfOlustur.TabIndex = 0;
            this.PdfOlustur.Text = "Pdf Oluştur";
            this.PdfOlustur.UseVisualStyleBackColor = true;
            this.PdfOlustur.Click += new System.EventHandler(this.PdfOlustur_Click);
            // 
            // Pdfoku
            // 
            this.Pdfoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pdfoku.Location = new System.Drawing.Point(45, 124);
            this.Pdfoku.Name = "Pdfoku";
            this.Pdfoku.Size = new System.Drawing.Size(151, 23);
            this.Pdfoku.TabIndex = 1;
            this.Pdfoku.Text = "Pdf Oku";
            this.Pdfoku.UseVisualStyleBackColor = true;
            this.Pdfoku.Click += new System.EventHandler(this.Pdfoku_Click);
            // 
            // ResimSorulu
            // 
            this.ResimSorulu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResimSorulu.Location = new System.Drawing.Point(45, 66);
            this.ResimSorulu.Name = "ResimSorulu";
            this.ResimSorulu.Size = new System.Drawing.Size(151, 23);
            this.ResimSorulu.TabIndex = 2;
            this.ResimSorulu.Text = "Resim Olarak Soru Ekle";
            this.ResimSorulu.UseVisualStyleBackColor = true;
            this.ResimSorulu.Click += new System.EventHandler(this.ResimSorulu_Click);
            // 
            // anaEkranFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(240, 239);
            this.Controls.Add(this.ResimSorulu);
            this.Controls.Add(this.Pdfoku);
            this.Controls.Add(this.PdfOlustur);
            this.Controls.Add(this.SoruEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "anaEkranFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anaEkranFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SoruEkle;
        private System.Windows.Forms.Button PdfOlustur;
        private System.Windows.Forms.Button Pdfoku;
        private System.Windows.Forms.Button ResimSorulu;
    }
}