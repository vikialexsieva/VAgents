namespace VAgents.Info.Service.Forum
{
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Forums;
    using VAgents.Web.Models.Forums;

    public class ForumPostCategoryService : IForumPostCategoryService
    {
        private readonly IRepository<ForumPostCategory> forumPostCategory;
        public ForumPostCategoryService(IRepository<ForumPostCategory> forumPostCategory)
        {
            this.forumPostCategory = forumPostCategory;
        }
        public int Add(string name)
        {
            var newForumPostCategory = new ForumPostCategory
            {
                Name = name
            };
            this.forumPostCategory.Add(newForumPostCategory);
            this.forumPostCategory.SaveChanges();
            return newForumPostCategory.Id;
        }

        public IQueryable<ForumPostCategory> All(int page = 1, int pageSize = 10)
        {
            return this.forumPostCategory
                .All()
                .OrderByDescending(fpc => fpc.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<ForumPostCategory> ById(string name)
        {
            return this.forumPostCategory
                .All()
                .Where(fpc => fpc.Name == name);        }
        }
}
