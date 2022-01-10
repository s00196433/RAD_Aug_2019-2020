namespace WebApplication1.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;
    using ClassLibrary1;
    using ClassLibrary1.salesModels;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var manager =
               new UserManager<ApplicationUser>(
                   new UserStore<ApplicationUser>(context));

            var roleManager =
                new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Sales Entry Clerk" }
                );
            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Department Manager" }
                );
            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Customers" }
                );

            PasswordHasher ps = new PasswordHasher();

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "sales@acme.com",
                    Email = "sales@acme.com",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = ps.HashPassword("MollySugdon$1")
                });


            ApplicationUser SalesClerk = manager.FindByEmail("sales@acme.com");
            if (SalesClerk != null)
            {
                manager.AddToRoles(SalesClerk.Id, new string[] { "Sales Entry Clerk" });
            }
            context.SaveChanges();

            SeedCustomers(manager, context);
        }
        private void SeedCustomers(UserManager<ApplicationUser> manager, ApplicationDbContext context)
        {


            PasswordHasher ps = new PasswordHasher();
            using (salesContext Db = new salesContext())
            {

                foreach (var customer in Db.Customers)
                {
                    ApplicationUser user = manager.FindByName(customer.Name);
                    if (user == null)
                    {
                        context.Users.AddOrUpdate(u => u.UserName,
                            new ApplicationUser
                            {
                                Id = customer.ID.ToString(),
                                Email = customer.ID + "@mail.itsligo.ie",
                                UserName = customer.ID + "@mail.itsligo.ie",
                                EmailConfirmed = true,
                                SecurityStamp = Guid.NewGuid().ToString(),
                                PasswordHash = ps.HashPassword(customer.ID + "s$1")
                            });
                    }
                }
                context.SaveChanges();


                foreach (var customer in Db.Customers)
                {
                    ApplicationUser ChosenCustomers = manager.FindByName(customer.Name);
                    if (ChosenCustomers != null)
                    {
                        manager.AddToRoles(ChosenCustomers.Id, new string[] { "Customers" });
                    }

                }
            }
            context.SaveChanges();
        }
    }
}
