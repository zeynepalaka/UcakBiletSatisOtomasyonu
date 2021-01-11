namespace ucak_bilet_satis_otomasyonuu
{
    partial class admin_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_Giris));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_giris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullanici_sifre = new System.Windows.Forms.TextBox();
            this.kullanici_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_giris);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.kullanici_sifre);
            this.panel2.Controls.Add(this.kullanici_adi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(174, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 351);
            this.panel2.TabIndex = 3;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_giris.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_giris.Location = new System.Drawing.Point(109, 261);
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
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "kullanıcı adı:";
            // 
            // kullanici_sifre
            // 
            this.kullanici_sifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kullanici_sifre.Location = new System.Drawing.Point(160, 188);
            this.kullanici_sifre.Name = "kullanici_sifre";
            this.kullanici_sifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kullanici_sifre.Size = new System.Drawing.Size(129, 20);
            this.kullanici_sifre.TabIndex = 3;
            this.kullanici_sifre.UseSystemPasswordChar = true;
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kullanici_adi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_adi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.kullanici_adi.Location = new System.Drawing.Point(160, 121);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(129, 33);
            this.kullanici_adi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(79, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Yap";
            // 
            // admin_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "admin_Giris";
            this.Text = "admin_Giris";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullanici_sifre;
        private System.Windows.Forms.TextBox kullanici_adi;
        private System.Windows.Forms.Label label1;
    }
}