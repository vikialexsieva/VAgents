using System.Linq;
using VAgents.Web.Models.Forums;

namespace VAgents.Info.Service.Contracts.Forums
{
    public interface IForumPostService
    {
        IQueryable<ForumPost> All(int page = 1, int pageSize = 10);
        int Add(string Title, string description);
        IQueryable<ForumPost> ById(string Title);
    }
}
