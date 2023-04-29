namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.BtnHastaKayit = new System.Windows.Forms.Button();
            this.MskKayitTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtKayitSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.MskKayitTC = new System.Windows.Forms.MaskedTextBox();
            this.CmbKayitCinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnHastaKayit
            // 
            this.BtnHastaKayit.Location = new System.Drawing.Point(205, 298);
            this.BtnHastaKayit.Name = "BtnHastaKayit";
            this.BtnHastaKayit.Size = new System.Drawing.Size(174, 38);
            this.BtnHastaKayit.TabIndex = 12;
            this.BtnHastaKayit.Text = "Kayıt Ol";
            this.BtnHastaKayit.UseVisualStyleBackColor = true;
            this.BtnHastaKayit.Click += new System.EventHandler(this.BtnHastaKayit_Click);
            // 
            // MskKayitTelefon
            // 
            this.MskKayitTelefon.Location = new System.Drawing.Point(205, 171);
            this.MskKayitTelefon.Mask = "(999) 000-0000";
            this.MskKayitTelefon.Name = "MskKayitTelefon";
            this.MskKayitTelefon.Size = new System.Drawing.Size(174, 36);
            this.MskKayitTelefon.TabIndex = 4;
            // 
            // TxtKayitSifre
            // 
            this.TxtKayitSifre.Location = new System.Drawing.Point(205, 213);
            this.TxtKayitSifre.Name = "TxtKayitSifre";
            this.TxtKayitSifre.Size = new System.Drawing.Size(174, 36);
            this.TxtKayitSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad:";
         //   this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Şifre:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(205, 45);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(174, 36);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(205, 87);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(174, 36);
            this.TxtSoyad.TabIndex = 2;
            // 
            // MskKayitTC
            // 
            this.MskKayitTC.Location = new System.Drawing.Point(205, 129);
            this.MskKayitTC.Mask = "00000000000";
            this.MskKayitTC.Name = "MskKayitTC";
            this.MskKayitTC.Size = new System.Drawing.Size(174, 36);
            this.MskKayitTC.TabIndex = 3;
            // 
            // CmbKayitCinsiyet
            // 
            this.CmbKayitCinsiyet.FormattingEnabled = true;
            this.CmbKayitCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CmbKayitCinsiyet.Location = new System.Drawing.Point(205, 256);
            this.CmbKayitCinsiyet.Name = "CmbKayitCinsiyet";
            this.CmbKayitCinsiyet.Size = new System.Drawing.Size(174, 36);
            this.CmbKayitCinsiyet.TabIndex = 6;
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnHastaKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 357);
            this.Controls.Add(this.CmbKayitCinsiyet);
            this.Controls.Add(this.MskKayitTC);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHastaKayit);
            this.Controls.Add(this.MskKayitTelefon);
            this.Controls.Add(this.TxtKayitSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
           // this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaKayit;
        private System.Windows.Forms.MaskedTextBox MskKayitTelefon;
        private System.Windows.Forms.TextBox TxtKayitSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.MaskedTextBox MskKayitTC;
        private System.Windows.Forms.ComboBox CmbKayitCinsiyet;
    }
}