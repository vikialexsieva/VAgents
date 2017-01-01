namespace VAgents.Info.Service.Contracts.User
{
    using System.Linq;
    using Web.Models.User;

    public interface IUserNewsFeedService
    {
        IQueryable<UserNewsFeed> All(int page = 1, int pageSize = 10);
        int Add(string name, string price, string count);
        IQueryable<UserNewsFeed> ById(string prace);
    }
}
