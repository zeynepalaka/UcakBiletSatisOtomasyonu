using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucak_bilet_satis_otomasyonuu
{
    public partial class giris : Form
    {

        int sayac = 0;
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start(); 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            //3 saniye için
            if(sayac > 3)
            {
                timer1.Stop();

                //yeni form aça eskisini kapatır
                this.Hide();
                var newform = new Form1();
                newform.FormClosed += (s, args) => this.Close();
                newform.Show();

            } 
        }
    }
}
