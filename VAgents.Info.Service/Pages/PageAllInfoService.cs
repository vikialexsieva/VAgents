namespace VAgents.Info.Service.Solution
{
    using System.Linq;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.Page;
    using Vagents.Info.Data;

    public class PageAllInfoService : IPageAllInfoService
    {
        private readonly IRepository<PageAllInfo> pageAllInfoService;
        public PageAllInfoService(IRepository<PageAllInfo> pageAllInfoService)
        {
            this.pageAllInfoService = pageAllInfoService;
        }
        public int Add(string name)
        {
            var newSolutionCategory = new PageAllInfo
            {
                Name = name
            };
            this.pageAllInfoService.Add(newSolutionCategory);
            this.pageAllInfoService.SaveChanges();
            return newSolutionCategory.Id;
        }

        public IQueryable<PageAllInfo> All(int page = 1, int pageSIze = 10)
        {
            return this.pageAllInfoService
                .All()
                .Skip((page - 1) * pageSIze)
                .Take(pageSIze);
        }

        public IQueryable<PageAllInfo> ById(string name)
        {
            return this.pageAllInfoService
                .All()
                .Where(SolCat => SolCat.Name == name);
        }
        
    }
}
