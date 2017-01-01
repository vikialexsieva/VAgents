namespace VAgents.Info.Service.Demo
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Web.Models;
    using VAgents.Web.Models.Demo;

    public class DemoService : IDemoService
    {
        private readonly IRepository<Demos> demos;
        private readonly IRepository<ApplicationUser> user;

        public DemoService(IRepository<Demos> demos,
            IRepository<ApplicationUser> user)
        {
            this.demos = demos;
            this.user = user;
        }

        public int Add(string name, 
            string description,
            string image)
        {
            var newDemo = new Demos
            {
               Name = name, 
               Description = description,
               Image = image,
               CreationTime = DateTime.Now,
            };
            
            this.demos.Add(newDemo);
            this.demos.SaveChanges();
            return newDemo.Id;
        }

        public IQueryable<Demos> All(int page = 1, int pageSize = 10)
        {
            return this.demos
                .All()
                .OrderByDescending(ds => ds.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<Demos> ById(string name)
        {
            return this.demos
                .All()
                .Where(ds => ds.Name == name);
        }
    }
}
