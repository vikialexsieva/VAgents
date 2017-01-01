using System;
using System.Collections.Generic;
using System.Linq;
using VAgents.Info.Service.Contracts.Company;
using Vagents.Info.Data;
using VAgents.Web.Models.Company;

namespace VAgents.Info.Service.Company
{
    public class CompanyContactService : ICompanyContactService
    {
        private readonly IRepository<CompanyContact> companyContact;
        public CompanyContactService(IRepository<CompanyContact> companyContact)
        {
            this.companyContact = companyContact;
        }

        public int Add(string phoneNumber, string officeCountry, string workFrom, string workTo)
        {
            var newCompanyContact = new CompanyContact
            {
                OfficeCountry = officeCountry,
                Phonenumber = phoneNumber,
                WorkFrom = workFrom,
                WorkTo = workTo,
                CreationTime = DateTime.Now
            };
            this.companyContact.Add(newCompanyContact);
            this.companyContact.SaveChanges();
            return newCompanyContact.Id;
        }

        public IQueryable<CompanyContact> all(int page = 1, int pageSize = 10)
        {
            return this.companyContact
                .All()
                .OrderByDescending(cc => cc.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<CompanyContact> ById(string OfficeCountry)
        {
            return this.companyContact
                .All()
                .Where(cc => cc.OfficeCountry == OfficeCountry);
        }
    }
}
