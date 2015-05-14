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

namespace SerializeOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Kayitlar.dat"))
            {
                FileStream fs = new FileStream("Kayitlar.dat", FileMode.Open);
                BinaryFormatter formatlayici = new BinaryFormatter();
                kayitlar = (List<OyunKayit>)formatlayici.Deserialize(fs);
                fs.Close();
            }
            else
            {
                kayitlar = new List<OyunKayit>();
            }
            menuAc();
        }

        private void menuAc()
        {
            SeffafForm form = new SeffafForm();
            form.Tag = this;
            DialogResult sonuc = form.ShowDialog();

            if (sonuc == System.Windows.Forms.DialogResult.Abort)
            {
                this.Close();
            }
        }

        public void oyunaBasla()
        {
            timer1.Start();
        }

        public void oyunuDurdur()
        {
            timer1.Stop();
        }

        public List<OyunKayit> kayitlar;
        public void oyunKaydet(OyunKayit kayit)
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox)
                {
                    PictureBox resim = item as PictureBox;
                    Kelebek k = resim.Tag as Kelebek;
                    kayit.Kelebekler.Add(k);
                }
            }
            kayit.Skor = skor;

            for (int i = 0; i < kayitlar.Count; i++)
            {
                if (kayitlar[i].KayitAdi == kayit.KayitAdi)
                {
                    kayitlar[i] = kayit;

                    FileStream fs = new FileStream("Kayitlar.dat", FileMode.OpenOrCreate);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, kayitlar);
                    fs.Close();
                    return;
                }
            }

            kayitlar.Add(kayit);

            FileStream fs1 = new FileStream("Kayitlar.dat", FileMode.OpenOrCreate);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter1.Serialize(fs1, kayitlar);
            fs1.Close();
        }

        public void kayitAc(OyunKayit kayit)
        {
            skor = kayit.Skor;
            lblSkor.Text = string.Format("Skor : {0}", skor);
            this.Controls.Clear();
            this.Controls.Add(lblSkor);
            foreach (Kelebek item in kayit.Kelebekler)
            {
                PictureBox p = new PictureBox();
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                //p.Image = Image.FromFile(@"kelebek\" + resimler[item.kelebekIndex]);
                p.Image = Image.FromFile(@"kelebek\k3.gif");
                p.Width = item.genislik;
                p.Height = item.yukseklik;
                p.Location = new Point(item.xKoord, item.yKoord);
                p.Tag = item;
                p.Click += resim_Click;
                this.Controls.Add(p);
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                oyunuDurdur();
                SeffafForm form = new SeffafForm();
                form.Tag = this;
                DialogResult sonuc = form.ShowDialog();

                if (sonuc == System.Windows.Forms.DialogResult.Abort)
                {
                    this.Close();
                }
            }
        }

        Random rnd = new Random();

        int kelebekUretim = 0;
        string[] resimler = { "k1.gif","k2.gif","k3.gif" };
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox)
                {
                    PictureBox resim = item as PictureBox;
                    Kelebek k = resim.Tag as Kelebek;
                    k.xKoord += rnd.Next(-10, 10);
                    k.yKoord += rnd.Next(-10, 10);
                    resim.Top = k.yKoord;
                    resim.Left = k.xKoord;
                }
            }

            kelebekUretim++;
            if (kelebekUretim == 5)
            {
                if (this.Controls.Count > 10)
                {
                    timer1.Stop();
                    this.Controls.Clear();
                    skor = 0;
                    lblSkor.Text = "Skor : 0";
                    this.Controls.Add(lblSkor);
                    MessageBox.Show("Oyunu kaybettiniz.");
                    menuAc();
                }

                kelebekUretim = 0;
                Kelebek k = new Kelebek();
                k.kelebekIndex = (byte)rnd.Next(resimler.Length);
                k.xKoord = rnd.Next(this.Width - k.genislik);
                k.yKoord = rnd.Next(this.Height - k.yukseklik);

                PictureBox resim = new PictureBox();
                resim.SizeMode = PictureBoxSizeMode.StretchImage;
                resim.Width = k.genislik;
                resim.Height = k.yukseklik;
                resim.Top = k.yKoord;
                resim.Left = k.xKoord;
                //resim.Image = Image.FromFile(@"kelebek\" + resimler[k.kelebekIndex]);
                resim.Image = Image.FromFile(@"kelebek\k3.gif");
                resim.Tag = k;

                resim.Click += resim_Click;
                this.Controls.Add(resim);
                
            }
        }
        int skor = 0;
        void resim_Click(object sender, EventArgs e)
        {
            skor++;
            lblSkor.Text = string.Format("Skor : {0}", skor);
            this.Controls.Remove(sender as Control);
        }
    }
}
