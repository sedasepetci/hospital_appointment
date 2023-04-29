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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje_Hastane
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl=new Sqlbaglantisi();
        
        private void BtnGiris_Click(object sender, EventArgs e)
        {
           
           
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.TC = MskTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı & Şifre ");
            }
            bgl.baglanti().Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                
                if (checkBox1.CheckState==CheckState.Checked)
                {
                 
                    TxtSifre.UseSystemPasswordChar = false;
                   
                 
                } 
                else
                {
                    TxtSifre.UseSystemPasswordChar = true;
                   
                }
            }
        }
    }
}
