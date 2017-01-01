namespace VAgents.Info.Service.Demo
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Demo;
    using VAgents.Web.Models;
    using VAgents.Web.Models.Demo;
    public class DemoInformationAllService : IDemoInformationAllService
    {
        private readonly IRepository<DemoAllInformation> demoAllInformation;
        private readonly IRepository<ApplicationUser> user;
        public DemoInformationAllService(IRepository<DemoAllInformation> demoAllInformation, 
            IRepository<ApplicationUser> user)
        {
            this.demoAllInformation = demoAllInformation;
            this.user = user;
        }
        public int Add(string name, string Description)
        {
            var newDemoAllInformation = new DemoAllInformation
            {
                Description = Description,
                Name = name,
                CreationTime = DateTime.Now,
            };
            this.demoAllInformation.Add(newDemoAllInformation);
            this.demoAllInformation.SaveChanges();
            return newDemoAllInformation.Id;
        }

        public IQueryable<DemoAllInformation> All(int page = 1, int pageSize = 10)
        {
            return this.demoAllInformation
                .All()
                .OrderByDescending(dai => dai.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<DemoAllInformation> ById(string name)
        {
            return this.demoAllInformation
                .All()
                .Where(dai => dai.Name == name);
        }
    }
}
