namespace VAgents.Info.Areas.Administration.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using VAgents.Info.ViewModel;
    using VAgents.Info.Controllers;
    using Vagents.Info.Data;
    using VAgents.Info.Model.Company;
    using PagedList;

    public class CompanyInformationController : BaseController
    {
        public CompanyInformationController(ITicketSystemData data) : base(data)
        {
        }

        public ActionResult GetAll(int? page)
        {
            var getAll = this.Data.CompanyInformation.All()
                .Select(x => new CompanyInformationViewModels
                {
                    CreationTime = x.CreationTime,
                    Description = x.Description,
                    Name = x.Name
                }).ToPagedList(page ?? 1, 20);
            return this.View(getAll);
        }

        public ActionResult GetById(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return this.Redirect("/");
            }
            var result = this.Data.CompanyInformation.All().Where(x => x.Name == name)
                .Select(x => new CompanyInformationViewModels
                {
                    Description = x.Description,
                    CreationTime = x.CreationTime,
                    Name = x.Name,
                });
            
            return this.View(result);
        }

        public ActionResult Post()
        {
            return View();
        }

        public ActionResult Post(CompanyInformationViewModels companyInfo)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/");
            }
            var createCompanyInfo = new CompanyInformation
            {
                CreationTime = DateTime.Now,
                Description = companyInfo.Description,
                Name = companyInfo.Name
            };

            this.Data.CompanyInformation.Add(createCompanyInfo);
            this.Data.CompanyInformation.SaveChanges();

            return this.Redirect("/");
        }

        public ActionResult Update(int id)
        {
            var getCurrentUpdateCompanyInfo = this.Data.CompanyInformation.All().Where(x => x.Id == id);
            return this.View(getCurrentUpdateCompanyInfo);
        }

        public ActionResult Update()
        {
            var confirmUpdate = this.Data.CompanyInformation.All().FirstOrDefault();
            this.Data.CompanyInformation.Update(confirmUpdate);
            this.Data.CompanyInformation.SaveChanges();

            return this.Redirect("/");
        }

        public ActionResult Delete(int id)
        {
            var getcurrentDeleteCompanyInfo = this.Data.CompanyInformation.All().Where(x => x.Id == id);
            return this.View(getcurrentDeleteCompanyInfo);
        }

        public ActionResult Delete()
        {
            var confirmDelete = this.Data.CompanyInformation.All().FirstOrDefault();
            this.Data.CompanyInformation.Update(confirmDelete);
            this.Data.CompanyInformation.SaveChanges();

            return this.Redirect("/");
        }
    }
}
