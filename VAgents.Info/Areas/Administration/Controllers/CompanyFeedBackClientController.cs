namespace VAgents.Info.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using VAgents.Info.ViewModel;
    using VAgents.Info.Controllers;
    using Vagents.Info.Data;
    using System;
    using VAgents.Info.Model.Company;
    using PagedList;
    using System.Data.Entity;
    using System.Net;

    public class CompanyFeedBackClientController : BaseController
    {
        public CompanyFeedBackClientController(ITicketSystemData data) : base(data)
        {
        }

        public ActionResult GetAll(int? page)
        {
            var getAll = this.Data.CompanyFeedBackClient.All()
                .OrderBy(x=>x.CreationTime)
                .Select(x => new CompanyFeedBackClientViewModel
                {
                     CompanyPosition = x.CompanyPosition,
                     Description = x.Description,
                     LastName = x.LastName,
                     Name = x.Name,
                     WorkInCompany = x.WorkInCompany
                }).ToPagedList(page ?? 1, 20);
                return this.View(getAll);
        }

        public ActionResult Get(string companyPosition)
        {
            if (string.IsNullOrEmpty(companyPosition))
            {
                return this.Redirect("/");
            }
            var getById =
                this.Data.CompanyFeedBackClient.All()
                .Where(x => x.CompanyPosition == companyPosition)
                .Select(
                    x => new CompanyFeedBackClientViewModel
                    {
                         CompanyPosition = x.CompanyPosition,
                         Description  = x.Description,
                         LastName = x.LastName,
                         Name = x.Name,
                         WorkInCompany=x.WorkInCompany
                    });
            
            return this.View(getById);
        }

        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(CompanyFeedBackClientViewModel FeedBack)
        {
            var newClientFeedbackId = new CompanyFeedBackClient
            {
                 CompanyPosition = FeedBack.CompanyPosition,
                 CreationTime = DateTime.Now,
                 Description = FeedBack.Description,
                 LastName = FeedBack.LastName,
                 Name = FeedBack.Name,
                 WorkInCompany = FeedBack.WorkInCompany
            };
            this.Data.CompanyFeedBackClient.Add(newClientFeedbackId);
            return this.Redirect("/");
        }


        [HttpGet]
        public ActionResult UpdateCompanyContact(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var getCurrentAboutUpdate = this.Data.CompanyFeedBackClient.GetById(id);
            if (getCurrentAboutUpdate == null)
            {
                return HttpNotFound();
            }


            return this.View(getCurrentAboutUpdate);
        }
        [HttpPost]
        public ActionResult UpdateCompanyContact(CompanyFeedBackClientViewModel companyFeedBack)
        {
            if (ModelState.IsValid)
            {
                this.Data.Context.Entry(companyFeedBack).State = EntityState.Modified;
                this.Data.SaveChanges();
                return Redirect("/");
            }
            return this.View(companyFeedBack);
        }

        [HttpGet]
        public ActionResult DeleteCompanyContact(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var getCurrentDeleteAbout = this.Data.CompanyFeedBackClient.GetById(id);

            if (getCurrentDeleteAbout == null)
            {
                return HttpNotFound();
            }
            return View(getCurrentDeleteAbout);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCompanyContact(int? id)
        {

            this.Data.CompanyFeedBackClient.Delete(id);
            this.Data.CompanyFeedBackClient.SaveChanges();
            return this.Redirect("/");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Data.Context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
