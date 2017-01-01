namespace VAgents.Info.Service.User
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class UserNewsFeedService : IUserNewsFeedService
    {
        private IRepository<UserNewsFeed> userNewsFeed;
        public UserNewsFeedService(IRepository<UserNewsFeed> userNewsFeed)
        {
            this.userNewsFeed = userNewsFeed;
        }

        public int Add(string name, string price, string count)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserNewsFeed> All(int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserNewsFeed> ById(string prace)
        {
            throw new NotImplementedException();
        }
    }
}
