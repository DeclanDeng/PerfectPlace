using System.Collections.Generic;
using PerfectPlace.Models;

namespace PerfectPlace.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PerfectPlace.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PerfectPlace.Models.ApplicationDbContext context)
        {
            var emp = new List<Employee>
            {
                new Employee(){Name = "Ali", ContactNo = "0123456789", Age = 25, Email = "ali@gmail.com"},
                new Employee(){Name = "Arsalan", ContactNo = "9876543210", Age = 35, Email = "arsalan@gmail.com"}
            };
            emp.ForEach(e=>context.Employees.AddOrUpdate(p=>p.Id,e));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
