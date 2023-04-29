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
namespace Proje_Hastane
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        Sqlbaglantisi bgl=new Sqlbaglantisi();
      
        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm= new FrmDoktorPaneli();
            frm.Show();
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frm= new FrmBrans();
            frm.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm= new FrmRandevuListesi();
            frm.Show();
        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
          LblTC.Text = TCnumara;
            SqlCommand komut= new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTC.Text);
           SqlDataReader dr= komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                CmbBrans.Items.Add(dr2[1]);
            }
            bgl.baglanti().Close();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC) values (@r1,@r2,@r3,@r4,@r5)",bgl.baglanti());
            komut4.Parameters.AddWithValue("@r1", MskTarih.Text);
            komut4.Parameters.AddWithValue("@r2",MskSaat.Text);
            komut4.Parameters.AddWithValue("@r3",CmbBrans.Text);
            komut4.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komut4.Parameters.AddWithValue("@r5", MskTC.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@d1",RtbDuyuru.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr= new FrmDuyurular();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler frm= new FrmGirisler();
            frm.Show();
            this.Hide();
        }

    }
}
