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
    public partial class Form1 : Form
    {

        //bağlantı metni 
        public MySqlConnection connect = new MySqlConnection("Server=localhost;Database=ucak_bilet;Uid=root;Pwd=''");

        //kullanıcı kaydı değşkenleri
        string uname = "";
        string tel = "";
        string mail = "";
        string pass = "";


        //giris değişkenleri
        string ad = "zeynep";
        string parola = "123";

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void new_user_Click(object sender, EventArgs e)
        {



            //bağlantıyı açar 
            try
            {
                connect.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }


            //rastgele id üretir
            Random random = new Random();
            int rand = random.Next(1000 , 10000);

            //textte çevirir boşlukları siler
            uname = username.Text.ToString().Trim();
            mail = e_mail.Text.ToString().Trim();
            pass = password.Text.ToString().Trim();
            tel = phone.Text.ToString().Trim();


            //bu kısım boş işe hata mesajı verir
            if(uname == "" || mail == "" || pass == "" || tel == "")
            {
                MessageBox.Show("Boş alanları doldurunuz ");
                return;
            }

            //sorgu metni ('')
            //tabloya veri ekleme sorgusu
            string query = "insert into kullanici (id,isim_soyisim,telefon,mail,sifre) values ('"+rand.ToString()+ "','" + uname + "','" + tel +"','" + mail +"','" + pass + "')";

            //sorguyu hazırlayan
            MySqlCommand DbCommand = new MySqlCommand(query, connect);


            //veri ekleyen kısım
            try
            {
                DbCommand.ExecuteReader();
                MessageBox.Show("Kayıt başarılı !");
                connect.Close();
            }catch(Exception err)
            {
                MessageBox.Show("Kayıt başarısız ! " + err );
            }


            //bağlantıyı kapatır
            connect.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            ad = kullanici_adi.Text.ToString().Trim();
            parola = kullanici_sifre.Text.ToString().Trim();

            try
            {
                connect.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            if (ad == "" || parola == "")
            {
                MessageBox.Show("Alanları doldurunuz !");
                return;
            }

            //sorgu kısmı ama veri kontrol etmek için
            string query = "select sifre from kullanici where mail='"+ad+"'";

            //sorgu kısmı
            MySqlCommand userBring = new MySqlCommand(query , connect);
            MySqlDataReader getuser;
            getuser = userBring.ExecuteReader();

            //verileri okuma kısmı
            while (getuser.Read())
            {
                //getString database den dönen değer 
                if(getuser.GetString(0) == parola)
                {
                
                    //yeni form aça eskisini kapatır
                    this.Hide();
                    var newform = new admin_girişi();
                    newform.FormClosed += (s, args) => this.Close();


                    newform.Show();
                    return;
                }else
                {
                    MessageBox.Show("Parola hatalı !");
                    return;
                }
                
            }


            MessageBox.Show("Kullanıcı bulunamadı !" );
            connect.Close();



        }

        private void admin_Click(object sender, EventArgs e)
        {
            //yeni form aça eskisini kapatır
            this.Hide();
            var newform = new admin_Giris();
            newform.FormClosed += (s, args) => this.Close();


            newform.Show();
            return;
        }
    }
}
