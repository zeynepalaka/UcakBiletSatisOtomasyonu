namespace ucak_bilet_satis_otomasyonuu
{
    partial class admin_sayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_sayfasi));
            this.müsteri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bilet_listesi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.top_bilet = new System.Windows.Forms.Label();
            this.top_kullanici = new System.Windows.Forms.Label();
            this.top_fiyat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.müsteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilet_listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // müsteri
            // 
            this.müsteri.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.müsteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.müsteri.Location = new System.Drawing.Point(12, 87);
            this.müsteri.Name = "müsteri";
            this.müsteri.Size = new System.Drawing.Size(339, 363);
            this.müsteri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(117, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteriler";
            // 
            // bilet_listesi
            // 
            this.bilet_listesi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bilet_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bilet_listesi.GridColor = System.Drawing.Color.BlueViolet;
            this.bilet_listesi.Location = new System.Drawing.Point(357, 87);
            this.bilet_listesi.Name = "bilet_listesi";
            this.bilet_listesi.Size = new System.Drawing.Size(731, 363);
            this.bilet_listesi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(647, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bilet Kayıtları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Toplam kullanıcı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "toplam bilet sayıs";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // top_bilet
            // 
            this.top_bilet.AutoSize = true;
            this.top_bilet.Location = new System.Drawing.Point(386, 51);
            this.top_bilet.Name = "top_bilet";
            this.top_bilet.Size = new System.Drawing.Size(35, 13);
            this.top_bilet.TabIndex = 9;
            this.top_bilet.Text = "label6";
            // 
            // top_kullanici
            // 
            this.top_kullanici.AutoSize = true;
            this.top_kullanici.Location = new System.Drawing.Point(386, 34);
            this.top_kullanici.Name = "top_kullanici";
            this.top_kullanici.Size = new System.Drawing.Size(35, 13);
            this.top_kullanici.TabIndex = 8;
            this.top_kullanici.Text = "label7";
            // 
            // top_fiyat
            // 
            this.top_fiyat.AutoSize = true;
            this.top_fiyat.Location = new System.Drawing.Point(386, 9);
            this.top_fiyat.Name = "top_fiyat";
            this.top_fiyat.Size = new System.Drawing.Size(35, 13);
            this.top_fiyat.TabIndex = 7;
            this.top_fiyat.Text = "label8";
            // 
            // admin_sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.top_bilet);
            this.Controls.Add(this.top_kullanici);
            this.Controls.Add(this.top_fiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bilet_listesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.müsteri);
            this.Name = "admin_sayfasi";
            this.Text = "admin_sayfasi";
            ((System.ComponentModel.ISupportInitialize)(this.müsteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilet_listesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView müsteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bilet_listesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label top_bilet;
        private System.Windows.Forms.Label top_kullanici;
        private System.Windows.Forms.Label top_fiyat;
    }
}