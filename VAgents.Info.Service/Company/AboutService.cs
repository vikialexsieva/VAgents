namespace VAgents.Info.Service.Company
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Web.Models;
    using VAgents.Web.Models.Company;
    using System.Data.Entity;
    using Contracts.Company;

    public class AboutService : IAboutService
    {
        private readonly IRepository<About> about;
        private readonly IRepository<ApplicationUser> user;
        public AboutService(IRepository<About> about, 
            IRepository<ApplicationUser> user)
        {
            this.about = about;
            this.user = user;
        }
        public int Add(string Name, string Description)
        {
            var newAbout = new About
            {
               Description = Description,
               Name = Name,
               CreationTime = DateTime.Now
            };
            this.about.Add(newAbout);
            this.about.SaveChanges();
            return newAbout.Id;
        }

        public IQueryable<About> All(int page = 1, int pageSize = 10)
        {
            return this.about
                .All()
                .OrderByDescending(ab => ab.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }
    }
}
