namespace Setup_E_Okul
{
    partial class Frm_Ogretmen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtSozlu = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 134);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretmen Giriş";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 563);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 193);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.label2.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumara);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 351);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Paneli";
            // 
            // txtNumara
            // 
            this.txtNumara.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumara.Location = new System.Drawing.Point(174, 249);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(159, 40);
            this.txtNumara.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(174, 190);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(159, 40);
            this.txtSifre.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.Location = new System.Drawing.Point(174, 134);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(159, 40);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(174, 79);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(159, 40);
            this.txtAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.label5.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.label4.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.label3.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyadı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDurum);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtOrtalama);
            this.groupBox2.Controls.Add(this.txtSozlu);
            this.groupBox2.Controls.Add(this.txtSinav2);
            this.groupBox2.Controls.Add(this.txtSinav1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(408, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 351);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbDurum.Location = new System.Drawing.Point(174, 290);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(159, 41);
            this.cmbDurum.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.label10.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 40);
            this.label10.TabIndex = 10;
            this.label10.Text = "Durum:";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrtalama.Location = new System.Drawing.Point(174, 231);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(159, 40);
            this.txtOrtalama.TabIndex = 8;
            // 
            // txtSozlu
            // 
            this.txtSozlu.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSozlu.Location = new System.Drawing.Point(174, 176);
            this.txtSozlu.Name = "txtSozlu";
            this.txtSozlu.Size = new System.Drawing.Size(159, 40);
            this.txtSozlu.TabIndex = 7;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinav2.Location = new System.Drawing.Point(174, 120);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(159, 40);
            this.txtSinav2.TabIndex = 6;
            // 
            // txtSinav1
            // 
            this.txtSinav1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinav1.Location = new System.Drawing.Point(174, 65);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(159, 40);
            this.txtSinav1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.label6.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ortalama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.label7.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 40);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sözlü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.label8.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 40);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sınav 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(136)))));
            this.label9.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 40);
            this.label9.TabIndex = 2;
            this.label9.Text = "Sınav 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.btnTemizle);
            this.groupBox3.Controls.Add(this.btnGuncelle);
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.btnListele);
            this.groupBox3.Location = new System.Drawing.Point(789, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 351);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(23, 241);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(195, 42);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(23, 187);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(195, 42);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(23, 135);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(195, 42);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gray;
            this.btnSil.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(23, 295);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(195, 42);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(23, 83);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(195, 42);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.Location = new System.Drawing.Point(23, 32);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(195, 42);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Frm_Ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(111)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1049, 772);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Frm_Ogretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Giriş";
            this.Load += new System.EventHandler(this.Frm_Ogretmen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtSozlu;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ComboBox cmbDurum;
    }
}