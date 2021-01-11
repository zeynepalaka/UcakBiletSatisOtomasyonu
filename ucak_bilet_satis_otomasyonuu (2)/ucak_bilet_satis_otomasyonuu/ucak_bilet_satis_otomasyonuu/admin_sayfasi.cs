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
    public partial class admin_sayfasi : Form
    {
        //bağlantı metni 
        public MySqlConnection connect = new MySqlConnection("Server=localhost;Database=ucak_bilet;Uid=root;Pwd=''");


        public admin_sayfasi()
        {
            InitializeComponent();

            try
            {
                connect.Open();
            }catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            müsteri.ColumnCount = 3;
            müsteri.ColumnHeadersVisible = true;
            müsteri.Columns[0].Name = "Müşteri Adı";
            müsteri.Columns[1].Name = "Telefon";
            müsteri.Columns[2].Name = "E-mail";    

            try
            {
                string kullanici_liste = "select * from kullanici ";
                MySqlCommand DbCommand = new MySqlCommand(kullanici_liste , connect);
                MySqlDataReader kullanici_getir;
                kullanici_getir = DbCommand.ExecuteReader();
                while (kullanici_getir.Read()) 
                {
                    müsteri.Rows.Add(kullanici_getir.GetString(1), kullanici_getir.GetString(2), kullanici_getir.GetString(3));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            connect.Close();

            try
            {
                connect.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }



            bilet_listesi.ColumnCount = 9;
            bilet_listesi.ColumnHeadersVisible = true;
            bilet_listesi.Columns[0].Name = "TC";
            bilet_listesi.Columns[1].Name = "Ad Soyad";
            bilet_listesi.Columns[2].Name = "Telefon";
            bilet_listesi.Columns[3].Name = "Kategori";
            bilet_listesi.Columns[4].Name = "Nerden";
            bilet_listesi.Columns[5].Name = "Nereye";
            bilet_listesi.Columns[6].Name = "Saat";
            bilet_listesi.Columns[7].Name = "Tarih";
            bilet_listesi.Columns[8].Name = "Fiyat";

            try
            {
                string bilet_liste = "select * from bilet_ekle";
                MySqlCommand DbCommand = new MySqlCommand(bilet_liste, connect);
                MySqlDataReader bilet_getir;
                bilet_getir = DbCommand.ExecuteReader();
                while (bilet_getir.Read())
                {
                    bilet_listesi.Rows.Add(bilet_getir.GetString(1), bilet_getir.GetString(2) + " " + bilet_getir.GetString(3), bilet_getir.GetString(4), bilet_getir.GetString(5), bilet_getir.GetString(7) , bilet_getir.GetString(8), bilet_getir.GetString(9), bilet_getir.GetString(10) , "1000 ₺");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }



            connect.Close();

            try
            {
                connect.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }



          
            try
            {
                string bilet_liste = "select * from verilerview where id=1 ";
                MySqlCommand DbCommand = new MySqlCommand(bilet_liste, connect);
                MySqlDataReader bilet_view;
                bilet_view = DbCommand.ExecuteReader();
                while (bilet_view.Read())
                {
                    top_fiyat.Text = (Convert.ToInt32(bilet_view.GetString(3)) * 1000).ToString();
                    top_bilet.Text = bilet_view.GetString(2);
                    top_kullanici.Text = bilet_view.GetString(1);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
