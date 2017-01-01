using System.Linq;
using VAgents.Web.Models.Forums;

namespace VAgents.Info.Service.Contracts.Forums
{
    public interface IForumPostVoteService
    {
        IQueryable<ForumPostVote> All(int page, int PageSize);
        int Add();
    }
}
