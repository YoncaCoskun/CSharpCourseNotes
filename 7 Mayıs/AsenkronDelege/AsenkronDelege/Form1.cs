using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsenkronDelege
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //thread arası bırbırıne erısım yoktur bunun icin illegal erısımlere ızın vermemız gerekır.Bunu ıcın;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void AtesEt()
        {
            for (int i = 0; i < 100; i++)
            {
                lstAtesEt.Items.Add(i);
                lstAtesEt.SelectedIndex = lstAtesEt.Items.Count - 1;
            }
        }

        void TurboMotorAc()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lstTurboMotor.Items.Add(i);
                lstTurboMotor.SelectedIndex = lstTurboMotor.Items.Count - 1;
            }
        }

        void RoketAt()
        {
            lstRoketAt.Items.Add(1);
            lstRoketAt.SelectedIndex = lstRoketAt.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtesEt();
        }

        delegate void TurboMotorAcDelege();  //ana therad ı mesgul etmesın dıye delege kullanıyoruz.
        private void button2_Click(object sender, EventArgs e)
        {
           

            AsyncCallback isBitisi = new AsyncCallback(isiBitir);

            TurboMotorAcDelege delege = new TurboMotorAcDelege(TurboMotorAc);
            delege.BeginInvoke(isBitisi,delege);  //bunu altına ne yazarsan yaz hepsı calısır fakat endınvoke ta calısmaz.
        }

        void isiBitir(IAsyncResult sonuc)
        {
            //isbitirlince bu asenkron olarak bu metot calısır.Gercekten ıs bıtısı var mı yokmu kontrol edılmesı gerekıyoru bunun ıcın;

            if (sonuc.IsCompleted)
            {
                TurboMotorAcDelege delege= sonuc.AsyncState as TurboMotorAcDelege;  //is bitisinn ordakı delegeye ne yukledıysen burada onu cagrımıs oluruz.
                delege.EndInvoke(sonuc);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoketAt();
        }
    }
}
