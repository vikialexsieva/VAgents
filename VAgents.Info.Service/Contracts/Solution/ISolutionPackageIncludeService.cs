namespace VAgents.Info.Service.Contracts.Solution
{
    using System.Linq;
    using Web.Models.Solution;

    public interface ISolutionPackageIncludeService
    {
        
        IQueryable<SolutionPackegeInclude> All(int page = 1, int pageSize = 10);
        int Add(string name, bool IsAvtive =false);
        IQueryable<SolutionPackegeInclude> ById(string name);
    }
}
