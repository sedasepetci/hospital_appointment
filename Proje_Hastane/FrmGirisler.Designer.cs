namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSekreter = new System.Windows.Forms.Button();
            this.BtnDoktor = new System.Windows.Forms.Button();
            this.BtnHasta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sea Green Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proje_Hastane.Properties.Resources.heart1;
            this.pictureBox1.Location = new System.Drawing.Point(339, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSekreter
            // 
            this.BtnSekreter.BackColor = System.Drawing.Color.Silver;
            this.BtnSekreter.BackgroundImage = global::Proje_Hastane.Properties.Resources.sekreter;
            this.BtnSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreter.Location = new System.Drawing.Point(404, 148);
            this.BtnSekreter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSekreter.Name = "BtnSekreter";
            this.BtnSekreter.Size = new System.Drawing.Size(112, 98);
            this.BtnSekreter.TabIndex = 2;
            this.BtnSekreter.UseVisualStyleBackColor = false;
            this.BtnSekreter.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnDoktor
            // 
            this.BtnDoktor.BackColor = System.Drawing.Color.Silver;
            this.BtnDoktor.BackgroundImage = global::Proje_Hastane.Properties.Resources.doktor;
            this.BtnDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktor.Location = new System.Drawing.Point(232, 148);
            this.BtnDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDoktor.Name = "BtnDoktor";
            this.BtnDoktor.Size = new System.Drawing.Size(112, 98);
            this.BtnDoktor.TabIndex = 1;
            this.BtnDoktor.UseVisualStyleBackColor = false;
            this.BtnDoktor.Click += new System.EventHandler(this.BtnDoktor_Click);
            // 
            // BtnHasta
            // 
            this.BtnHasta.BackColor = System.Drawing.Color.Silver;
            this.BtnHasta.BackgroundImage = global::Proje_Hastane.Properties.Resources.patient;
            this.BtnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHasta.Location = new System.Drawing.Point(57, 148);
            this.BtnHasta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHasta.Name = "BtnHasta";
            this.BtnHasta.Size = new System.Drawing.Size(112, 98);
            this.BtnHasta.TabIndex = 0;
            this.BtnHasta.UseVisualStyleBackColor = false;
            this.BtnHasta.Click += new System.EventHandler(this.BtnHasta_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(585, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreter);
            this.Controls.Add(this.BtnDoktor);
            this.Controls.Add(this.BtnHasta);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Sea Green Hospital Giriş";
          //  this.Load += new System.EventHandler(this.FrmGirisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHasta;
        private System.Windows.Forms.Button BtnDoktor;
        private System.Windows.Forms.Button BtnSekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

