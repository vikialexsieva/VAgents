using System.Linq;
using VAgents.Web.Models.Forums;

namespace VAgents.Info.Service.Contracts.Forums
{
    public interface IForumPostAnswerService
    {
        IQueryable<ForumPostAnswer> All(int page = 1, int pageSize = 10);
        int Add(string content);
        IQueryable<ForumPostAnswer> ById(string content);
    }
}
