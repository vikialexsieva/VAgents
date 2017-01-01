
namespace VAgents.Info.Service.Contracts.Company
{
    using System.Linq;
    using VAgents.Web.Models.Company;

    public interface ICompanyContactService
    {
        IQueryable<CompanyContact> all(int page = 1, int pageSize = 10);
        IQueryable<CompanyContact> ById(string OfficeCountry);
        int Add(string phoneNumber, string officeCountry,
            string workFrom, string workTo);
    }
}
