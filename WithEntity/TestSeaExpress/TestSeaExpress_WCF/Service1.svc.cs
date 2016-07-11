using System;
using System.Collections.Generic;
using System.Linq;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Data.Entity;

using TestSeaExpress_WCF.database;

namespace TestSeaExpress_WCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        dbWork db;

        public Service1()
        {
            db = new dbWork();
        }

        public void AddUser(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            catch { }
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public User GetNewUser()
        {
            return db.Users.Create();
        }

        public User GetuserOnId(int id)
        {
            try
            {
                User user = db.Users.Where(x => x.UserID == id).FirstOrDefault();
                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DbSet<User> GetUsers()
        {
            db.Users = db.Set<User>();
            if (db.Users != null)
                foreach (var u in db.Users)
                {

                }

            return db.Users;
        }


        public void RemoveUser(int idUser)
        {
            try
            {
                db.Users.Remove(db.Users.Where(x => x.UserID.Equals(idUser)).FirstOrDefault());
                db.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                var us = db.Users.Where(x => x.UserID == user.UserID).FirstOrDefault();
                us.FirstName = user.FirstName;
                us.LastName = user.LastName;
                us.MiddleName = user.MiddleName;
                us.Email = user.Email;

                db.SaveChanges();
            }
            catch { }
        }
    }
}
