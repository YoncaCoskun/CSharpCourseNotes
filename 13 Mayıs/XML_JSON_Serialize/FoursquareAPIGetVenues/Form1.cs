using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoursquareAPIGetVenues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FoursTool frm = new FoursTool();
        private void btnGetir_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(frm.jsonString))
            {
                MessageBox.Show("Henuz data okuyamadım");
            }
            else
            {
                frm.verileriBas();

                MessageBox.Show(frm.Firmalar.Count.ToString());
            }
        }
    }
}
