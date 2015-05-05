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

namespace HomeWorkADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // connected mimarı kullanılarak ve oop kullanılarak calısan ekleme guncelleme sıstemı yazılacak.
        //son gun pazartesi 23.00

        SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");
        Calisan calisan = new Calisan();
        int EmployeeId = 0;

        private void showAllDatabaseItems()
        {
            listView1.Items.Clear();

            string komut = "select * from Employees";

            SqlCommand command = new SqlCommand(komut, connect);
            connect.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    calisan.CalisanId = reader.GetInt32(0);
                    calisan.CalisanSoyadi = reader.GetString(1);
                    calisan.CalisanAdi = reader.GetString(2);
                    calisan.Memleketi = reader["City"].ToString();


                    ListViewItem row = new ListViewItem(calisan.CalisanId.ToString());
                    row.SubItems.Add(calisan.CalisanAdi);
                    row.SubItems.Add(calisan.CalisanSoyadi);
                    row.SubItems.Add(calisan.Memleketi);


                    listView1.Items.Add(row);

                }



            }
            connect.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showAllDatabaseItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Kaydet")
            {
                string komut = "insert into Employees(EmployeeID,FirstName,LastName,City) values ('" + txtCalisanID.Text + "','" + txtCalisanAdi.Text + "','" + txtCalisanSoyadi.Text + "','" + txtCalisanMemleketi.Text + "')";

                SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi");

                SqlCommand command = new SqlCommand(komut, connect);

                connect.Open();
                object sonuc = command.ExecuteScalar();
                connect.Close();
                showAllDatabaseItems();

            }
            else
            {
                string komut = "update Employees set FirstName='" + txtCalisanAdi.Text + "',LastName='" + txtCalisanSoyadi.Text + "',City='" + txtCalisanMemleketi.Text + "' where EmployeeId=" + EmployeeId + "";
                connect.Open();
                SqlCommand command = new SqlCommand(komut, connect);
                command.ExecuteNonQuery();
                connect.Close();
                showAllDatabaseItems();

            }

        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button2.Text = "Güncelle";
            EmployeeId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            txtCalisanID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtCalisanAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtCalisanSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtCalisanMemleketi.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }




    }
}
