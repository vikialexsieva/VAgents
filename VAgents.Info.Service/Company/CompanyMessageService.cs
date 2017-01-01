using System;
using System.Linq;
using VAgents.Info.Service.Contracts.Company;
using Vagents.Info.Data;
using VAgents.Web.Models;
using VAgents.Web.Models.Company;

namespace VAgents.Info.Service.Company
{
    public class CompanyMessageService : ICompanyMessageService
    {
        private readonly IRepository<CompanyMessage> companyMessage;
        private readonly IRepository<ApplicationUser> user; 

        public CompanyMessageService(IRepository<CompanyMessage> companyMessage,
            IRepository<ApplicationUser> user)
        {
            this.companyMessage = companyMessage;
            this.user = user;
        }

        public int Add(string title,
            string description,
            string phone,
            string firstName,
            string lastName)
        {
            var newCompanyMessage = new CompanyMessage
            {
                Title = title,
                Description = description,
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                CreationTime = DateTime.Now,
            };

            this.companyMessage.Add(newCompanyMessage);
            this.companyMessage.SaveChanges();
            return newCompanyMessage.Id;
        }


        public IQueryable<CompanyMessage> All(int page = 1, int pageSize = 10)
        {
            return this.companyMessage
                    .All()
                    .OrderByDescending(cm => cm.CreationTime)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize); 
        }

        public IQueryable<CompanyMessage> ById(string Title)
        {
            return this.companyMessage
                .All()
                .Where(cm => cm.Title == Title); 
        }
    }
}
