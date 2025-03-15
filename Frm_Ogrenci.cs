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
    public partial class Frm_Ogrenci : Form
    {
        public Frm_Ogrenci()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Eokul_Projesi;Integrated Security=True;");


        public string OgrenciAd;
        public string OgrenciSoyad;
        public string OgrenciNo;
        public string Sinav1;
        public string Sinav2;
        public string Proje;
        public string Ortalama;
        public string Durum;
        public string Sifre;

        private void Frm_Ogrenci_Load(object sender, EventArgs e)
        {
    
            
            lblAdSoyad.Text = OgrenciAd + " " + OgrenciSoyad;
            lblNo.Text = OgrenciNo;
            lblOrtalama.Text = Ortalama;
            lblSinav1.Text = Sinav1;
            lblSinav2.Text = Sinav2;
            lblSozlu.Text = Proje;
            lblDurum.Text = Durum;

            

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {

        }
    }
}
