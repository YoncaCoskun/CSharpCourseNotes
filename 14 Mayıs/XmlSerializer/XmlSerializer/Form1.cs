using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XmlSerializer_ORNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //-------------------------------XML SERIALIZER-------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("tarih.xml",FileMode.OpenOrCreate);


            //herhangı bır bılgıyı xml formatında yazdırmaksa:

            XmlSerializer formatlayici = new XmlSerializer(typeof(DateTime));
            formatlayici.Serialize(fs,DateTime.Now);
            fs.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("tarih.xml", FileMode.OpenOrCreate);

            //herhangı bır bılgıyı xml formatında okuma:
            XmlSerializer formatlayici = new XmlSerializer(typeof(DateTime));
            DateTime tarih = (DateTime)formatlayici.Deserialize(fs);
            fs.Close();
            MessageBox.Show(tarih.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Class ı xml olarak yazma islemi

            Haber haber = new Haber();
            haber.HaberId = 1;
            haber.HaberBasligi = "Adam kopegi isirdi";
            haber.HaberIcerik = "Adamın kuduz olup olmadıgı arastırılıyor.";
            haber.HaberTarihi = DateTime.Now.AddDays(-3);

            FileStream fs = new FileStream("Haber.xml",FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Haber));
            xml.Serialize(fs,haber);
            fs.Close();
            MessageBox.Show("islem tamam");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Class ı xml olarak okuma islemi

            FileStream fs = new FileStream("Haber.xml", FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Haber));
            Haber haber= (Haber)xml.Deserialize(fs);
            fs.Close();
            MessageBox.Show(haber.HaberBasligi+"\n"+haber.HaberIcerik);
        }


    }
}
