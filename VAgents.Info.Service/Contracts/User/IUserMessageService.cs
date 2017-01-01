namespace VAgents.Info.Service.Contracts.User
{
    using System.Linq;
    using Web.Models;

    public interface IUserMessageService
    {

        IQueryable<UserMessage> All(int page = 1, int pageSize = 10);
        int Add(string name, bool IsAvtive = false);
        IQueryable<UserMessage> ById(string name);
    }
}
