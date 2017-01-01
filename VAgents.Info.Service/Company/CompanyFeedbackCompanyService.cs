using System;
using System.Linq;
using Vagents.Info.Data;
using VAgents.Info.Service.Contracts.Company;
using VAgents.Web.Models.Company;

namespace VAgents.Info.Service.Company
{
    //public class CompanyFeedbackCompanyService : ICompanyFeedbackCompanyService
    //{
    //    private readonly IRepository<CompanyFeedBackCompany> companyFeedBackCompany;
    //    public CompanyFeedbackCompanyService(IRepository<CompanyFeedBackCompany> companyFeedBackCompany)
    //    {
    //        this.companyFeedBackCompany = companyFeedBackCompany;
    //    }

    //    //public int Add(string companyName, string companyLogo, string description)
    //    //{
    //    //    var newCompanyFeedBackCompany = new CompanyFeedBackCompany
    //    //    {
    //    //        CompanyName = companyName,
    //    //        Description = description,
    //    //        CreationTime = DateTime.Now
    //    //    };

    //    //    this.companyFeedBackCompany.Add(newCompanyFeedBackCompany);
    //    //    this.companyFeedBackCompany.SaveChanges();
    //    //    return newCompanyFeedBackCompany.Id;
    //    //}

    //    public IQueryable<CompanyFeedBackCompany> All(int page = 1, int pageSize = 10)
    //    {
    //        return this.companyFeedBackCompany
    //            .All()
    //            .OrderByDescending(fbc => fbc.CreationTime)
    //            .Skip((page - 1) * pageSize)
    //            .Take(pageSize);
    //    }
    //}
}
