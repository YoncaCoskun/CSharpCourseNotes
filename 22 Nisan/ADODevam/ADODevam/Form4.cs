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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //form acılır acılmaz her bır calısan verı tabanından cekılecek ve her bır calısan ıcın bır calısan class ı instance alınacak ve alınan her ınstance listbox a eklenecek.

            string komut = "select * from Employees ";

            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");



            SqlCommand command = new SqlCommand(komut, connect);


            connect.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Calisan calisan = new Calisan();
                    calisan.CalisanId = reader.GetInt32(0);
                    calisan.CalisanAdi = reader.GetString(2);
                    calisan.CalisanSoyadi = reader.GetString(1);
                    calisan.Notlar = reader["Notes"].ToString();
                    calisan.Memleketi = reader["City"].ToString();


                    listBox1.Items.Add(calisan);
                }


            }
            connect.Close();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //sectıgım calısanın satıslarının id sini getirin.

            listBox2.Items.Clear();

            Calisan calisan = listBox1.SelectedItem as Calisan;
           

            string komut = "select * from Orders where EmployeeID=@id";

            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");

            SqlCommand command = new SqlCommand(komut,connect);
            command.Parameters.AddWithValue("@id",calisan.CalisanId);

            connect.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   listBox2.Items.Add(reader.GetSqlInt32(0));
                }
                
            }

            connect.Close();
        }


    }
}
