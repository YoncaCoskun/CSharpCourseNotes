using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokYonluluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Polis p = new Polis();

           Otomobil o=new Otomobil();

           Kamyon k = new Kamyon();

           Motosiklet m = new Motosiklet();


            p.cezaKes(o);
            p.cezaKes(k);
            p.cezaKes(m);
        }

       
    }
}
