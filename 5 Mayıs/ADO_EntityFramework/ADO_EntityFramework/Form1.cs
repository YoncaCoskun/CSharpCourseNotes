using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EntityFrameworkModelFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();
            //--------------------------------------ADO.NET-------------------------------------------
            //eger veri tabanımız var ama class larımız veri tabanından olusturulacaksa buna dbFirst denir

            //eger class larımızı kodlarla yazacaksak buna codeFirst denir.

            //eger class diagramından class lar yapıp db oluşturacaksak buna modelFirst denir.

            //ado.framework te 3 farklı cesit var.
            //Bunlar:  dbFirst  ,     codeFirst   ,   modelFirst

        }
        OkulDbContainer data = new OkulDbContainer();
        private void button1_Click(object sender, EventArgs e)
        {
            Veli veli = new Veli();

            veli.VeliAdi = textBox1.Text;
            veli.VeliSoyadi = textBox2.Text;

            
            data.Veliler.Add(veli);
            data.SaveChanges();  //veritabanına insert yapmaya yarıyor direk olarak insert yapıyor
            doldur();
            temizle();

        }

        private void temizle()
        {

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.ResetText();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void doldur()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(data.Veliler.ToArray());
        }

        Veli guncellenecekVeli;
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            guncellenecekVeli=listBox1.SelectedItem as Veli;
            textBox1.Text = guncellenecekVeli.VeliAdi;
            textBox2.Text = guncellenecekVeli.VeliSoyadi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            guncellenecekVeli.VeliAdi = textBox1.Text;
            guncellenecekVeli.VeliSoyadi = textBox2.Text;

            data.SaveChanges();
            doldur();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data.Veliler.Remove(listBox1.SelectedItem as Veli);
            data.SaveChanges();
            doldur();
            temizle();
        }

       
    }
}
