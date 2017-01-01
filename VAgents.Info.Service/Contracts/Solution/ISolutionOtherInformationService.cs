namespace VAgents.Info.Service.Contracts.Solution
{
    using System.Linq;
    using Web.Models.Solution;

    public interface ISolutionOtherInformationService
    {
        IQueryable<SolutionOtherInformation> All(int page = 1, int pageSize = 10);
        int Add(string name, string description);
        IQueryable<SolutionOtherInformation> ById(string name);
    }
}
