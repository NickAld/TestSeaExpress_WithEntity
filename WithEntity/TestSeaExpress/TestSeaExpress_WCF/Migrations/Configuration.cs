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
                FirstName = "Иванов",
                LastName = "Петр",
                MiddleName="Петрович",
                Email = "a@r.r"
            });

            context.Users.AddOrUpdate(new User()
            {
                FirstName = "Петров",
                LastName = "Михаил",
                MiddleName = "Петрович",
                Email = "ppp@r.r"
            });
            context.Users.AddOrUpdate(new User()
            {
                FirstName = "Михайлов",
                LastName = "Алексей",
                MiddleName = "Петрович",
                Email = "m.alex@rasa.ru"
            });
            context.Users.AddOrUpdate(new User()
            {
                FirstName = "Неизвестный",
                LastName = "Человек",
                MiddleName = "ttt",
                Email = "u.men@ddd.ru"
            });


        }
    }
}
