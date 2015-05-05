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
using System.Xml;

namespace xmlBasma
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

            SqlCommand command = new SqlCommand("select * from RSS_Goster",connect);

            connect.Open();
            object sonuc=command.ExecuteScalar();
            connect.Close();

            string RSS = "<rss xmlns:content=\"http://purl.org/rss/1.0/modules/content/\" xmlns:wfw=\"http://wellformedweb.org/CommentAPI/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:atom=\"http://www.w3.org/2005/Atom\" xmlns:media=\"http://search.yahoo.com/mrss/\" version=\"2.0\">" + sonuc +"</rss>";  //bastaki title ı buraya verebılırız(en basa yazılması gereken)

            XmlDocument documan = new XmlDocument();
          

            //ROOT ELEMANI ALDIRABİLMEK İCİN;
            documan.InnerXml = RSS;

            MessageBox.Show(documan.DocumentElement.InnerXml);



        }
    }
}
