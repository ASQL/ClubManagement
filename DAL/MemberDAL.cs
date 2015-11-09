using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MemberDAL
    {
        private DBConnection connection;

        public MemberDAL()
        {
            connection = new DBConnection();
        }

        public DataTable SearchByID(String id)
        {
            String query="select * from Member where MemberID like @id";
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@id",id)
            };
            return connection.ExecuteSelectQuery(query, parameters, CommandType.Text);
        }
    }
}
