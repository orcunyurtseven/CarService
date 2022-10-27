namespace CarServiceSales.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using OtoServiceSales.Entities;


    internal sealed class Configuration : DbMigrationsConfiguration<CarServiceSales.DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DatabaseContext context)
        {
            if (!context.Users.Any())
            {
                var rol = context.Roles.Add(new Role()
                {
                    Name = "Admin"
                });
                context.Users.Add(new User()
                {
                    Name = "Admin",
                    Active = true,
                    AddDate = DateTime.Now,
                    Email = "admin@carservice.com",
                    UserName = "admin",
                    UserPassword = "123456",
                    Role = rol,
                    RoleId = rol.Id

                });
                context.SaveChanges();
            }
            base.Seed(context);
        }
    }
}
