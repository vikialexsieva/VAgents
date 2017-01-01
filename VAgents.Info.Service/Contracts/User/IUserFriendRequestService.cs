namespace VAgents.Info.Service.Contracts.User
{
    using System.Linq;
    using Web.Models.User;

    public interface IUserFriendRequestService
    {
        IQueryable<UserFriendRequest> All(int page = 1, int pageSize = 10);
        int Add(string name, string description, string image);
        IQueryable<UserFriendRequest> ById(string name);
    }
}
