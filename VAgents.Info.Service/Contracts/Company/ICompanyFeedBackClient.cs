using System.Linq;
using VAgents.Web.Models.Company;

namespace VAgents.Info.Services.Contracts.Company
{
    public interface ICompanyFeedBackClientService
    {
        IQueryable<CompanyFeedBackClient> All(int page = 1, int pageSize = 10);
        int Add(string name, string lastName, string workInCompany,
            string companyPosition,string Description);
        IQueryable<CompanyFeedBackClient> byId(string CompanyPosition);
    }
}