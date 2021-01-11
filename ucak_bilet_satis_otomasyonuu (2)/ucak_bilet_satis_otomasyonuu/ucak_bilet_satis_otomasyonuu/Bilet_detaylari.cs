using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ucak_bilet_satis_otomasyonuu
{
    public partial class kayıt_ekle : MetroFramework.Forms.MetroForm
    {

        public MySqlConnection connect = new MySqlConnection("Server=localhost;Database=ucak_bilet;Uid=root;Pwd=''");


        string id_num = "";
        public kayıt_ekle(string id)
        {
            InitializeComponent();
            id_num = id;

            try
            {
                connect.Open();
            }catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            try
            {
                string query = "select ad,soyad,telefon,nerden,Nereye,saatler,bilet_tarih from bilet_ekle where id='"+id_num+"'";

                MySqlCommand bilet_getir = new MySqlCommand(query , connect);
                MySqlDataReader bilet_read;
                bilet_read = bilet_getir.ExecuteReader();
                while (bilet_read.Read())
                {
                    name.Text = bilet_read.GetString(0) +" " +bilet_read.GetString(1);
                    nereden.Text = bilet_read.GetString(3);
                    nereye.Text = bilet_read.GetString(4);
                    saat.Text = bilet_read.GetString(5);
                    tarih.Text = bilet_read.GetString(6);
                    fiyat.Text = "1000 ₺";
                    


                }

            }catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            
        }

        private void kayıt_ekle_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
