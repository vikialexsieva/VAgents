namespace VAgents.Info.Service.User
{

    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class UserFriendRequestService : IUserFriendRequestService
    {
        private IRepository<UserFriendRequest> userFriendRequest;
        public UserFriendRequestService(IRepository<UserFriendRequest> userFriendRequest)
        {
            this.userFriendRequest = userFriendRequest;
        }

        public int Add(string name, string description, string image)
        {
            var newUserFriendRequest = new UserFriendRequest
            {
                
            };

            this.userFriendRequest.Add(newUserFriendRequest);
            this.userFriendRequest.SaveChanges();
            return newUserFriendRequest.Id;
        }

        public IQueryable<UserFriendRequest> All(int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserFriendRequest> ById(string name)
        {
            throw new NotImplementedException();
        }
    }
}
