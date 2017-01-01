namespace VAgents.Info.Service.Contracts.Solution
{
    using System.Linq;
    using VAgents.Web.Models.Solution;

    public interface ISolutionSocialLinkService
    {
        IQueryable<SolutionSocialLink> All(int page = 1, int pageSize = 10);
        int Add(string image, string url);
        IQueryable<SolutionSocialLink> ById(string url);
    }
}
