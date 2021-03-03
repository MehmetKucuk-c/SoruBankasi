namespace SoruBankasi
{
    partial class Seviye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seviye));
            this.CmbSeviye = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.onay = new System.Windows.Forms.Button();
            this.SecimYap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DErs = new System.Windows.Forms.ComboBox();
            this.AltKonu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CmbSeviye
            // 
            this.CmbSeviye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSeviye.FormattingEnabled = true;
            this.CmbSeviye.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.CmbSeviye.Location = new System.Drawing.Point(107, 50);
            this.CmbSeviye.Name = "CmbSeviye";
            this.CmbSeviye.Size = new System.Drawing.Size(121, 21);
            this.CmbSeviye.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Zorluk:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sınavınızn soru zorluk seviyenizi seçiniz lütfen.";
            // 
            // onay
            // 
            this.onay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.onay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onay.Location = new System.Drawing.Point(153, 161);
            this.onay.Name = "onay";
            this.onay.Size = new System.Drawing.Size(75, 23);
            this.onay.TabIndex = 6;
            this.onay.Text = "Onayla";
            this.onay.UseVisualStyleBackColor = true;
            this.onay.Click += new System.EventHandler(this.Onay_Click);
            // 
            // SecimYap
            // 
            this.SecimYap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecimYap.FormattingEnabled = true;
            this.SecimYap.Items.AddRange(new object[] {
            "Image Soru",
            "Soru"});
            this.SecimYap.Location = new System.Drawing.Point(107, 77);
            this.SecimYap.Name = "SecimYap";
            this.SecimYap.Size = new System.Drawing.Size(121, 21);
            this.SecimYap.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soru Tipi Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ders:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alt Başlık";
            // 
            // DErs
            // 
            this.DErs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DErs.FormattingEnabled = true;
            this.DErs.Items.AddRange(new object[] {
            "MATEMATİK",
            "GEOMETRİ"});
            this.DErs.Location = new System.Drawing.Point(107, 107);
            this.DErs.Name = "DErs";
            this.DErs.Size = new System.Drawing.Size(121, 21);
            this.DErs.TabIndex = 11;
            // 
            // AltKonu
            // 
            this.AltKonu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AltKonu.FormattingEnabled = true;
            this.AltKonu.Items.AddRange(new object[] {
            "Türev",
            "İntegral"});
            this.AltKonu.Location = new System.Drawing.Point(107, 134);
            this.AltKonu.Name = "AltKonu";
            this.AltKonu.Size = new System.Drawing.Size(121, 21);
            this.AltKonu.TabIndex = 11;
            // 
            // Seviye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(257, 192);
            this.Controls.Add(this.AltKonu);
            this.Controls.Add(this.DErs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecimYap);
            this.Controls.Add(this.onay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSeviye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Seviye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seviye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button onay;
        public System.Windows.Forms.ComboBox CmbSeviye;
        private System.Windows.Forms.ComboBox SecimYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DErs;
        private System.Windows.Forms.ComboBox AltKonu;
    }
}