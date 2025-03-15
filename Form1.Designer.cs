namespace Setup_E_Okul
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.txtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.btnOgretmen = new System.Windows.Forms.Button();
            this.txtOgretmenSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 123);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(281, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Okul Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(14, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Giriş";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOgrenciNo);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnOgrenci);
            this.groupBox1.Controls.Add(this.txtOgrenciSifre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 359);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrenciNo.Location = new System.Drawing.Point(219, 95);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(188, 44);
            this.txtOgrenciNo.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.BlanchedAlmond;
            this.linkLabel1.Location = new System.Drawing.Point(167, 295);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 35);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt yap";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kayıt için:";
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenci.Location = new System.Drawing.Point(219, 217);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(188, 43);
            this.btnOgrenci.TabIndex = 7;
            this.btnOgrenci.Text = "Giriş Yap";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // txtOgrenciSifre
            // 
            this.txtOgrenciSifre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgrenciSifre.Location = new System.Drawing.Point(219, 146);
            this.txtOgrenciSifre.Name = "txtOgrenciSifre";
            this.txtOgrenciSifre.Size = new System.Drawing.Size(188, 44);
            this.txtOgrenciSifre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.label5.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Öğrenci Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.label4.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Öğrenci No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtOgretmenAd);
            this.groupBox2.Controls.Add(this.btnOgretmen);
            this.groupBox2.Controls.Add(this.txtOgretmenSifre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(469, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 359);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgretmenAd.Location = new System.Drawing.Point(241, 91);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(188, 44);
            this.txtOgretmenAd.TabIndex = 3;
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgretmen.Location = new System.Drawing.Point(241, 217);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(188, 43);
            this.btnOgretmen.TabIndex = 10;
            this.btnOgretmen.Text = "Giriş Yap";
            this.btnOgretmen.UseVisualStyleBackColor = true;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // txtOgretmenSifre
            // 
            this.txtOgretmenSifre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOgretmenSifre.Location = new System.Drawing.Point(241, 144);
            this.txtOgretmenSifre.Name = "txtOgretmenSifre";
            this.txtOgretmenSifre.Size = new System.Drawing.Size(188, 44);
            this.txtOgretmenSifre.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.label7.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 40);
            this.label7.TabIndex = 11;
            this.label7.Text = "Öğretmen Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(18, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğretmen Giriş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.label8.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 40);
            this.label8.TabIndex = 10;
            this.label8.Text = "Öğretmen Ad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(85, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Log in varibales:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(237, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ad: mustafa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(237, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Şifre: tugcem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(959, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.TextBox txtOgrenciSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgretmenSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOgretmen;
        private System.Windows.Forms.TextBox txtOgretmenAd;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

