using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSerilizasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //----------------------Class ları Serilize etme----------------------------------------------------------
            //--------------------------------------------------------------------------------------------------------
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrenciAdi = "Mustafa";
            ogrenci.OgrenciSoyadi = "Keser";
            ogrenci.Cinsiyet = true;
            ogrenci.EvAdresi = "Erzurum";
            ogrenci.Telefon = "11546589";

            FileStream fs = new FileStream("Ogrenci.mhs", FileMode.OpenOrCreate);

            BinaryFormatter formatlayici = new BinaryFormatter();   //ogrenci nesnesini filestreamın ıstedıgı sekılde formatlar.(bu yontemle)
            formatlayici.Serialize(fs, ogrenci);  //ogrencı nesnesını alır fılestream e hazırlar ve serılıze eder.
            fs.Close();
            MessageBox.Show("işlem tamamlandı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Ogrenci.mhs", FileMode.OpenOrCreate);

            BinaryFormatter formatlayici = new BinaryFormatter();
            Ogrenci gelen = (Ogrenci)formatlayici.Deserialize(fs);
            fs.Close();
            MessageBox.Show(gelen.ToString());  //override dan kaynaklı mesajbox ta mustafa keser gorulur.

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Ogrenci> liste = new List<Ogrenci>();

            for (int i = 0; i < 10; i++)
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.OgrenciAdi = Faker.NameFaker.FirstName();
                ogrenci.OgrenciSoyadi = Faker.NameFaker.LastName();
                ogrenci.Cinsiyet = Faker.BooleanFaker.Boolean();
                ogrenci.EvAdresi = Faker.LocationFaker.City();
                ogrenci.Telefon = Faker.PhoneFaker.Phone();

                liste.Add(ogrenci);
            }
            FileStream fs = new FileStream("Ogrenciler.dat",FileMode.OpenOrCreate);
            BinaryFormatter formatlayici = new BinaryFormatter();
            formatlayici.Serialize(fs,liste);
            fs.Close();
            MessageBox.Show("islem tamamlandı.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Ogrenciler.dat",FileMode.OpenOrCreate);
            BinaryFormatter formatlayici = new BinaryFormatter();
            List<Ogrenci> ogrenciler = (List<Ogrenci>)formatlayici.Deserialize(fs);
            fs.Close();

            foreach (Ogrenci item in ogrenciler)
            {
                MessageBox.Show(item.ToString()+" "+item.Cinsiyet);
            }
        }
    }
}
