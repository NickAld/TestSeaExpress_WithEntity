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
        string commRemove = "exec RemovePersonID {0}";

        string commUpdate = "exec UpdateUser {0},'{1}','{2}','{3}','{4}'";

        string commAdd = "exec AddUser '{0}','{1}','{2}','{3}'";

        public void RemovePerson(int id)
        {
            var adapter = GetDeleteAdapter(String.Format(commRemove, id));
            adapter.ExecuteNonQuery();
        }


        public void UpdateUser(Person person)
        {
            string commstr = String.Format(commUpdate,
                person.UserID,
                person.FirstName,
                person.LastName,
                person.MiddleName,
                person.Email);

            var adapter = GetUpdateAdapter(commstr);
            adapter.ExecuteNonQuery();
        }

        public void AddUser(Person person)
        {
            try
            {
                string commstr = String.Format(commAdd,
                    person.FirstName,
                    person.LastName,
                    person.MiddleName,
                    person.Email);

                var adapter = GetUpdateAdapter(commstr);
                adapter.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
