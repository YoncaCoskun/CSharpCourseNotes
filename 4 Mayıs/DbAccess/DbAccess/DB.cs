using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccess
{
    public class DB
    {
        public static string connectStringi;
      
        private static SqlCommand commandOlustur(string sorgu,bool procMu,params SqlParameter[] parametreler)
        {
            SqlConnection connect= new SqlConnection(connectStringi);
            SqlCommand command = new SqlCommand(sorgu,connect);

            if (procMu)
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
            }
            foreach (SqlParameter item in parametreler)
            {
                command.Parameters.Add(item);
            }
            connect.Open();
            return command;
        }
        public static object executeScalar(string sorgu,bool procMu,params SqlParameter[] parametreler)
        {
            SqlCommand command= commandOlustur(sorgu, procMu, parametreler);
            object sonuc = command.ExecuteScalar();
            command.Connection.Close();
            return sonuc;
        }
        public static int executeNonQuery(string sorgu,bool procMu,params SqlParameter[] parametreler)
        {
            SqlCommand command = commandOlustur(sorgu,procMu,parametreler);
            int sonuc = command.ExecuteNonQuery();
            command.Connection.Close();
            return sonuc;
        }
        public static SqlDataReader executeReader(string sorgu, bool procMu, params SqlParameter[] parametreler)
        {
            SqlCommand command = commandOlustur(sorgu,procMu,parametreler);
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);  //connectiona close demesıne gerek kalmaması ıcın commandbehavıor kullandık.

            return reader;
        }

        public static DataTable executeDataTable(string sorgu, bool procMu, params SqlParameter[] parametreler)
        {
            SqlCommand command = commandOlustur(sorgu, procMu, parametreler);
            SqlDataReader reader = command.ExecuteReader();
            DataTable datatable = new DataTable();
            datatable.Load(reader);

            reader.Close();
            command.Connection.Close();

            return datatable;
        }
        public static DataTable executeDataAdapter(string sorgu, bool procMu, params SqlParameter[] parametreler)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu,connectStringi);
            if (procMu)
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            }
            foreach (SqlParameter item in parametreler)
            {
                adapter.SelectCommand.Parameters.Add(item);
            }
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            return datatable;
        }

    }

}
