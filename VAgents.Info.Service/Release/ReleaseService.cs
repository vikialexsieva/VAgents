namespace VAgents.Info.Service.Releases
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Releases;
    using VAgents.Web.Models.Releases;

    public class ReleaseService : IReleaseService
    {
        private readonly IRepository<ReleaseHistory> release;
        public ReleaseService(IRepository<ReleaseHistory> release)
        {
            this.release = release;
        }
        
        public int Add(string name, string description, string image)
        {
            var nerRelease = new ReleaseHistory
            {
                CreatioTime = DateTime.Now,
                Description = description,
                Image = image,
                Name = name
            };
            this.release.Add(nerRelease);
            this.release.SaveChanges();
            return nerRelease.Id;
        }

        public IQueryable<ReleaseHistory> All(int page = 1, int pageSIze = 10)
        {
            return this.release
                .All()
                .Skip((page - 1) * pageSIze)
                .Take(pageSIze);
        }

        public IQueryable<ReleaseHistory> ById(string name)
        {
            return this.release
                .All()
                .Where(r => r.Name == name);
        }
    }
}
