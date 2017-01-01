namespace VAgents.Info.Service.Demo
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Demo;
    using VAgents.Web.Models;
    using VAgents.Web.Models.Demo;

    public class DemoSampleService : IDemoSampleService
    {
        private readonly IRepository<DemoSample> demoSample;
        private readonly IRepository<ApplicationUser> user;

        public DemoSampleService(IRepository<DemoSample> demoSample, IRepository<ApplicationUser> user)
        {
            this.user = user;
            this.demoSample = demoSample;
        }

        public int Add(string name, string Description)
        {
            
            var newDemoSample = new DemoSample
            {
                 Name = name, 
                 Description = Description,
                 CreationTime = DateTime.Now,
            };
            this.demoSample.Add(newDemoSample);
            this.demoSample.SaveChanges();
            return newDemoSample.Id;
        }

        public IQueryable<DemoSample> All(int page = 1, int pageSize = 10)
        {
            return this.demoSample
                .All()
                .OrderByDescending(dms => dms.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<DemoSample> ById(string name)
        {
            return this.demoSample
                .All()
                .Where(dms => dms.Name == name);
        }
    }
}
