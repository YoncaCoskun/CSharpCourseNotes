using OkulLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //cıkıs a basınca form kapanır.
        }

        private void veliKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form cocuk in this.MdiChildren) //velikayıta tıkladıgımızda bırden fazla calısmasını engelledık bu donguyle.
            {
                if (cocuk is frmVeliler)
                {
                    return;
                }
            }
            frmVeliler frm = new frmVeliler();
            frm.MdiParent = this;  //from1 in cocugu oldugu gosterır
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tanimlar.Ogrenciler=new List<Ogrenci>();
            Tanimlar.Veliler = new List<Veli>();
        }
    }
}
