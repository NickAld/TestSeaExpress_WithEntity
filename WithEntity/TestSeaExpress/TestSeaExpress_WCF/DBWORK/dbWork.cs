using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace TestSeaExpress_WCF.database
{
    public class dbWork : DbContext
    {
        public DbSet<TestSeaExpress_WCF.User> Users { get; set; }

        public dbWork() : base("name=TestSeaExpress")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder context)
        {
            context.Entity<User>().ToTable("Users");
            base.OnModelCreating(context);
        }

        
    }
}