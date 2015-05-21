using cokKatmanli.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cokKatmanli.DAL
{
    public class CategoryDAL
    {

        public Category KategoriGetir(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;


            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand command = new SqlCommand("select * from Categories where CategoryID=@id", conn);
            command.Parameters.AddWithValue("@id", id);
            conn.Open();

            SqlDataReader reader = command.ExecuteReader();


            Category entity = new Category();

            while (reader.Read())
            {
                entity.KategoriId = Convert.ToInt32(reader["CategoryID"]);
                entity.KategoriName = reader["CategoryName"].ToString();
                entity.Description = reader["Description"].ToString();
                entity.Picture=(byte[])reader["Picture"];
                
            }



            conn.Close();
            return entity;


        }



    
    }
}
