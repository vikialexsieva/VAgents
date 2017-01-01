namespace VAgents.Info.Service.Contracts.Solution
{
    using System.Linq;
    using Web.Models.Solution;

    public interface ISolutionDownloadLinkService
    {
        IQueryable<SolutionDownloadLink> All(int page = 1, int pageSize = 10);
        int Add(string URL, string image);
        IQueryable<SolutionDownloadLink> ById(string url);
    }
}
