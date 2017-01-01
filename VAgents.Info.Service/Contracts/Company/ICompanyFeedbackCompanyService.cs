using System.Linq;
using VAgents.Web.Models.Company;

namespace VAgents.Info.Service.Contracts.Company
{
    public interface ICompanyFeedbackCompanyService
    {
        IQueryable<CompanyFeedBackCompany> All(int page = 1, int pageSize = 10);
        int Add(string companyName, string companyLogo, string description);
    }
}