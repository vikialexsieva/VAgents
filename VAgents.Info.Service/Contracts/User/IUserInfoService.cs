namespace VAgents.Info.Service.Contracts.User
{
    using System.Linq;
    using Web.Models.User;

    public interface IUserInfoService
    {
        IQueryable<UserInfo> All(int page = 1, int pageSIze = 10);
        int Add(string name);
        IQueryable<UserInfo> ById(string name);
    }
}
