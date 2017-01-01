namespace VAgents.Info.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using VAgents.Info.ViewModel;
    using Info.Controllers;
    using Vagents.Info.Data;
    using System;
    using VAgents.Info.Model.Company;
    using PagedList;
    using System.Data.Entity;
    using System.Net;

    public class CompanyContactController : BaseController
    {
        public CompanyContactController(ITicketSystemData data) : base(data)
        {
        }

        public ActionResult GetAll(int? page)
        {
            var getAll = this.Data.CompanyContact.All()
                .OrderBy(x=>x.CreationTime)
                .Select(x => new CompanyContactViewModel
                {
                    OfficeCountry = x.OfficeCountry,
                    Phonenumber = x.Phonenumber,
                    WorkFrom = x.WorkFrom,
                    WorkTo = x.WorkTo,
                }).ToPagedList(page ?? 1, 20);
            return this.View(getAll);
        }

        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(CompanyContactViewModel companyContact)
        {
            var createCompanyContactId = new CompanyContact
            {
                  CreationTime = DateTime.Now,
                  OfficeCountry = companyContact.OfficeCountry,
                  Phonenumber = companyContact.Phonenumber,
                  WorkFrom = companyContact.WorkFrom,
                  WorkTo = companyContact.WorkTo
            };

            this.Data.CompanyContact.Add(createCompanyContactId);
            this.Data.CompanyContact.SaveChanges();
            return this.Redirect("/");
        }
        /// <summary>
        /// Get office.
        /// </summary>
        /// <param name="officeCountry"></param>
        /// <returns></returns>
        /// 
        public ActionResult GetById(string officeCountry)
        {
            if (string.IsNullOrEmpty(officeCountry))
            {
                return this.Redirect("/");
            }
            var result =
                this.Data.CompanyContact.All()
                .Where(x => x.OfficeCountry == officeCountry)
                .Select(x => new CompanyContactViewModel
                {
                     OfficeCountry = x.OfficeCountry,
                     Phonenumber = x.Phonenumber,
                     WorkFrom = x.WorkFrom,
                     WorkTo = x.WorkTo
                });
            ///TODO: 
            /// List collection with email, name and position
            return this.View(result);
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
        public ActionResult UpdateCompanyContact(CompanyContactViewModel companyContact)
        {
            if (ModelState.IsValid)
            {
                this.Data.Context.Entry(companyContact).State = EntityState.Modified;
                this.Data.SaveChanges();
                return Redirect("/");
            }
            return this.View(companyContact);
        }

        [HttpGet]
        public ActionResult DeleteCompanyContact(int id)
        {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var getCurrentDeleteAbout = this.Data.CompanyContact.GetById(id);

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

            this.Data.CompanyContact.Delete(id);
            this.Data.CompanyContact.SaveChanges();
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
