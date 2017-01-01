namespace VAgents.Info.Service.Contracts.Solution
{
    using System.Linq;
    using VAgents.Web.Models.Solution;

    public interface ISolutionService
    {
        IQueryable<Solutions> All(int page = 1, int pageSize = 10);
        int Add(string name, string description, string image);
        IQueryable<Solutions> ById(string name);
    }
}
