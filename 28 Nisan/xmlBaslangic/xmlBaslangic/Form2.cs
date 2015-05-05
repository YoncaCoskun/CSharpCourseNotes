using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xmlBaslangic
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DOM Data Object Model
            //xml metni ram uzerıne alarak kullanmamızı saglayan nesnelere DOM nesneleri denir.

            XmlDocument xmlDokumani = new XmlDocument();
            xmlDokumani.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            XmlElement rootEleman = xmlDokumani.DocumentElement;  //Direk veriyi almak ıcın kullanıyoruz.yani ekstra xml dokumanı olusturup kopyalamakla ugrasmamak icin.(butun xml i alıyoruz bu sekilde)

            XmlNodeList liste = rootEleman.GetElementsByTagName("Currency");  //bu sekılde tag adıyla element getiriyoruz.(ıcınde xmlnode lıstesı var anlamında, dongu ıle ıcınde donebılırız cunku bır lıste bu)
            foreach (XmlNode item in liste)
            {
                Doviz doviz = new Doviz();

                XmlElement currency = (XmlElement)item;
                string isim = currency.GetElementsByTagName("Isim").Item(0).InnerText;
                string alisFiyati = currency.GetElementsByTagName("ForexSelling").Item(0).InnerText.Replace('.',',');
                string satisFiyati = currency.GetElementsByTagName("ForexBuying").Item(0).InnerText.Replace('.',',');
                string birim = currency.GetElementsByTagName("Unit").Item(0).InnerText;

                doviz.DovizAdi = isim;
                if (!string.IsNullOrEmpty(alisFiyati))
                {
                    doviz.AlisFiyati = Convert.ToDouble(alisFiyati);
                    //doviz.AlisFiyati = Convert.ToDouble(alisFiyati,CultureInfo.GetCultureInfo("en-US")); replace yerine cultureınfo da kullanılabılır.
                }

                if (!string.IsNullOrEmpty(satisFiyati))
                {
                    doviz.SatisFiyati = Convert.ToDouble(satisFiyati);
                }

                if (!string.IsNullOrEmpty(satisFiyati))
                {
                   doviz.Birim = Convert.ToInt32(birim);
                }
               

                listBox1.Items.Add(doviz);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doviz d = listBox1.SelectedItem as Doviz;

            double para = Convert.ToDouble(textBox1.Text);
            double sonuc=para/(d.AlisFiyati/d.Birim);
            lblSonuc.Text = sonuc.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doviz d = listBox1.SelectedItem as Doviz;

            lblAlisFiyati.Text = d.AlisFiyati.ToString();
            lblSatisFiyati.Text = d.SatisFiyati.ToString();
            lblBirim.Text = d.Birim.ToString();

           
   
        }
    }
}
