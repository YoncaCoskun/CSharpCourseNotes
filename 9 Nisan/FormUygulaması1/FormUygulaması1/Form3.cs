using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulaması1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAskerEkle_Click(object sender, EventArgs e)
        {          
            string[] isimler;
            isimler = textBox1.Text.Split();

            if (textBox1.Text == "" || textBox1.Text == null)
            {
                MessageBox.Show("Lütfen bir asker ismi giriniz");
            }


            else
            {
                Boolean kontrol = true;
                foreach (object item in lstAskerler.Items)
                {
                    if (item.ToString()==textBox1.Text)
                    {
                        kontrol = false;
                    }
                }
                if (kontrol)
                {
                   
                    lstAskerler.Items.Add(textBox1.Text);

                
                }
                
            }
            textBox1.Clear();




           
            
        }

        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
      
            string[] sehirler;
            sehirler = textBox2.Text.Split();

            if (textBox2.Text == "" || textBox2.Text == null)
            {
                MessageBox.Show("Lütfen bir sehir ismi giriniz");
            }

            else
            {

                for (int i = 0; i < sehirler.Length; i++)
                {
                    lstSehirler.Items.Add(sehirler[i]);

                }
              
               
            }
            textBox2.Clear();

            
            
        }

        private void btnDagit_Click(object sender, EventArgs e)
        {

            string[] sehirYedek=new string[lstSehirler.Items.Count];
            for (int i = 0; i < lstSehirler.Items.Count; i++)
            {
                sehirYedek[i]=lstSehirler.Items[i].ToString();
            }

            Random rnd = new Random();

            for (int i = 0; i < lstAskerler.Items.Count; i++)
            {
                int sehirIndex = rnd.Next(lstSehirler.Items.Count);
                string veri=lstAskerler.Items[i]+"--"+lstSehirler.Items[sehirIndex];
                lstSehirler.Items.RemoveAt(sehirIndex);
                lstDagitim.Items.Add(veri);

                if (lstSehirler.Items.Count==0)
                {
                    lstSehirler.Items.AddRange(sehirYedek);
                }
            }
            lstSehirler.Items.Clear();
            lstSehirler.Items.AddRange(sehirYedek);
        }

       
    }
}
