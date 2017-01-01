namespace VAgents.Info.Service.Forum
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Forums;
    using VAgents.Web.Models.Forums;

    public class ForumPostVoteService : IForumPostVoteService
    {
        private readonly IRepository<ForumPostVote> forumPostVote;
        public ForumPostVoteService(IRepository<ForumPostVote> ForumPostVote)
        {
            this.forumPostVote = ForumPostVote;
        }

        public int Add()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ForumPostVote> All(int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
