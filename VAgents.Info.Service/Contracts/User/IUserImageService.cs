namespace VAgents.Info.Service.Contracts.User
{
    using System.Linq;
    using Web.Models.User;

    public interface IUserImageService
    {
        IQueryable<UserImage> All(int page = 1, int pageSize = 10);
        int Add(string URL, string image);
        IQueryable<UserImage> ById(string url);
    }
}
