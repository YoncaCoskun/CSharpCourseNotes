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

namespace CokluSorgular
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //connected durumda ıkı select ı aynı zamanda kullanabılmek

            SqlConnection connect = new SqlConnection("server=.;database=northwind;integrated security=sspi;");


            SqlCommand command = new SqlCommand("select * from Employees;select*from Customers",connect);

            //connect.Open();
            //SqlDataReader rdr = command.ExecuteReader();

            //while (rdr.Read())
            //{
            //    listBox1.Items.Add(rdr.GetString(1));
            //}

            //rdr.NextResult(); //sıradakı sonuc ıcın select sorgusuna gecıyor


            //while (rdr.Read())
            //{
            //    listBox2.Items.Add(rdr.GetString(1));
            //}


            //connect.Close();


            //----------------------------------------------------------------------------------------
            //--------------------------------------MICROSOFT SORUSU--------------------------------
            //---------------sorusunun cevabı budur.(iki listboxtakını tek lıstbox a aktarma)

            connect.Open();

            SqlDataReader rdr = command.ExecuteReader();

            do
            {          

            while (rdr.Read())
            {
                listBox1.Items.Add(rdr.GetString(1));
            }
            }while(rdr.NextResult());

            connect.Close();

            
        }
    }
}
