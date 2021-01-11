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
    public partial class admin_Giris : Form
    {

        //bağlantı metni 
        public MySqlConnection connect = new MySqlConnection("Server=localhost;Database=ucak_bilet;Uid=root;Pwd=''");
        string username = "";
        string pass = "";

        public admin_Giris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            username = kullanici_adi.Text.ToString().Trim();
            pass = kullanici_sifre.Text.ToString().Trim();
            
            if(username == "" || pass == "")
            {
                MessageBox.Show("Gerekli Alanları doldurunuz ");
                return;
            }
            try
            {
                connect.Open();
            }catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }




            //sorgu kısmı ama veri kontrol etmek için
            string query = "select sifre from admin_kullanici where email='" + username + "'";

            //sorgu kısmı
            MySqlCommand userBring = new MySqlCommand(query, connect);
            MySqlDataReader getuser;
            getuser = userBring.ExecuteReader();

            //verileri okuma kısmı
            while (getuser.Read())
            {
                //getString database den dönen değer 
                if (getuser.GetString(0) == pass)
                {

                    //yeni form aça eskisini kapatır
                    this.Hide();
                    var newform = new admin_sayfasi();
                    newform.FormClosed += (s, args) => this.Close();


                    newform.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Parola hatalı !");
                    return;
                }

            }

            connect.Close();


            }
    }
}
