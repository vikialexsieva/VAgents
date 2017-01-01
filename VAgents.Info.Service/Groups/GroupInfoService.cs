namespace VAgents.Info.Service.Solution
{
    using System;
    using System.Linq;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.Groups;
    using Vagents.Info.Data;

    public class GroupInfoService : IGroupInfoService
    {
        private readonly IRepository<GroupsInfo> GroupInfo;
        public GroupInfoService(IRepository<GroupsInfo> GroupInfo)
        {
            this.GroupInfo = GroupInfo;
        }
        public int Add(string name)
        {
            var newSolutionCategory = new GroupsInfo
            {

            };
            this.GroupInfo.Add(newSolutionCategory);
            this.GroupInfo.SaveChanges();
            return newSolutionCategory.Id;
        }

        public int Add(string URL, string image)
        {
            throw new NotImplementedException();
        }

        public IQueryable<GroupsInfo> All(int page = 1, int pageSIze = 10)
        {
            return this.GroupInfo
                .All()
                .Skip((page - 1) * pageSIze)
                .Take(pageSIze);
        }

        public IQueryable<GroupsInfo> ById(string name)
        {
            return this.GroupInfo
                .All()
                .Where(SolCat => SolCat.Name == name);
        }
        
    }
}
