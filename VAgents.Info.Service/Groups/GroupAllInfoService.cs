namespace VAgents.Info.Service.Solution
{
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.Groups;

    public class GroupAllInfoService : IGroupAllInfoService
    {
        private readonly IRepository<GroupAllInfo> GroupAllInfo;
        public GroupAllInfoService(IRepository<GroupAllInfo> GroupAllInfo)
        {
            this.GroupAllInfo = GroupAllInfo;
        }
        
        public int Add(string image)
        {
        
            var newSolutionDownloadLink = new GroupAllInfo
            {
                  Name = image,
            };
            this.GroupAllInfo.Add(newSolutionDownloadLink);
            this.GroupAllInfo.SaveChanges();
            return newSolutionDownloadLink.Id;
        }

        public IQueryable<GroupAllInfo> All(int page = 1, int pageSize = 10)
        {
            return this.GroupAllInfo
                .All()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<GroupAllInfo> ById(string url)
        {
            return this.GroupAllInfo
                .All()
                .Where(SolDownLink => SolDownLink.Name == url);
        }

    }
}
