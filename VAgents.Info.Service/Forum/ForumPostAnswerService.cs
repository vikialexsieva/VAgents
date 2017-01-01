namespace VAgents.Info.Service.Forum
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Forums;
    using VAgents.Web.Models;
    using VAgents.Web.Models.Forums;

    public class ForumPostAnswerService : IForumPostAnswerService
    {
        private readonly IRepository<ForumPostAnswer> forumPostAnswer;
        private readonly IRepository<ApplicationUser> user;
        public ForumPostAnswerService(IRepository<ForumPostAnswer> forumPostAnswer,
            IRepository<ApplicationUser> user)
        {
            this.user = user;
            this.forumPostAnswer = forumPostAnswer;
        }
        public int Add(string content)
        {
            var newForumPostAnswer = new ForumPostAnswer
            {
                CreationTime = DateTime.Now,
                Name = content,
            };
            this.forumPostAnswer.Add(newForumPostAnswer);
            this.forumPostAnswer.SaveChanges();
            return newForumPostAnswer.Id; 
        }

        public IQueryable<ForumPostAnswer> All(int page = 1, int pageSize = 10)
        {
            return this.forumPostAnswer
                .All()
                .OrderByDescending(fpAnswer => fpAnswer.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<ForumPostAnswer> ById(string content)
        {
            throw new NotImplementedException();
        }
    }
}
