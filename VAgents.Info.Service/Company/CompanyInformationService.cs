using System;
using System.Linq;
using VAgents.Info.Service.Contracts.Company;
using Vagents.Info.Data;
using VAgents.Web.Models.Company;

namespace VAgents.Info.Service.Company
{
    public class CompanyInformationService : ICompanyInformationServices
    {
        private readonly IRepository<CompanyInformation> companyInformation;
        public CompanyInformationService(IRepository<CompanyInformation> companyInformation)
        {
            this.companyInformation = companyInformation;
        }
        public int Add(string name, string description)
        {
            var newCompanyInformation = new CompanyInformation
            {
                Name = name,
                Description = description,
                CreationTime = DateTime.Now,
            };
            this.companyInformation.Add(newCompanyInformation);
            this.companyInformation.SaveChanges();
            return newCompanyInformation.Id;
        }

        public IQueryable<CompanyInformation> All(int page = 1, int pageSize = 10)
        {
            return this.companyInformation
                .All()
                .OrderByDescending(ci => ci.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<CompanyInformation> ById(string name)
        {
            return this.companyInformation
                .All()
                .Where(ci => ci.Name == name);
        }
    }
}
