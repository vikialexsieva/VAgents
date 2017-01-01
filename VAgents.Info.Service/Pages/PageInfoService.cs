namespace VAgents.Info.Service.Solution
{
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.Page;

    public class PageInfoService : IPageInfoService
    {
        private readonly IRepository<PageInfo> pageInfo;
        public PageInfoService(IRepository<PageInfo> pageInfo)
        {
            this.pageInfo = pageInfo;
        }

        public int Add(string URL, string image)
        {
            var newSolutionDownloadLink = new PageInfo
            {

            };
            this.pageInfo.Add(newSolutionDownloadLink);
            this.pageInfo.SaveChanges();
            return newSolutionDownloadLink.Id;
        }

        public IQueryable<PageInfo> All(int page = 1, int pageSize = 10)
        {
            return this.pageInfo
                .All()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<PageInfo> ById(string url)
        {
            return this.pageInfo
                .All()
                .Where(SolDownLink => SolDownLink.Name == url);
        }
        
    }
}
