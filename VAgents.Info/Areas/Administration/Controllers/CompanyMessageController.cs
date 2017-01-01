namespace VAgents.Info.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using VAgents.Info.ViewModel.Company;
    using VAgents.Info.Controllers;
    using Vagents.Info.Data;
    using System;
    using VAgents.Info.Model.Company;
    using PagedList;

    public class CompanyMessageController : BaseController
    {
        public CompanyMessageController(ITicketSystemData data) : base(data)
        {
        }

        public ActionResult GetById(int id)
        {
            var result =
                this.Data.CompanyMessage.All()
                .Where(x=>x.Id == id)
                .Select(x => new CompanyMessageViewModels
                {
                    CreationTime = x.CreationTime,
                    Description = x.Description,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Phone = x.Phone,
                    Title = x.Title,
                });

                return this.View(result);
        }

       

        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(CompanyMessageViewModels companyMessage)
        {

            var creationCompanyMessageId = new CompanyMessage
            {
                 CreationTime = DateTime.Now,
                 Description = companyMessage.Description, 
                 FirstName = companyMessage.FirstName,
                 LastName = companyMessage.LastName,
                 Phone = companyMessage.Phone,
                 Title = companyMessage.Title
            };
            this.Data.CompanyMessage.Add(creationCompanyMessageId);
            this.Data.CompanyMessage.SaveChanges();
            return this.View(creationCompanyMessageId);
        } 

        public ActionResult Get(int? page)
        {
            var result = this.Data.CompanyMessage.All()
                .OrderByDescending(x=>x.CreationTime)
                .Select(x => new CompanyMessageViewModels
                {
                    CreationTime = x.CreationTime,
                    Description = x.Description,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Phone = x.Phone,
                    Title = x.Title
                }).ToPagedList(page?? 1, 40);
            return this.View(result);
        }

        public ActionResult Update(int id)
        {
            var getUpdateCompanyMessage = this.Data.CompanyMessage.All().Where(x=>x.Id ==id)
                .FirstOrDefault();
            return this.View(getUpdateCompanyMessage);
        }

        public ActionResult Update()
        {
            var confirmUpdate = this.Data.CompanyMessage.All().FirstOrDefault();

            this.Data.CompanyMessage.Update(confirmUpdate);
            this.Data.CompanyMessage.SaveChanges();

            return this.Redirect("/");
        }

        public ActionResult Delete(int id)
        {
            var getCurrentCompanyMeesage = this.Data.CompanyMessage.All().Where(x => x.Id == id);
            return this.View(getCurrentCompanyMeesage);
        }

        public ActionResult Delete()
        {
            var ConfirmDelete = this.Data.CompanyMessage.All().FirstOrDefault();
            this.Data.CompanyMessage.Delete(ConfirmDelete);
            this.Data.SaveChanges();
            return this.Redirect("/");
        }
    }
}
