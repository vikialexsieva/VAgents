using System;
using System.Linq;
using VAgents.Info.Service.Contracts.Company;
using Vagents.Info.Data;
using VAgents.Web.Models.Company;
using VAgents.Info.Services.Contracts.Company;

namespace VAgents.Info.Service.Company
{
    public class CompanyFeedBackClientService : ICompanyFeedBackClientService
    {
        private readonly IRepository<CompanyFeedBackClient> companyFeedBackClient;
        public CompanyFeedBackClientService(IRepository<CompanyFeedBackClient> companyFeedbackClient)
        {
            this.companyFeedBackClient = companyFeedbackClient;
        }

        public int Add(string name, string lastName, string workInCompany, string companyPosition, string Description)
        {
            var newCompanyFeedbackClient = new CompanyFeedBackClient
            {
                 CompanyPosition =companyPosition,
                 Description  = Description,
                 LastName = lastName,
                 Name = name,
                 WorkInCompany = workInCompany,
                 CreationTime = DateTime.Now,
            };
            this.companyFeedBackClient.Add(newCompanyFeedbackClient);
            this.companyFeedBackClient.SaveChanges();
            return newCompanyFeedbackClient.Id;
        }

        public IQueryable<CompanyFeedBackClient> All(int page = 1, int pageSize = 10)
        {
            return this.companyFeedBackClient
                .All()
                .OrderByDescending(pr => pr.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<CompanyFeedBackClient> byId(string CompanyPosition)
        {
            return this.companyFeedBackClient
                .All()
                .Where(fbc => fbc.CompanyPosition == CompanyPosition);
        }
    }
}
