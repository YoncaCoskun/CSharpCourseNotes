using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace XML_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kisiler = new List<Kisi>();
        }

        List<Kisi> kisiler;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbCinsiyet.SelectedIndex = 0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                TelefonNumarasi = txtTelefon.Text,
                Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                Fotograf = File.ReadAllBytes(pbFotograf.ImageLocation)
            };
            kisiler.Add(kisi);
            ListeyiDoldur(lstKisiler, kisiler);
            Kisi.FormuTemizle(this);
        }

        private void ListeyiDoldur(ListBox lstKisiler, List<Kisi> kisiler)
        {
            lstKisiler.Items.Clear();
            foreach (Kisi item in kisiler)
            {
                lstKisiler.Items.Add(item);
            }
        }

        private void pbFotograf_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Fotoğraf Ekle";
            dosyaAc.Filter = "(*.jpg)|*.jpg";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.Multiselect = false;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                pbFotograf.ImageLocation = dosyaAc.FileName;
            }
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Kisi secilenKisi = lstKisiler.SelectedItem as Kisi;

            txtAd.Text = secilenKisi.Ad;
            txtSoyad.Text = secilenKisi.Soyad;
            txtTelefon.Text = secilenKisi.TelefonNumarasi;
            dtpDogumTarihi.Value = secilenKisi.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (int)secilenKisi.Cinsiyet;

            MemoryStream hamResim = new MemoryStream(secilenKisi.Fotograf);
            pbFotograf.Image = Image.FromStream(hamResim);
        }

        private void btnXMLDisari_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "XML Formatında Kaydet";
            dosyaKaydet.Filter = "(*.xml)|*.xml";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter writer = new StreamWriter(dosyaKaydet.FileName);
                serializer.Serialize(writer, kisiler);
                writer.Close();
                writer.Dispose();
                MessageBox.Show("XML Formatında Kaydedildi", "XML Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXMLIceri_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "XML Dosyası Aç";
            dosyaAc.Filter = "(*.xml)|*.xml";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextReader reader = new StreamReader(dosyaAc.FileName);
                kisiler = (List<Kisi>)serializer.Deserialize(reader);
                reader.Close();
                reader.Dispose();
                ListeyiDoldur(lstKisiler, kisiler);
                MessageBox.Show("XML Datası Okundu", "XML Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDisariJson_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "JSON Formatında Kaydet";
            dosyaKaydet.Filter = "(*.json)|*.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(dosyaKaydet.FileName, FileMode.OpenOrCreate);
                StreamWriter sr = new StreamWriter(dosya);
                sr.Write(JsonConvert.SerializeObject(kisiler));
                sr.Close();
                sr.Dispose();
                dosya.Close();
                MessageBox.Show("JSON Formatında Kaydedildi", "JSON Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIceriJson_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "JSON Dosyası Aç";
            dosyaAc.Filter = "(*.json)|*.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.OpenRead(dosyaAc.FileName);
                StreamReader sr = new StreamReader(dosya);
                string okunan = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                dosya.Close();

                //kisiler = (List<Kisi>)JsonConvert.DeserializeObject(okunan, typeof(List<Kisi>));
                kisiler = JsonConvert.DeserializeObject<List<Kisi>>(okunan);

                ListeyiDoldur(lstKisiler, kisiler);
                MessageBox.Show("JSON Datası Okundu", "JSON Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
