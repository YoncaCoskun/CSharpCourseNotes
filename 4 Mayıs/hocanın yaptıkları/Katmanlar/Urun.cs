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
        public int UrunId { get; private set; }
        public string UrunAdi { get; set; }
        public double BirimFiyat { get; set; }
        public int StokMiktari { get; set; }
        public override string ToString()
        {
            return UrunAdi;
        }

        public bool Kaydet()
        {
            SqlConnection con = new SqlConnection(Tanimlar.conStringi);
            SqlCommand cmd = new SqlCommand("insert into Products(ProductName,UnitPrice,UnitsInStock) values (@p1,@p2,@p3) select scope_identity()", con);
            cmd.Parameters.AddWithValue("@p1", UrunAdi);
            cmd.Parameters.AddWithValue("@p2", BirimFiyat);
            cmd.Parameters.AddWithValue("@p3", StokMiktari);

            con.Open();
            object sonuc = cmd.ExecuteScalar();
            con.Close();

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
            SqlConnection con = new SqlConnection(Tanimlar.conStringi);
            SqlCommand cmd = new SqlCommand("update Products set ProductName=@p1,UnitPrice=@p2,UnitsInStock=@p3 where ProductId = @p4",con);
            cmd.Parameters.AddWithValue("@p1", UrunAdi);
            cmd.Parameters.AddWithValue("@p2", BirimFiyat);
            cmd.Parameters.AddWithValue("@p3", StokMiktari);
            cmd.Parameters.AddWithValue("@p4", UrunId);
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

        public static List<Urun> urunleriVer()
        {
            List<Urun> liste = new List<Urun>();
            SqlConnection con = new SqlConnection(Tanimlar.conStringi);
            SqlCommand cmd = new SqlCommand("select * from Products", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Urun u = new Urun();
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
