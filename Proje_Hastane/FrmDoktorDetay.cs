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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl=new Sqlbaglantisi();
        public string TC;
     
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frm=new FrmDoktorBilgiDuzenle();
            frm.TCNo = LblDoktorTC.Text;
            frm.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm=new FrmDuyurular();
            frm.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblDoktorTC.Text= TC;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblDoktorTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblDoktorAd.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='"+LblDoktorAd.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource= dt;   

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGirisler frm= new FrmGirisler();
            frm.Show();
            this.Hide();
        }
    }
}
