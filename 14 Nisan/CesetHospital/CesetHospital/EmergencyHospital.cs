using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CesetHospital
{
    public partial class EmergencyHospital : Form
    {
        public EmergencyHospital()
        {
            InitializeComponent();
        }
        List<Doktor> doktorlar1=new List<Doktor>;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Doktor newDoktor = new Doktor();

            newDoktor.DoktorAdi = txtDoktorAdi.Text;
            newDoktor.DoktorSoyadi = txtDoktorSoyadi.Text;
            newDoktor.Brans = cmbBrans.SelectedItem.ToString();

            doktorlar1.Add(newDoktor);
            lstDoktorlar.Items.Add(newDoktor.kendiniTanit());


        }

    }
}
