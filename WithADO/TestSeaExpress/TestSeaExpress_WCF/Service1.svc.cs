using System;
using System.Collections.Generic;
using System.Linq;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;



using DataBase;

namespace TestSeaExpress_WCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        DataBase.Connector myConnector;

        public Service1(string connStr)
        {
            myConnector = new Connector(connStr);
            myConnector.Connect();
        }

        public void AddUser(Person user)
        {
            try
            {
                myConnector.AddUser(user);
                //db.Users.Add(user);
                //db.SaveChanges();
            }
            catch { }
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public Person GetNewUser()
        {
            return new Person();
        }

        public Person GetuserOnId(int id)
        {
            try
            {
                Person p = myConnector.GetUserOnID(id);

                
                return p;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Person> GetUsers()
        {
            return myConnector.GetUsers();
        }


        public void RemoveUser(int idUser)
        {
            try
            {
                myConnector.RemovePerson(idUser);
            }
            catch (Exception ex)
            {

            }
        }

        public void UpdateUser(Person user)
        {
            try
            {
                myConnector.UpdateUser(user);
            }
            catch { }
        }
    }
}
