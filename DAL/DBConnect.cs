using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        public static const String CONNECTION_STRING="";

        private static DBConnect instance;

        private SqlConnection connection=new SqlConnection(CONNECTION_STRING);

        public static DBConnect Instance
        {
            get {
                if (instance == null)
                {
                    instance = new DBConnect();
                }
                return instance; }
        }

        private DBConnect();

        public void connect()
        {
            if (connection.State == ConnectionState.Broken || connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
