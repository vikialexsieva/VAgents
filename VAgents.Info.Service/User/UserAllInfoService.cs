namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.User;

    public class UserAllInfoService : IUserAllInfoService
    {
        private IRepository<UserAllInfo> userAllInfo;
        public UserAllInfoService(IRepository<UserAllInfo> userAllInfo)
        {
            this.userAllInfo = userAllInfo;
        }
        

        public int Add(string UserPhone, string UserUrl, string DateOfByrt,
            string YearOfByrt, string MountOfByr, string About, string OtherNames, string OtherInfo)
        {
            var newUserAllInfo = new UserAllInfo
            {
                UserPhone = UserPhone,
                UserUrl = UserUrl,
                DateOfByrth = DateOfByrt,
                YearOfByrth = YearOfByrt,
                MountOfByrth = MountOfByr,
                About = About,
                OtherNames = OtherNames,
                OtherInfo = OtherInfo
            };

            this.userAllInfo.Add(newUserAllInfo);
            this.userAllInfo.SaveChanges();
            return newUserAllInfo.Id;
        }
        
    }
}
