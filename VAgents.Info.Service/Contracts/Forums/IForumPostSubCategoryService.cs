using System.Linq;
using VAgents.Web.Models.Forums;

namespace VAgents.Info.Service.Contracts.Forums
{
    public interface IForumPostSubCategoryService
    {
        IQueryable<ForumPostSubCategory> All(int page = 1, int pageSize = 10);
        int Add(string name);
        IQueryable<ForumPostSubCategory> ById(string name);
    }
}
