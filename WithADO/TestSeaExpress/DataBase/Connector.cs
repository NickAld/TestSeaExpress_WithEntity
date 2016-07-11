using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public partial class Connector
    {
        SqlConnection conn;
        string connectionString;
            
        public Connector(string connStr)
        {
            connectionString = connStr;
        }

        public bool Connect()
        {
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public SqlDataAdapter GetSelectAdapter(string comm)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = conn;
            adapter.SelectCommand.CommandType = System.Data.CommandType.Text;
            adapter.SelectCommand.CommandText = comm;
            return adapter;
        }

        public SqlCommand GetDeleteAdapter(string comm)
        {
            SqlCommand command = new SqlCommand(comm, conn);
            command.CommandType = CommandType.Text;
            return command;
        }

        public SqlCommand GetUpdateAdapter(string comm)
        {
            SqlCommand command = new SqlCommand(comm, conn);
            command.CommandType = CommandType.Text;
            return command;
            
        }



    }
}
