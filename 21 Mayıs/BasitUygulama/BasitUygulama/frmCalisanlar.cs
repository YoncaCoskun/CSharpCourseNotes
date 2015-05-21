using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitUygulama
{
    public partial class frmCalisanlar : Form
    {
        public frmCalisanlar()
        {
            InitializeComponent();
        }
        NorthwindEntities context = new NorthwindEntities();

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (labelid.Text.Length > 0)  //labelid nin text inde birsey yazıyorsa update islemi yapılır.trim sagdan soldan boslukları kırpar.
            {
                int id = Convert.ToInt32(labelid.Text);
                Employee guncellenecekEmployee = context.Employees.FirstOrDefault(x => x.EmployeeID == id);
                if (guncellenecekEmployee != null)
                {
                    guncellenecekEmployee.FirstName = IlkHarfiBuyut(txtFirstName.Text.Trim());
                    guncellenecekEmployee.LastName = IlkHarfiBuyut(txtLastName.Text.Trim());
                    guncellenecekEmployee.City = txtCity.Text.Trim();
                    guncellenecekEmployee.Title = txtTitle.Text.Trim();
                }
                context.SaveChanges();

                Temizle();
                CalisanGoster();
                MessageBox.Show("Güncelleme Başarılı");


            }
            else
            {
                Employee Newemployee = new Employee();


                Newemployee.FirstName = txtFirstName.Text.Trim();
                Newemployee.LastName = txtLastName.Text.Trim();
                Newemployee.City = txtCity.Text.Trim();
                Newemployee.Title = txtTitle.Text.Trim();

                context.Employees.Add(Newemployee);
                context.SaveChanges();

                CalisanGoster();
                MessageBox.Show("Kayıt Başarılı");
            }



        }

        private void frmCalisanlar_Load(object sender, EventArgs e)
        {
           //load dda calısanları getırmek

            CalisanGoster();
        }

        private void CalisanGoster()
        {
            listView1.Items.Clear();
            var calisanlar = context.Employees;

            foreach (Employee employee in calisanlar)
            {
                ListViewItem item = new ListViewItem();
                item.Text = employee.EmployeeID.ToString();
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.City);
                item.SubItems.Add(employee.Title);

                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem seciliItem = listView1.FocusedItem;

            labelid.Text = seciliItem.Text;
            txtFirstName.Text = seciliItem.SubItems[1].Text;
            txtLastName.Text = seciliItem.SubItems[2].Text;
            txtCity.Text = seciliItem.SubItems[3].Text;
            txtTitle.Text = seciliItem.SubItems[4].Text;
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {

            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtTitle.Clear();
            labelid.Text = String.Empty;

        }

        private string IlkHarfiBuyut(string deger)
        {
            string ilkHarf = deger.Substring(0, 1);
            string kalani = deger.Substring(1);

            return ilkHarf.ToUpper() + kalani.ToLower();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.FocusedItem==null)
            {
                return;
            }
         DialogResult sonuc=  MessageBox.Show("Emin misin", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc==DialogResult.Yes)
            {
                int id = Convert.ToInt32(labelid.Text);
                Employee silinecekEmployee = context.Employees.FirstOrDefault(x => x.EmployeeID == id);
                context.Employees.Remove(silinecekEmployee);
                context.SaveChanges();
                Temizle();
                CalisanGoster();
                MessageBox.Show("Kayıt Silindi");
            }
        }
    }
}
