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
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TC;
        Sqlbaglantisi bgl=new Sqlbaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskKayitTC.Text = TC;
            SqlCommand komut=new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskKayitTC.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                TxtAd.Text =dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskKayitTelefon.Text = dr[4].ToString();
                TxtKayitSifre.Text = dr[5].ToString();
                CmbKayitCinsiyet.Text= dr[6].ToString();

            }
            bgl.baglanti().Close();
        }

        private void BtnHastaKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 Where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MskKayitTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", TxtKayitSifre.Text);
            komut2.Parameters.AddWithValue("@p5", CmbKayitCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskKayitTC.Text);
            komut2.ExecuteNonQuery(); 
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
         
           

        }
    }
}
