using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arayuzler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MahsunGulhan mg = new MahsunGulhan();
            Erkek ek = new MahsunGulhan();

            ElifOzen eo = new ElifOzen();
            Kadin kd = new ElifOzen();

            //Kadin k = new BulentErsoy();
            //Erkek er = new BulentErsoy();

            IKadin ik = new BulentErsoy();
            IErkek ie = new BulentErsoy();

            ik.makyajYap();
            ie.tirasOl();
        }
    }
}
