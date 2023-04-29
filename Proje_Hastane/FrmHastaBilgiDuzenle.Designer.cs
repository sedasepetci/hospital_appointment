namespace Proje_Hastane
{
    partial class FrmHastaBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgiDuzenle));
            this.CmbKayitCinsiyet = new System.Windows.Forms.ComboBox();
            this.MskKayitTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHastaKayit = new System.Windows.Forms.Button();
            this.MskKayitTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtKayitSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbKayitCinsiyet
            // 
            this.CmbKayitCinsiyet.FormattingEnabled = true;
            this.CmbKayitCinsiyet.Location = new System.Drawing.Point(202, 246);
            this.CmbKayitCinsiyet.Name = "CmbKayitCinsiyet";
            this.CmbKayitCinsiyet.Size = new System.Drawing.Size(174, 32);
            this.CmbKayitCinsiyet.TabIndex = 33;
            // 
            // MskKayitTC
            // 
            this.MskKayitTC.Location = new System.Drawing.Point(202, 119);
            this.MskKayitTC.Mask = "00000000000";
            this.MskKayitTC.Name = "MskKayitTC";
            this.MskKayitTC.Size = new System.Drawing.Size(174, 32);
            this.MskKayitTC.TabIndex = 32;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(202, 77);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(174, 32);
            this.TxtSoyad.TabIndex = 31;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(202, 35);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(174, 32);
            this.TxtAd.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Soyad:";
            // 
            // BtnHastaKayit
            // 
            this.BtnHastaKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnHastaKayit.Location = new System.Drawing.Point(202, 288);
            this.BtnHastaKayit.Name = "BtnHastaKayit";
            this.BtnHastaKayit.Size = new System.Drawing.Size(174, 38);
            this.BtnHastaKayit.TabIndex = 25;
            this.BtnHastaKayit.Text = "Güncelle";
            this.BtnHastaKayit.UseVisualStyleBackColor = false;
            this.BtnHastaKayit.Click += new System.EventHandler(this.BtnHastaKayit_Click);
            // 
            // MskKayitTelefon
            // 
            this.MskKayitTelefon.Location = new System.Drawing.Point(202, 161);
            this.MskKayitTelefon.Mask = "(999) 000-0000";
            this.MskKayitTelefon.Name = "MskKayitTelefon";
            this.MskKayitTelefon.Size = new System.Drawing.Size(174, 32);
            this.MskKayitTelefon.TabIndex = 24;
            // 
            // TxtKayitSifre
            // 
            this.TxtKayitSifre.Location = new System.Drawing.Point(202, 203);
            this.TxtKayitSifre.Name = "TxtKayitSifre";
            this.TxtKayitSifre.Size = new System.Drawing.Size(174, 32);
            this.TxtKayitSifre.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "TC Kimlik No:";
            // 
            // FrmHastaBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 377);
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
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbKayitCinsiyet;
        private System.Windows.Forms.MaskedTextBox MskKayitTC;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHastaKayit;
        private System.Windows.Forms.MaskedTextBox MskKayitTelefon;
        private System.Windows.Forms.TextBox TxtKayitSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}