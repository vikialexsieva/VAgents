namespace VAgents.Info.Service.Contracts.Solution
{
    using System.Linq;
    using Web.Models.Solution;

    public interface ISolutionPackageService
    {
        IQueryable<SolutionPackage> All(int page = 1, int pageSize = 10);
        int Add(string name, string price, string count);
        IQueryable<SolutionPackage> ById(string prace);
    }
}
