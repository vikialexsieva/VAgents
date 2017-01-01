using System.Linq;
using VAgents.Web.Models.Company;

namespace VAgents.Info.Service.Contracts.Company
{
    public interface ICompanyMessageService
    {
        
        IQueryable<CompanyMessage> ById(string Title);
        int Add(string title,
            string description,
            string phone,
            string firstName,
            string lastName);
        IQueryable<CompanyMessage> All(int page = 1, int pageSize = 10);
    }
}
