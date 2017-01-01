namespace VAgents.Info.Service.Contracts.Solution
{
    using System.Linq;
    using Web.Models.Page;

    public interface IPageInfoService
    {
        IQueryable<PageInfo> All(int page = 1, int pageSize = 10);
        int Add(string URL, string image);
        IQueryable<PageInfo> ById(string url);
    }
}
