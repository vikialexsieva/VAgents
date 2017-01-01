namespace Vagents.Info.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using System.Data.Entity.Migrations;
    using VAgents.Info.Data.Common;
    using VAgents.Info.Model;
    using System;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        private UserManager<ApplicationUser> userManager;
        private IRandomGenerator random;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            this.random = new RandomGenerator();

        }

        protected override void Seed(ApplicationDbContext context)
        {

            this.SeedPolicy(context);
            this.SeedBusiness(context);
            this.SeedRoles(context);
            this.SeedUser(context);
            this.SeedProduct(context);
            this.SeedMarketing(context);
           
        }

        private void SeedMarketing(ApplicationDbContext context)
        {
            if (context.Marketings.Any())
            {
                return;
            }

            for (int i = 0; i <  10; i++)
            {
                var policy = new Marketing
                {
                    Description = this.random.RandomString(50, 60),
                    EndTime = DateTime.Now,
                    Name = this.random.RandomString(60, 80),
                    StartTime = DateTime.Now,
                };
                for (int k = 0; k < 5; k++)
                {
                    var comment = new Point
                    {
                        Name = this.random.RandomString(100, 300),
                        Points = 31231,
                        CreationTime = DateTime.Now
                    };

                    policy.Point.Add(comment);
                }
                
                context.Marketings.Add(policy);
            }
        }

        private void SeedProduct(ApplicationDbContext context)
        {
            if (context.Products.Any())
            {
                return;
            }

            for (int i = 0; i < 2; i++)
            {
                var policy = new Product
                {
                    StartPromoPrice = DateTime.Now,
                    EndPromoPrice = DateTime.Now,
                    Price  = 100,
                    ProductName = this.random.RandomString(50,70),
                    PromoPrice = 50,
                };

                context.Products.Add(policy);
            }
        }

        private void SeedUser(ApplicationDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }


            for (int i = 0; i < 5; i++)
            {
                var user = new ApplicationUser
                {
                    Email = string.Format("{0}@{1}.com", this.random.RandomString(5, 16)),
                    UserName = this.random.RandomString(7, 50),
                };

                this.userManager.Create(user, "123456");
            }

            var adminUser = new ApplicationUser
            {
                Email = "admin@vagents.info",
                UserName = "Administrator"
            };

            this.userManager.Create(adminUser, "admin123456");

            this.userManager.AddToRole(adminUser.Id, GlobalConstants.AdminRole);
        }

        private void SeedRoles(ApplicationDbContext context)
        {
            if(context.Roles.Any())
            {
                return;
            }
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole(GlobalConstants.AdminRole));
            context.SaveChanges();
        }

        private void SeedPolicy(ApplicationDbContext context)
        {
            if (context.Policies.Any())
            {
                return;
            }

            for (int i = 0; i < 2; i++)
            {
                var policy = new Policy
                {
                    CreationTime = DateTime.Now,
                    Name = this.random.RandomString(5, 40),
                    Description = this.random.RandomString(200, 300)
                };

                context.Policies.Add(policy);
            }
        }

        private void SeedBusiness(ApplicationDbContext context)
        {
            if (context.Business.Any())
            {
                return;
            }

            for (int i = 0; i < 2; i++)
            {
                var business = new BusinessInfo
                {
                    
                    Name = this.random.RandomString(5, 40),
                    Description = this.random.RandomString(200, 300)
                };

                context.Business.Add(business);
            }
        }
    }
}
