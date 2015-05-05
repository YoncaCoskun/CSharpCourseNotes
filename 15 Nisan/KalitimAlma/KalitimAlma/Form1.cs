using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalitimAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //-------------------------KALITIM---------------------------

        //form un atası object dir
        private void button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.PersonelAdi = "";
            p.KartBas();

            Mühendis m = new Mühendis();
            m.PersonelAdi = "";
            m.KartBas();
            m.DiplomaNumarasi = "";

            BilgisayarMühendisi bm = new BilgisayarMühendisi();
            bm.PersonelAdi = "";
            bm.DiplomaNumarasi = "";

            BMW araba = new BMW();

            Ekran ek = new Ekran();
            ek.Show();
            
            
        }
    }
}
