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

namespace Setup_E_Okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Eokul_Projesi;Integrated Security=True;");

        string OgretmenSifre;
        string OgrenciSifre;
        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * From Tbl_Teachers where Teacher_Name=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",txtOgretmenAd.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                OgretmenSifre = dr[1].ToString();
            }

            if (txtOgretmenSifre.Text == OgretmenSifre)
            {

                Frm_Ogretmen fr = new Frm_Ogretmen();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Şifre veya Ad lütfen değerlerinizi kontrol edin","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            baglanti.Close();

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Students where Student_No=@p1",baglanti);
            komut2.Parameters.AddWithValue("@p1",txtOgrenciNo.Text);

            SqlDataReader dr = komut2.ExecuteReader();

            if (dr.Read()) 
            {

                OgrenciSifre = dr[1].ToString();

                
            }

            if (txtOgrenciSifre.Text == OgrenciSifre)
            {
                Frm_Ogrenci frm = new Frm_Ogrenci();
                frm.OgrenciAd = dr[2].ToString();
                frm.OgrenciNo = dr[0].ToString();
                frm.OgrenciSoyad = dr[3].ToString();
                frm.Sinav1 = dr[4].ToString();
                frm.Sinav2 = dr[5].ToString();
                frm.Proje = dr[6].ToString();
                frm.Ortalama = dr[7].ToString();
                frm.Durum = dr[8].ToString();

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre veya Numaranız hatalı lütfen kontrol edin","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
