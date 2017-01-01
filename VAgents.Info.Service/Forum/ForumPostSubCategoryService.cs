namespace VAgents.Info.Service.Forum
{
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Forums;
    using VAgents.Web.Models.Forums;

    public class ForumPostSubCategoryService : IForumPostSubCategoryService 
    {
        private readonly IRepository<ForumPostSubCategory> forumPostSubCategory;
        public ForumPostSubCategoryService(IRepository<ForumPostSubCategory> forumPostSubCategory)
        {
            this.forumPostSubCategory = forumPostSubCategory;
        }
        public IQueryable<ForumPostSubCategory> All(int page = 1, int pageSize = 10)
        {
            return this.forumPostSubCategory
               .All()
               .OrderByDescending(fpsubCat => fpsubCat.Name)
               .Skip((page - 1) * pageSize)
               .Take(pageSize);
        }

        public int Add(string name)
        {
            var newForumPostSubCategory = new ForumPostSubCategory
            {
                Name = name,
            };
            this.forumPostSubCategory.Add(newForumPostSubCategory);
            this.forumPostSubCategory.SaveChanges();
            return newForumPostSubCategory.Id;
        }

        public IQueryable<ForumPostSubCategory> ById(string name)
        {
            return this.forumPostSubCategory
                   .All()
                   .Where(fpSubCat => fpSubCat.Name == name);
        }
    }
}
