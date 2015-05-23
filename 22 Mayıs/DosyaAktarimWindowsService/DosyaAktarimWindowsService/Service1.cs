using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DosyaAktarimWindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            Thread.Sleep(15000);

            Calis();
        }

        protected override void OnStart(string[] args)
        {
            LogYaz("Servis Başlatıldı");
        }

        protected override void OnStop()
        {
            LogYaz("Servis Durduruldu");
        }

        void Calis()
        {
            try
            {
                DirectoryInfo klasorler = new DirectoryInfo(@"C:\Dosyalar");
                FileInfo[] dosyalar = klasorler.GetFiles();
                SqlConnection cnn = new SqlConnection("Server=.;database=Northwind;uid=sa;pwd=1");

                foreach (FileInfo dosya in dosyalar)
                {
                    StreamReader okuyucu = dosya.OpenText();
                    string satir;
                    while ((satir = okuyucu.ReadLine()) != null)
                    {
                        //7;2450;404
                        string[] urunBilgileri = satir.Split(';');
                        string urunId = urunBilgileri[0];
                        string fiyat = urunBilgileri[1];
                        string stok = urunBilgileri[2];//new DateTime(yil,ay,gun)
                        string tarih = Path.GetFileNameWithoutExtension(dosya.Name);
                        SqlCommand cmd = new SqlCommand("INSERT INTO Urunler (Id, Price, Stock, InsertDate)VALUES (@id, @price, @stock, @insertdate)", cnn);

                        cmd.Parameters.AddWithValue("@id", urunId);
                        cmd.Parameters.AddWithValue("@price", fiyat);
                        cmd.Parameters.AddWithValue("@stock", stok);
                        cmd.Parameters.AddWithValue("@insertdate", tarih);

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    okuyucu.Close();
                    //File.Delete(dosya.FullName);
                    dosya.Delete();

                    LogYaz("Dosya aktarıldı. " + dosya.Name);
                }
                Thread.Sleep(20000);
                Calis();
            }
            catch (Exception ex)
            {
                LogYaz(ex.Message);
            }
        }

        void LogYaz(string mesaj)
        {
            string folder = @"C:\Loglar";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string path = folder + @"\log.txt";

            StreamWriter logYazici = new StreamWriter(path, true);
            logYazici.WriteLine(DateTime.Now + " " + mesaj);
            logYazici.Close();
        }

    }
}
