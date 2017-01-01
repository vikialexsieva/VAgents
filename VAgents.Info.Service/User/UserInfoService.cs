namespace VAgents.Info.Service.User
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class UserInfoService : IUserInfoService
    {
        private IRepository<UserInfo> userInfo;
        public UserInfoService(IRepository<UserInfo> userInfo)
        {
            this.userInfo = userInfo;
        }

        public int Add(string name)
        {
            var newUserInfo = new UserInfo
            {
                
            };

            this.userInfo.Add(newUserInfo);
            this.userInfo.SaveChanges();
            return newUserInfo.Id;
        }

        public IQueryable<UserInfo> All(int page = 1, int pageSIze = 10)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserInfo> ById(string name)
        {
            throw new NotImplementedException();
        }
    }
}
