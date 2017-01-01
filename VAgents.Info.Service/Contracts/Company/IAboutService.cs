namespace VAgents.Info.Service.Contracts.Company
{
    using System.Linq;
    using Web.Models.Company;

    public interface IAboutService
    {
        IQueryable<About> All(int page = 1, int pageSize = 10);
        int Add(string Name, string Description);
       
    }
}
