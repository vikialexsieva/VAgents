namespace VAgents.Info.Service.Solution
{
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.Solution;

    public class SolutionDownloadLinkService : ISolutionDownloadLinkService
    {
        private readonly IRepository<SolutionDownloadLink> solutionDownloadLink;
        public SolutionDownloadLinkService(IRepository<SolutionDownloadLink> solutionDownloadLink)
        {
            this.solutionDownloadLink = solutionDownloadLink;
        }

        public int Add(string URL, string image)
        {
            var newSolutionDownloadLink = new SolutionDownloadLink
            {
                Image = image,
                URL = URL
            };
            this.solutionDownloadLink.Add(newSolutionDownloadLink);
            this.solutionDownloadLink.SaveChanges();
            return newSolutionDownloadLink.Id;
        }

        public IQueryable<SolutionDownloadLink> All(int page = 1, int pageSize = 10)
        {
            return this.solutionDownloadLink
                .All()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<SolutionDownloadLink> ById(string url)
        {
            return this.solutionDownloadLink
                .All()
                .Where(SolDownLink => SolDownLink.URL == url);
        }
    }
}
