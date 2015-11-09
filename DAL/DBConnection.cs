using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        private SqlDataAdapter adapter;
        private SqlConnection connection;

        public DBConnection()
        {
            adapter = new SqlDataAdapter();
            connection = new SqlConnection("Data Source=KITE\\SQLEXPRESS;Initial Catalog=ClubManagement;Integrated Security=True");
        }

        private SqlConnection MakeConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public DataTable ExecuteSelectQuery(String query, SqlParameter[] parameters, CommandType cmdType)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = MakeConnection();
                cmd.CommandText = query;
                cmd.CommandType = cmdType;
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            catch (SqlException e)
            {
                throw e;
            }
            return dt;
        }

        public bool ExecuteInsertQuery(String query, SqlParameter[] parameters, CommandType cmdType)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = MakeConnection();
                cmd.CommandText = query;
                cmd.CommandType = cmdType;
                cmd.Parameters.AddRange(parameters);
                adapter.InsertCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return true;
        }

        public bool ExecuteUpdateQuery(String query, SqlParameter[] parameters, CommandType cmdType)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = MakeConnection();
                cmd.CommandText = query;
                cmd.CommandType = cmdType;
                cmd.Parameters.AddRange(parameters);
                adapter.UpdateCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                throw e;
            }
            return true;
        }
    }
}
