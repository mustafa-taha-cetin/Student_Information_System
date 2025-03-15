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
    public partial class Frm_Ogretmen : Form
    {
        public Frm_Ogretmen()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=Eokul_Projesi;Integrated Security=True;");

        void listele()
        {

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Students",baglanti);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();

        }


        private void Frm_Ogretmen_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Students (Student_No, Student_Password, Student_Name, Student_Surname, Student_Exam1, Student_Exam2, Student_Project, Student_Avg, Student_Status) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            
            komut.Parameters.AddWithValue("@p1",txtNumara.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            komut.Parameters.AddWithValue("@p3",txtAd.Text);
            komut.Parameters.AddWithValue("@p4",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p5",txtSinav1.Text);
            komut.Parameters.AddWithValue("@p6",txtSinav2.Text);
            komut.Parameters.AddWithValue("@p7",txtSozlu.Text);
            komut.Parameters.AddWithValue("@p8",txtOrtalama.Text);
            komut.Parameters.AddWithValue("@p9",cmbDurum.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Öğrenci kaydı yapılmıştır","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text=="" || txtNumara.Text == "" || txtOrtalama.Text== "" || txtSifre.Text=="" || txtSinav1.Text=="" || txtSinav2.Text=="" || txtSoyad.Text=="" || txtSozlu.Text == "" || cmbDurum.Text == "")
            {
                MessageBox.Show("Güncellenen değerlerde eksiklik var Lütfen kontrol edin","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {

                baglanti.Open();

                SqlCommand komut3 = new SqlCommand("update Tbl_Students set Student_Name=@p1, Student_Surname=@p2, Student_Password=@p3, Student_Exam1=@p4, Student_Exam2=@p5, Student_Project=@p6, Student_Avg=@p7, Student_Status=@p8 where Student_No=@p ", baglanti);

                komut3.Parameters.AddWithValue("@p", txtNumara.Text);
                komut3.Parameters.AddWithValue("@p1", txtAd.Text);
                komut3.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut3.Parameters.AddWithValue("@p3", txtSifre.Text);
                komut3.Parameters.AddWithValue("@p4", txtSinav1.Text);
                komut3.Parameters.AddWithValue("@p5", txtSinav2.Text);
                komut3.Parameters.AddWithValue("@p6", txtSozlu.Text);
                komut3.Parameters.AddWithValue("@p7", txtOrtalama.Text);
                komut3.Parameters.AddWithValue("@p8", cmbDurum.Text);

                komut3.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Kayıt güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }



        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            txtAd.Text = "";
            txtNumara.Text = "";
            txtOrtalama.Text = "";
            txtSifre.Text = "";
            txtSinav1.Text = "";
            txtSinav2.Text = "";
            txtSoyad.Text = "";
            txtSozlu.Text = "";
            cmbDurum.Text = "";

        }

        int s1, s2, p, sonuc, avg;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {

                s1 = Convert.ToInt16(txtSinav1.Text);
                s2 = Convert.ToInt16(txtSinav2.Text);
                p = Convert.ToInt16(txtSozlu.Text);
                avg = s1 + s2 + p;
                sonuc = avg / 3;
                if (sonuc > 100 || s1 > 100 || s2 > 100 || p > 100)
                {
                    MessageBox.Show("Girdiğiniz değerlerde bir sorun bulunmakta lütfen değerleri kontrol ediniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

                else
                {
                    txtOrtalama.Text = Convert.ToString(sonuc);

                    MessageBox.Show("Ortalama hesaplandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (sonuc >= 50)
                {
                    cmbDurum.Text = "True";
                }

                else
                {
                    cmbDurum.Text = "False";
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Tüm değerleri girmeden ortalama hesaplayamazsınız","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
            }       

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtNumara.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString() ;
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSozlu.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cmbDurum.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();


        }


    }
}
