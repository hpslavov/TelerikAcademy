namespace TwitterLike.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<TwitterLikeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TwitterLikeDbContext context)
        {
            var passHasher = new PasswordHasher();

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "pesho@ivan.com"))
            {
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                var user = new User
                {
                    UserName = "pesho@ivan.com",
                    Email = "pesho@ivan.com",
                    PasswordHash = passHasher.HashPassword("ickata")
                };

                manager.Create(user);
               //    context.Users.Add(user);
                //context.SaveChanges();
               // var userWithId = context.Users.Where(u => u.UserName == "pesho@ivan.com").FirstOrDefault();
                manager.AddToRole(user.Id, "Admin");
            }

        }
    }
}
