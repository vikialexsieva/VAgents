namespace VAgents.Info.Service.Contracts.Solution
{
    using System.Linq;
    using Web.Models.Groups;

    public interface IGroupInfoService
    {
        IQueryable<GroupsInfo> All(int page = 1, int pageSize = 10);
        int Add(string URL, string image);
        IQueryable<GroupsInfo> ById(string url);
    }
}
