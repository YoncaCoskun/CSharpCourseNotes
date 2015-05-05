using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ado.net:active data object
            // veri tabanına ulasımı saglayacak tip nesnelere ado.net baslıgında ulasılır

            SqlConnection baglanti = new SqlConnection(); //SQL baglanma

            // sqlconnection nesnesinin hangi veri tabanına baglanacagını belirten kelimelere connection string denir.

            //http://www.connectionstrings.com/

            baglanti.ConnectionString = "server=PC;database=northwind;Integrated Security=sspi;";

            //uzaktakı bır makınaya baglanmamız gerekseydı; User Id=myUsername;Password=mypassword; seklınde baglanılır(ıntegrated yerıne)

            MessageBox.Show(baglanti.State.ToString());
            baglanti.Open();  //suan baglanti acıldı 
            MessageBox.Show(baglanti.State.ToString());  //baglantinin acık olup olmadıgını test edıyoruz


            //baglantının max havuzu(max pull size):baglantı acık kalırsa timeout a duser yanı zaman asımına ugrar.Eger acııyorsa mutlaka kapatılmak zorundadır.



            baglanti.Close();
            MessageBox.Show(baglanti.State.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string komut = "select count(*) from Orders";

            SqlCommand hamal = new SqlCommand(); //komut ıcındekı strıng yazımın sql e goturulebılmesı ıcın yapılan koddur.

            //hamal a yukardakı konutu vermemız lazım
            hamal.CommandText = komut; //suan nereye gıdıcegını bılmıyor, bılmesi icin;

            SqlConnection baglanti = new SqlConnection(); //baglancagı yeri gosterdık
            baglanti.ConnectionString = "server=PC;database=northwind;integrated security=sspi";

            //hamal a hangı yolla baglancagını gostermek ıcın;
            hamal.Connection = baglanti;

            baglanti.Open();
            object sonuc=hamal.ExecuteScalar();//dondugu tıpten kaynakşı object e esıtledık

            //ExecuteScalar:sorgunun sonucu tek satır tek sutun ise kullanılır
            //ExecuteNonQuery: insert,update,delete islemleri icin kullanılır.
            //ExecuteReader: sorgunun sonucu cok satır ve cok sutun ise kullanılır.
            baglanti.Close();

            MessageBox.Show(sonuc.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string komut = "insert into Employees(FirstName,LastName) values ('Naciye','Davaro')";

            SqlCommand cmd = new SqlCommand(komut);

            SqlConnection con = new SqlConnection("server=.;database=Northwind;integrated security=sspi");

            cmd.Connection = con;

            con.Open();
            int satirSayisi=cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(satirSayisi.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=northwind;integrated security=sspi");

            SqlCommand cmd = new SqlCommand("select CategoryName from Categories",con); //con.connection yerıne bu sekılde de verılebılır.

            con.Open();
           SqlDataReader okuyucu= cmd.ExecuteReader();
           while (okuyucu.Read()==true)
           {
               listBox1.Items.Add(okuyucu.GetString(0));
           }

            con.Close();

            //Connected Mimari:
             
            //SqlCommand
            //SqlConnection
            //SqlDataReader

            //Disconnected Mimari:

            //SqlDataAdapter
            //DataSet
            //DataTable



        }

        
    }
}
