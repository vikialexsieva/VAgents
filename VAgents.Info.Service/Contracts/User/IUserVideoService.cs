namespace VAgents.Info.Service.Contracts.User
{
    using System.Linq;
    using Web.Models.User;

    public interface IUserVideoService
    {
        IQueryable<UserVideo> All(int page = 1, int pageSize = 10);
        int Add(string image, string url);
        IQueryable<UserVideo> ById(string url);
    }
}
