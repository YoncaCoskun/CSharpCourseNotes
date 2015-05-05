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

namespace ADOdisconnected
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");
        Calisan calisan = new Calisan();






        private void showAllDatabaseItems()
        {
            string komut = "select * from Employees";

            SqlCommand command = new SqlCommand(komut, connect);
            connect.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {



                    calisan.CalisanId = reader.GetInt32(0);
                    calisan.CalisanAdi = reader.GetString(2);
                    calisan.CalisanSoyadi = reader.GetString(1);
                    calisan.Memleketi = reader["City"].ToString();


                    listView1.Items.Add(calisan.CalisanId + "  " + calisan.CalisanAdi + "  " + calisan.CalisanSoyadi + "  " + calisan.Memleketi);

                }



            }
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // connected mimarı kullanılarak ve oop kullanılarak calısan ekleme guncelleme sıstemı yazılacak.
            //son gun pazartesi 23.00


            showAllDatabaseItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            string komut = "insert into Employees(LastName,FirstName,City) values ('" + txtCalisanAdi.Text + "','" + txtCalisanSoyadi.Text + "','" + txtCalisanMemleketi.Text + "')";

            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");

            SqlCommand command = new SqlCommand(komut, connect);

            connect.Open();
            object sonuc = command.ExecuteScalar();
            connect.Close();

            showAllDatabaseItems();

        }

        private void txtCalisanMemleketi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalisanSoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalisanAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
      
     
    }
}
