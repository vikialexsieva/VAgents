namespace VAgents.Info.Service.User
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class UserPostService : IUserPostService
    {
        private IRepository<UserPost> userPost;
        public UserPostService(IRepository<UserPost> userPost)
        {
            this.userPost = userPost;
        }

        public int Add(string name)
        {
            var newPost = new UserPost
            {
                Post = name,

            };

            this.userPost.Add(newPost);
            this.userPost.SaveChanges();
            return newPost.Id;
        }

        public IQueryable<UserPost> All(int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserPost> ById(string name)
        {
            throw new NotImplementedException();
        }
    }
}
