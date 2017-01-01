namespace VAgents.Info.Service.Contracts.User
{
    using System.Linq;
    using Web.Models.User;

    public interface IUserPostService
    {
        IQueryable<UserPost> All(int page = 1, int pageSize = 10);
        int Add(string name);
        IQueryable<UserPost> ById(string name);
    }
}
