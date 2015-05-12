using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsenkronHatasiCozumu
{
    public partial class frmLambdaIleCozum : Form
    {
        public frmLambdaIleCozum()
        {
            InitializeComponent();
        }

        //-------------------------------LAMBDA TEKNOLOJISI ILE ASENKRON HATASININ COZUMUNUN YAPILMASI------------------------

        delegate void gridDoldurDelege();
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(() =>
            {

                SqlDataAdapter adapter = new SqlDataAdapter("select * from [Order Details]", "server=.;database=northwind;integrated security=sspi;");
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                dataGridView1.Invoke(new gridDoldurDelege(() =>
                {
                    dataGridView1.DataSource = datatable;

                }));

            });
            Thread t = new Thread(ts);
            t.Start();
        }



        delegate double kdvHesaplaDelege(double kdvOrani);
        private void button2_Click(object sender, EventArgs e)
        {
            //asenkron sekılde verıtabanındakı butun urunlerın stok maliyetinin KDV sini hesaplayacak ve onu listbox a aktaracak bir yapı hazırlayınız.(delegeyi asenkron calıstırmak)

            kdvHesaplaDelege delege = new kdvHesaplaDelege((oran) =>
            {
                DataTable datatable = new DataTable();
                new SqlDataAdapter("select sum(UnitsInStock*UnitPrice) from Products", "server=.;database=northwind;integrated security=sspi;").Fill(datatable);

                double rakam = Convert.ToDouble(datatable.Rows[0][0]);
                double kdv = rakam * oran;
                return kdv;

            });

            delege.BeginInvoke(0.18, new AsyncCallback((sonuc) => {
                if (sonuc.IsCompleted)
                {
                 double kdv=delege.EndInvoke(sonuc);
                 MessageBox.Show(kdv.ToString("c",CultureInfo.GetCultureInfo("en-US")));
                }
            }),null);




        }

        private void button3_Click(object sender, EventArgs e)
        {
            var data = new {ogrenciAdi="Yonca",ogrenciSoyadi="Coskun"   };

            MessageBox.Show(data.ogrenciAdi);

            //bunun guncellemesını falan yapamıyoruz.sadece lınq te kullanmalıyız.dıger turlu ıse yaramaz.

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
    }
}
