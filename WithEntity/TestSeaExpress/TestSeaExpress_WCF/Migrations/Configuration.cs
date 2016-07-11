using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

using TestSeaExpress_WCF;


namespace TestSeaExpress_WCF.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<TestSeaExpress_WCF.database.dbWork>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TestSeaExpress_WCF.database.dbWork context)
        {
            context.Users = context.Set<TestSeaExpress_WCF.User>();

            context.Users.AddOrUpdate(new User()
            {
                FirstName = "������",
                LastName = "����",
                MiddleName="��������",
                Email = "a@r.r"
            });

            context.Users.AddOrUpdate(new User()
            {
                FirstName = "������",
                LastName = "������",
                MiddleName = "��������",
                Email = "ppp@r.r"
            });
            context.Users.AddOrUpdate(new User()
            {
                FirstName = "��������",
                LastName = "�������",
                MiddleName = "��������",
                Email = "m.alex@rasa.ru"
            });
            context.Users.AddOrUpdate(new User()
            {
                FirstName = "�����������",
                LastName = "�������",
                MiddleName = "ttt",
                Email = "u.men@ddd.ru"
            });


        }
    }
}
