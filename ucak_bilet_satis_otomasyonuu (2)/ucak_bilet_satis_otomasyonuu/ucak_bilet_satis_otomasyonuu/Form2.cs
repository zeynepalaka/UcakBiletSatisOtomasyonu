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
    public partial class admin_girişi : Form
    {
        //bağlantı metni 
        public MySqlConnection connect = new MySqlConnection("Server=localhost;Database=ucak_bilet;Uid=root;Pwd=''");
        string tc = ""; //tc_no
        string ad = ""; //isim
        string soyad = "";//soyisim
        string kategori = ""; //yas_kategori
        string telno = ""; //telefon
        string Cinsiyet = ""; //cinsiyet
        string nerden = ""; //nereden
        string Nereye = "";//nereye
        string saatler = "";//ucus_saatleri
        string bilet_tarih = ""; //tarih




        public admin_girişi()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bilet_al_Click(object sender, EventArgs e)
        {
       

            tc = tc_no.Text.ToString().Trim();
            ad = isim.Text.ToString().Trim();
            soyad = soyisim.Text.ToString().Trim();
            kategori = yas_kategori.Text.ToString().Trim();
            telno = telefon.Text.ToString().Trim();
            Cinsiyet = cinsiyet.Text.ToString().Trim();
            nerden = nereden.Text.ToString().Trim();
            Nereye = Znereye.Text.ToString().Trim();
            saatler = ucus_saatleri.Text.ToString().Trim();
            bilet_tarih = tarih.Text.ToString().Trim();

            if(tc == "" || ad== "" || soyad == "" || kategori== "" || telno == "" || Cinsiyet == "" || nerden == "" || Nereye == "" || saatler == "" || bilet_tarih == "")
            {
                MessageBox.Show("Gerekli Alanları doldurunuz");
                return;
            }

            try
            {
                connect.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Bağlantı hatası " + err.ToString());
            }


            Random random = new Random();
            int rand = random.Next(1000 , 10000);

            string query = "insert into bilet_ekle (id,tc,ad,soyad,telefon,kategori,Cinsiyet,nerden,Nereye,saatler,bilet_tarih)";


            string query_value = query + " values ('"+rand+"','"+tc+"','"+ad+"','"+soyad+"','"+telno+"','"+kategori+"','"+Cinsiyet+"','"+nerden+"','"+Nereye+"','"+saatler+"','"+bilet_tarih+"')";

            MySqlCommand dbCommand = new MySqlCommand(query_value , connect );

            try
            {
                dbCommand.ExecuteReader();

                var newbilet = new kayıt_ekle(rand.ToString());
                newbilet.Show();



                connect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bilet alınırken hata oluştu");
            }

        }
    }
}
