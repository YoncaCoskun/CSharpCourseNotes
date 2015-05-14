using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindResimler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi;");

            SqlCommand command = new SqlCommand("select Photo from Employees where EmployeeID=1010", connect);

            connect.Open();
            object sonuc = command.ExecuteScalar();
            byte[] dizi = (byte[])sonuc; //sonucu byte dıZısıne cast ettık
            connect.Close();

            //ram de kalsın yada harddiske kaydolsun ıstıyoruz hangısını tercıh etmelıyız?

            //--------------------------Harddiske kaydetme:----------------------------------------
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Nancy.jpg", FileMode.OpenOrCreate);

            // fs.Write(dizi,78,dizi.Length-78);   
            fs.Write(dizi, 0, dizi.Length);
            pictureBox1.Image = Image.FromStream(fs); //picturebox ta da gorulmesını ıstersek.
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //-----------------------------------jpg yi byte la tutma-----------------------------------------------

            SqlCommand command = new SqlCommand("insert into Employees(FirstName,LastName,Photo) values ('Yonca','Coskun',@resim)", new SqlConnection("server=.;database=northwind;integrated security=sspi;"));



            FileStream fs = new FileStream("yonca.jpg", FileMode.Open);

            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();

            //resmın sonuna yazı aktarma(viruste aktarılabılır.)
            //Array.Resize(ref buffer,buffer.Length+1024);
            //byte[] yazi = Encoding.UTF8.GetBytes("bugunum sensız gecti");

            //for (int i = 0; i < yazi.Length; i++)
            //{
            //    buffer[buffer.Length - 1024 + i] = yazi[i];
            //}

            command.Parameters.AddWithValue("@resim", buffer);
            command.Connection.Open();
            int sonuc = command.ExecuteNonQuery();
            command.Connection.Close();
            MessageBox.Show(sonuc.ToString());





        }

        private void button3_Click(object sender, EventArgs e)
        {
            //------------------------exe yi byte olarak tutma-----------------------------------------------

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);


                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                //harddiske kaydetmeden byte dızısını ram den nasıl cekerız?
                    //MemoryStream ms = new MemoryStream();
                    //ms.Write(buffer,0,buffer.Length);
                    //pictureBox1.Image = Image.FromStream(ms);
            }



        }
    }
}
