namespace ucak_bilet_satis_otomasyonuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullanici_sifre = new System.Windows.Forms.TextBox();
            this.kullanici_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.new_user = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.e_mail = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_giris);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.kullanici_sifre);
            this.panel2.Controls.Add(this.kullanici_adi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(49, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 351);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(148, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "TEMİZLE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_giris.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_giris.Location = new System.Drawing.Point(33, 271);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(98, 37);
            this.btn_giris.TabIndex = 6;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(83, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "kullanıcı adı:";
            // 
            // kullanici_sifre
            // 
            this.kullanici_sifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kullanici_sifre.Location = new System.Drawing.Point(160, 188);
            this.kullanici_sifre.Name = "kullanici_sifre";
            this.kullanici_sifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kullanici_sifre.Size = new System.Drawing.Size(129, 33);
            this.kullanici_sifre.TabIndex = 3;
            this.kullanici_sifre.UseSystemPasswordChar = true;
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kullanici_adi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_adi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.kullanici_adi.Location = new System.Drawing.Point(160, 118);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(129, 33);
            this.kullanici_adi.TabIndex = 2;
            this.kullanici_adi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(72, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Yap";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.new_user);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.password);
            this.panel3.Controls.Add(this.e_mail);
            this.panel3.Controls.Add(this.phone);
            this.panel3.Controls.Add(this.username);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(422, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 351);
            this.panel3.TabIndex = 0;
            // 
            // new_user
            // 
            this.new_user.BackColor = System.Drawing.Color.IndianRed;
            this.new_user.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.new_user.Location = new System.Drawing.Point(148, 296);
            this.new_user.Name = "new_user";
            this.new_user.Size = new System.Drawing.Size(172, 38);
            this.new_user.TabIndex = 2;
            this.new_user.Text = "KAYDOL";
            this.new_user.UseVisualStyleBackColor = false;
            this.new_user.Click += new System.EventHandler(this.new_user_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(119, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "şifre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(97, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "e-posta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(109, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(79, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "kullanıcı adı:";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.Location = new System.Drawing.Point(211, 246);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(141, 33);
            this.password.TabIndex = 7;
            this.password.UseSystemPasswordChar = true;
            // 
            // e_mail
            // 
            this.e_mail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.e_mail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.e_mail.Location = new System.Drawing.Point(211, 188);
            this.e_mail.Name = "e_mail";
            this.e_mail.Size = new System.Drawing.Size(141, 33);
            this.e_mail.TabIndex = 6;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.phone.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.phone.Location = new System.Drawing.Point(211, 132);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(141, 33);
            this.phone.TabIndex = 5;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.username.Location = new System.Drawing.Point(211, 75);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(141, 33);
            this.username.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Thistle;
            this.label2.Location = new System.Drawing.Point(153, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kaydol";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.admin);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 454);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Thistle;
            this.label9.Location = new System.Drawing.Point(305, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 78);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kullanıcı Girişi\r\n\r\n";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.PaleVioletRed;
            this.admin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.admin.Location = new System.Drawing.Point(12, 3);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(98, 37);
            this.admin.TabIndex = 7;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 454);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "giriş paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullanici_sifre;
        private System.Windows.Forms.TextBox kullanici_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button new_user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox e_mail;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button admin;
    }
}

