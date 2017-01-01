namespace VAgents.Info.Service.Forum
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Forums;
    using VAgents.Web.Models;
    using VAgents.Web.Models.Forums;

    public class ForumPostService : IForumPostService
    {
        private readonly IRepository<ForumPost> forumPost;
        private readonly IRepository<ApplicationUser> user;
        public ForumPostService(IRepository<ForumPost> forumPost,
            IRepository<ApplicationUser>user)
        {
            this.forumPost = forumPost;
            this.user = user;
        }

        public int Add(string Title, string description)
        {
            var newForumPost = new ForumPost
            {
                CreationTime = DateTime.Now,
                 Title = Title,
                Description = description,
            };
            this.forumPost.Add(newForumPost);
            this.forumPost.SaveChanges();
            return newForumPost.Id;
        }

        public IQueryable<ForumPost> All(int page = 1, int pageSize = 10)
        {
            return this.All()
                .OrderByDescending(fp => fp.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<ForumPost> ById(string Title)
        {
            return this.forumPost
                .All()
                .Where(fp => fp.Title == Title);
        }
    }
}
