using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oop_counterStrike.Interfaces;

namespace oop_counterStrike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AK47 keles = new AK47();
            keles.Kalibre = 5;
            keles.Menzil = 300;
            keles.Ad = "Automatic Kalashnikof";
            keles.Hasar = 94;

            G3 g3 = new G3();
            g3.Kalibre = 7;
            g3.Menzil = 150;
            g3.Ad = "Piyade Tufegi";
            g3.Hasar = 95;

            Grenade bomba = new Grenade();
            bomba.EtkiAlani = 600;
            bomba.Ad = "El bombası";
            bomba.Hasar = 99;

            Picak bicak = new Picak();
            bicak.Ad = "Süngü";
            bicak.Hasar = 57;


            comboBox1.Items.Add(g3);
            comboBox1.Items.Add(bicak);
            comboBox1.Items.Add(bomba);
            comboBox1.Items.Add(keles);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //butona tıkladıgımızda fonk ları calıssın
            string mesaj = "";
            object seciliSilah = comboBox1.SelectedItem;

            if (seciliSilah is IAtesEdebilable)
            {
                IAtesEdebilable atesliSilah = seciliSilah as IAtesEdebilable;
                mesaj+=atesliSilah.AtesEt();
                
            }
            if (seciliSilah is IKesebilable)
            {
                IKesebilable kesiciSilah = seciliSilah as IKesebilable;
                mesaj +=kesiciSilah.Kes();

            }
            if (seciliSilah is IPatlayabilable)
            {
                IPatlayabilable patlayanSilah = seciliSilah as IPatlayabilable;
                mesaj += patlayanSilah.Patla();
            }

            MessageBox.Show(mesaj);
        }
    }
}
