namespace VAgents.Info.Service.Contracts.Solution
{
    using System.Linq;
    using Web.Models.Groups;

    public interface IGroupAllInfoService
    {
        IQueryable<GroupAllInfo> All(int page = 1, int pageSIze = 10);
        int Add(string name);
        IQueryable<GroupAllInfo> ById(string name);
    }
}
