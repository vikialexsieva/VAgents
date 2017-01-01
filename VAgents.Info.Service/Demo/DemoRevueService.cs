namespace VAgents.Info.Service.Demo
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Demo;
    using VAgents.Web.Models;
    using VAgents.Web.Models.Demo;

    public class DemoRevueService : IDemoRevueService
    {
        private readonly IRepository<DemoRevue> demoRevue;
        private readonly IRepository<ApplicationUser> user;

        public DemoRevueService(IRepository<DemoRevue> demoRevue,
            IRepository<ApplicationUser> user)
        {
            this.demoRevue = demoRevue;
            this.user = user;
        }

        public int Add(string name, string description)
        {
            var newDemoRevue = new DemoRevue
            {
                Name = name,
                Description = description,
                CreationTime = DateTime.Now,
            };

            this.demoRevue.Add(newDemoRevue);
            this.demoRevue.SaveChanges();
            return newDemoRevue.Id;
        }

        public IQueryable<DemoRevue> All(int page = 1, int pageSize = 10)
        {
            return this.demoRevue
                .All()
                .OrderByDescending(dr => dr.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<DemoRevue> ById(int id)
        {
            return this.demoRevue
                .All()
                .Where(dr => dr.Demmo.Id == id);
        }
    }
}
