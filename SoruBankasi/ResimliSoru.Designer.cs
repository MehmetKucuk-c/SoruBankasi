namespace SoruBankasi
{
    partial class ResimliSoru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResimliSoru));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnYazıdr = new System.Windows.Forms.Button();
            this.QR = new System.Windows.Forms.Button();
            this.QrCode = new System.Windows.Forms.PictureBox();
            this.CevapYaz = new System.Windows.Forms.Button();
            this.CevapKagit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CevapKagit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(828, 1239);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnYazıdr
            // 
            this.BtnYazıdr.BackColor = System.Drawing.Color.Green;
            this.BtnYazıdr.Location = new System.Drawing.Point(764, 12);
            this.BtnYazıdr.Name = "BtnYazıdr";
            this.BtnYazıdr.Size = new System.Drawing.Size(75, 23);
            this.BtnYazıdr.TabIndex = 1;
            this.BtnYazıdr.Text = "Yazıdır";
            this.BtnYazıdr.UseVisualStyleBackColor = false;
            this.BtnYazıdr.Click += new System.EventHandler(this.BtnYazıdr_Click);
            // 
            // QR
            // 
            this.QR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.QR.Location = new System.Drawing.Point(602, 12);
            this.QR.Name = "QR";
            this.QR.Size = new System.Drawing.Size(75, 23);
            this.QR.TabIndex = 2;
            this.QR.Text = "QR Kod ";
            this.QR.UseVisualStyleBackColor = false;
            this.QR.Click += new System.EventHandler(this.QR_Click);
            // 
            // QrCode
            // 
            this.QrCode.Location = new System.Drawing.Point(776, 41);
            this.QrCode.Name = "QrCode";
            this.QrCode.Size = new System.Drawing.Size(63, 63);
            this.QrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QrCode.TabIndex = 3;
            this.QrCode.TabStop = false;
            // 
            // CevapYaz
            // 
            this.CevapYaz.BackColor = System.Drawing.Color.Yellow;
            this.CevapYaz.Location = new System.Drawing.Point(683, 12);
            this.CevapYaz.Name = "CevapYaz";
            this.CevapYaz.Size = new System.Drawing.Size(75, 23);
            this.CevapYaz.TabIndex = 4;
            this.CevapYaz.Text = "Cevaplar";
            this.CevapYaz.UseVisualStyleBackColor = false;
            this.CevapYaz.Click += new System.EventHandler(this.CevapYaz_Click);
            // 
            // CevapKagit
            // 
            this.CevapKagit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CevapKagit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CevapKagit.Location = new System.Drawing.Point(11, 41);
            this.CevapKagit.Name = "CevapKagit";
            this.CevapKagit.Size = new System.Drawing.Size(828, 1239);
            this.CevapKagit.TabIndex = 5;
            this.CevapKagit.TabStop = false;
            // 
            // ResimliSoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(851, 1045);
            this.Controls.Add(this.CevapYaz);
            this.Controls.Add(this.QrCode);
            this.Controls.Add(this.QR);
            this.Controls.Add(this.BtnYazıdr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CevapKagit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResimliSoru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResimliSoru";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CevapKagit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnYazıdr;
        private System.Windows.Forms.Button QR;
        private System.Windows.Forms.PictureBox QrCode;
        private System.Windows.Forms.Button CevapYaz;
        private System.Windows.Forms.PictureBox CevapKagit;
    }
}