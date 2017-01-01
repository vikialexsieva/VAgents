namespace VAgents.Info.Service.Contracts.Solution
{
    using System.Linq;
    using Web.Models.Page;

    public interface IPageAllInfoService
    {
        IQueryable<PageAllInfo> All(int page = 1, int pageSIze = 10);
        int Add(string name);
        IQueryable<PageAllInfo> ById(string name);
    }
}
