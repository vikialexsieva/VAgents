using System.Linq;
using VAgents.Web.Models.Forums;

namespace VAgents.Info.Service.Contracts.Forums
{
    public interface IForumPostCategoryService
    {
        IQueryable<ForumPostCategory> All(int page = 1, int pageSize = 10);
        int Add(string name);
        IQueryable<ForumPostCategory> ById(string name);
    }
}
