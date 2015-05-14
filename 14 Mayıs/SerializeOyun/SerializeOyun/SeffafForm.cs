using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeOyun
{
    public partial class SeffafForm : Form
    {
        public SeffafForm()
        {
            InitializeComponent();
        }

        private void SeffafForm_Load(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm();
            mf.Tag = this;
            DialogResult gelenCevap = mf.ShowDialog();
            
            this.DialogResult = mf.DialogResult;
            this.Close();
        }
    }
}
