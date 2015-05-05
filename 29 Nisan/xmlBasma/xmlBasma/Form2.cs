using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xmlBasma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        XmlDocument documan;
        XmlElement root;

        //---------------------------------------XML yazdırmanın farklı bir Yöntemi----------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            
            XmlElement ogrenci=documan.CreateElement("Ogrenci"); //xml de ogrencı tag ları var
            //eleman.InnerText = "Ahmet"; //ahmet dıye calısanı xml e bastı

            XmlElement isim = documan.CreateElement("Isim");
            isim.InnerText = textBox1.Text;
            ogrenci.AppendChild(isim);

            XmlElement soyisim = documan.CreateElement("Soyisim");
            soyisim.InnerText = textBox2.Text;
            ogrenci.AppendChild(soyisim);



            root.AppendChild(ogrenci); //ana dokumanı bu sekılde ekledık buna yavru documanlar eklemelıyız
            documan.Save("deneme.xml");



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //documanı load da calıstırıcaz ve her load oldugunda  XmlDocument documan = new XmlDocument(); kodu calıstırmalıyız

            documan = new XmlDocument();
            XmlDeclaration tanim=documan.CreateXmlDeclaration("1.0","UTF-8","yes"); // ?xml olarak baslayan kısmı belırtmek ıcın bunu yaptık
            documan.AppendChild(tanim);  // utf li olan kısmın gelebilmesi icin appendchıld yapmamız gerekıyordu

            root = documan.CreateElement("Ogrenciler");
            documan.AppendChild(root);  //root elemanı ogrencıler olarak verdık.


        }

        private void button2_Click(object sender, EventArgs e)
        {

            XmlNode gelen = documan.SelectSingleNode("Ogrenciler/Ogrenci[Isim='Mustafa']");  //sorgulama yontemidir.yani Ogrenciler root ıcınde ogrencılerden ısmı mustafaya esıt olan anlamında butun mustafa ısımlı ogrencılerın bılgılerı gelır.  //innertext yerıne outer yaptıgımızda html taglarıyla alıyoruz

            if (gelen !=null)
            {
                MessageBox.Show(gelen.InnerText);
                MessageBox.Show(gelen.InnerXml);
                MessageBox.Show(gelen.OuterXml);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            documan.Load("deneme.xml");
        }
    }
}
