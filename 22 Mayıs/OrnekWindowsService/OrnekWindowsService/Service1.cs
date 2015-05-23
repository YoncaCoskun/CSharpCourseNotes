using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OrnekWindowsService
{
    public partial class Service1 : ServiceBase
    {
        Timer tmr = new Timer();
        public Service1()
        {
          Islemler();
        }

       public void Islemler()
        {
            InitializeComponent();
            tmr.Interval = 100;
            tmr.Elapsed += tmr_Elapsed;  //form daki timer tick gorevini gorur.
            tmr.Start();
        }
        void tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            tmr.Stop();  //bir önceki islemi bitirmeden baska bır ıse gecmesın dıe timer ı durduruyoruz ıslemı yapınca tekrar başlatıyoruz.
           // StreamWriter yazici=new StreamWriter(@"C:\Dosyalar\deneme.txt",true); //true vermemızın sebebı silip tekrar yazmak yerıne ustune ekleme append  yapması ıcın.
            StreamWriter yazici = new StreamWriter(@"C:\Dosyalar\"+Guid.NewGuid()+".ync");  //benzersiz id uretmek ıcın guid kullanılır.ync istedigimiz herhangi birseyi uzanti olarak yazabiliriz.
            yazici.WriteLine(DateTime.Now);
            yazici.Close();
            tmr.Start();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
