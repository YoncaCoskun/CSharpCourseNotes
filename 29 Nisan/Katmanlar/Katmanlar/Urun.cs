using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanlar
{
    public class Urun
    {
        public int UrunId { get; set; }

        public string UrunAdi { get; set; }

        public double BirimFiyati { get; set; }

        public int StokMiktari { get; set; }

        public override string ToString()
        {
            return this.UrunAdi;
        }


        //ISLEMLER EKSIK BUYUZDEN HOCANINKINDEN TAMAMLA
        public bool Kaydet() {
            SqlConnection connect = new SqlConnection(Tanimlar.connectStringi);
            SqlCommand command = new SqlCommand("insert into Products(ProductName,UnitPrice,UnitsInStock) values(@p1,@p2,@p3) select scope_identity()",connect);

            command.Parameters.AddWithValue("@p1",UrunAdi);
            command.Parameters.AddWithValue("@p2",BirimFiyati);
            command.Parameters.AddWithValue("@p3",StokMiktari);

            connect.Open();

            object sonuc = command.ExecuteScalar();
            connect.Close();
            if (sonuc != null)
            {
                UrunId = Convert.ToInt32(sonuc);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Guncelle()
        {

            SqlConnection connect = new SqlConnection(Tanimlar.connectStringi);
            SqlCommand command = new SqlCommand("update Products set ProductName=@p1,UnitPrice=@p2,UnitsInStock=@p3 where ProductId=@p4",connect);

            command.Parameters.AddWithValue("@p1",UrunAdi);
            command.Parameters.AddWithValue("@p2",BirimFiyati);
            command.Parameters.AddWithValue("@p3",StokMiktari);
            command.Parameters.AddWithValue("@p4",UrunId);

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();

               

        }

        //sıklıkla kullanıcagımız seyleri;
        public static List<Urun> urunleriVer() {

            List<Urun> liste = new List<Urun>();
            SqlConnection connect = new SqlConnection(Tanimlar.connectStringi);
            SqlCommand command = new SqlCommand("select * from Products",connect);
            connect.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Urun urun = new Urun();

                urun.UrunAdi=reader["ProductName"].ToString();
                urun.UrunId = Convert.ToInt32(reader["ProductID"]);
                urun.BirimFiyati = Convert.ToDouble(reader["UnitPrice"]);
                urun.StokMiktari = Convert.ToInt32(reader["UnitsInStock"]);


                liste.Add(urun);
            }
            connect.Close();
            return liste;
        }
    
    }
}
