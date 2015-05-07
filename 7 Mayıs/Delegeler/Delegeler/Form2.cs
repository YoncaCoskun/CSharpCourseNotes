using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegeler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //------------------------------------------EVENT GELISTIRME----------------------------------------

        Cattle[] isiticilar = new Cattle[3];
        private void Form2_Load(object sender, EventArgs e)
        {
            isiticilar[0] = new Cattle {Markasi="Arzum"};
            isiticilar[0].KontrolEt += Form2_KontrolEt;

            isiticilar[1] = new Cattle {Markasi="Fakir" };
            isiticilar[1].KontrolEt += Form2_KontrolEt;

            isiticilar[2] = new Cattle { Markasi = "Arçelik"};
            isiticilar[2].KontrolEt += Form2_KontrolEt;

            isiGoster();
            

        }

        void Form2_KontrolEt(Cattle sender)
        {
            timer1.Stop();
            MessageBox.Show(sender.Markasi);
        }

        private void isiGoster()
        {
            progressBar1.Value=isiticilar[0].Derece;
            progressBar2.Value = isiticilar[1].Derece;
            progressBar3.Value = isiticilar[2].Derece;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Cattle item in isiticilar)
            {
                item.Derece += rnd.Next(10);
                if (!timer1.Enabled)
                {
                    break;
                }

            }
            isiGoster();

        }
    }
}
