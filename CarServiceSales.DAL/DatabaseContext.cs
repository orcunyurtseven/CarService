using OtoServiceSales.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSales.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
        {
            protected override void Seed(DatabaseContext context)
            {
                if (!context.Users.Any()) 
                {
                    context.Users.Add(new User()
                    {
                        Name = "Admin",
                        Active = true,
                        AddDate = DateTime.Now,
                        Email = "admin@carservice.com",
                        UserName = "admin",
                        UserPassword = "123456",
                    });
                    context.SaveChanges();
                }
                base.Seed(context);
            }
        }
        public DatabaseContext() : base("name=DatabaseContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}
