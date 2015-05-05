using NorthwindEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL
{
    public class UrunDal
    {
        // katmanlar
        // DAL              Veri tabanına erişen katmandır
        // Entity           bilgi taşıyan katmandır.
        // Presentation     Kullanıcının gördüğü ekranların bulunduğu katmandır.
        // BLL              Hatalara karşı alınacak aksiyonlar katmanıdır.

        public bool Kaydet(UrunEntity kaydedilecek)
        {
            SqlConnection con = new SqlConnection(Tanimlar.conStringi);
            SqlCommand cmd = new SqlCommand("insert into Products(ProductName,UnitPrice,UnitsInStock) values (@p1,@p2,@p3) select scope_identity()", con);
            cmd.Parameters.AddWithValue("@p1", kaydedilecek.UrunAdi);
            cmd.Parameters.AddWithValue("@p2", kaydedilecek.BirimFiyat);
            cmd.Parameters.AddWithValue("@p3", kaydedilecek.StokMiktari);

            con.Open();
            object sonuc = cmd.ExecuteScalar();
            con.Close();

            if (sonuc != null)
            {
                kaydedilecek.UrunId = Convert.ToInt32(sonuc);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Guncelle(UrunEntity guncellenecek)
        {
            SqlConnection con = new SqlConnection(Tanimlar.conStringi);
            SqlCommand cmd = new SqlCommand("update Products set ProductName=@p1,UnitPrice=@p2,UnitsInStock=@p3 where ProductId = @p4", con);
            cmd.Parameters.AddWithValue("@p1", guncellenecek.UrunAdi);
            cmd.Parameters.AddWithValue("@p2", guncellenecek.BirimFiyat);
            cmd.Parameters.AddWithValue("@p3", guncellenecek.StokMiktari);
            cmd.Parameters.AddWithValue("@p4", guncellenecek.UrunId);
            con.Open();
            int sayi = cmd.ExecuteNonQuery();
            con.Close();
            if (sayi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<UrunEntity> urunleriVer()
        {
            List<UrunEntity> liste = new List<UrunEntity>();
            SqlConnection con = new SqlConnection(Tanimlar.conStringi);
            SqlCommand cmd = new SqlCommand("select * from Products", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                UrunEntity u = new UrunEntity();
                u.UrunAdi = rdr["ProductName"].ToString();
                u.UrunId = Convert.ToInt32(rdr["ProductID"]);
                u.BirimFiyat = Convert.ToDouble(rdr["UnitPrice"]);
                u.StokMiktari = Convert.ToInt32(rdr["UnitsInStock"]);
                liste.Add(u);
            }

            con.Close();

            return liste;
        }
    }
}
