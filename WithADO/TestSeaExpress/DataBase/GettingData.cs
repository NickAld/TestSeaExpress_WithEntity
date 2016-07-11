using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace DataBase
{
    public partial class Connector
    {
        string commGetAllUsers = "exec GetUsers";
        string commGetUserOnID = "exec GetUser {0}";

        public List<Person> GetUsers()
        {
            List<Person> users = new List<Person>();

            var adapter = GetSelectAdapter(commGetAllUsers);

            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
                if (table!=null)
                foreach(DataRow r in table.Rows)
                    {
                        users.Add(new Person()
                        {
                            UserID = Convert.ToInt32(r["id"].ToString()),
                            FirstName = r["FirstName"].ToString(),
                            LastName = r["LastName"].ToString(),
                            MiddleName = r["MiddleName"].ToString(),
                            Email = r["Email"].ToString()
                    });
                    }
                return users;
                
            }
            catch
            {

            }

            return users;
        }

        public Person GetUserOnID(int id)
        {
            var adapter = GetSelectAdapter(String.Format(commGetUserOnID,id));

            try
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table != null)
                    foreach (DataRow r in table.Rows)
                    {
                        if (Convert.ToInt32(r["id"].ToString()) == id)
                        {
                            var p = new Person()
                            {
                                UserID = Convert.ToInt32(r["id"].ToString()),
                                FirstName = r["FirstName"].ToString(),
                                LastName = r["LastName"].ToString(),
                                MiddleName = r["MiddleName"].ToString(),
                                Email = r["Email"].ToString()
                            };
                            return p;
                        }

                    }
                return null;

            }
            catch
            {
                return null;
            }
        }
    }
}
