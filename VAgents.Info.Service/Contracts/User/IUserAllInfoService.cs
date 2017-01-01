namespace VAgents.Info.Service.Contracts.User
{
    using System.Linq;
    using Web.Models.User;

    public interface IUserAllInfoService
    {
        
        IQueryable<UserAllInfo> All(int page = 1, int pageSize = 10);
        int Add(string name, bool IsAvtive =false);
        IQueryable<UserAllInfo> ById(string name);
    }
}
