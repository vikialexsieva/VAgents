using System.Linq;
using VAgents.Web.Models.Company;

namespace VAgents.Info.Service.Contracts.Company
{
    public interface ICompanyInformationServices
    {
        IQueryable<CompanyInformation> All(int page = 1, int pageSize = 10);
        int Add(string name, string description);
        IQueryable<CompanyInformation> ById(string name);
    }
}