using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADODevam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string komut = "select COUNT(*) from Kullanicilar where KullaniciAdi='"+textBox1.Text+"' and Parola='"+textBox2.Text+"'";


            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");

            SqlCommand command = new SqlCommand(komut,connect);

            connect.Open();
            object sonuc = command.ExecuteScalar();
            connect.Close();

            if (Convert.ToInt32(sonuc) >0)
            {
                MessageBox.Show("Hosgeldiniz");
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
            }


            //Sorguya parametre olarak ozel ifadeler textbox lardan girilebilir.Bu durumda veri tabanına illegal sekilde manipule edilebilir.
            //Ozel ifadelerle veritabanına müdahaleye sql injection denir.
            //'or'1'='1 bu sekılde normalde parolaya yazdııgımızda dısardan kolayca ısmımız farklı olsa bıle gırıs yapabılıyoruz bunu engellemek ıcın ıkıncı butonu kullandık ve asagıdakı gıbı yaptık.


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //injection olayını engellemek ıcın bunu yaparız
            string komut = "select COUNT(*) from Kullanicilar where KullaniciAdi=@kullaniciAdi and Parola=@parola";


            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");

            SqlCommand command = new SqlCommand(komut, connect);

            command.Parameters.AddWithValue("@kullaniciAdi",textBox1.Text);
            command.Parameters.AddWithValue("@parola",textBox2.Text);

            connect.Open();
            object sonuc = command.ExecuteScalar();
            connect.Close();

            if (Convert.ToInt32(sonuc) > 0)
            {
                MessageBox.Show("Hosgeldiniz");
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
            }

        }

    }
}
