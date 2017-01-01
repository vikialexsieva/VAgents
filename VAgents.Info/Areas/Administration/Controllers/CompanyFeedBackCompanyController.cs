namespace VVAgents.Info.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using VAgents.Info.ViewModel;
    using System.IO;
    using Vagents.Info.Data;
    using VAgents.Info.Model.Company;
    using AutoMapper;
    using VAgents.Info.Areas.Administration.Models;
    using System.Web;
    using System.Data.Entity;
    using System.Net;
    using VAgents.Info.Controllers;

    public class CompanyFeedBackCompanyController : BaseController
    {
        public CompanyFeedBackCompanyController(ITicketSystemData data) : base(data)
        {
        }

        public ActionResult GetAll(int page)
        {
            var getAllCompanyFeedBackCompany = this.Data.CompanyFeedBackCompany.All()
                .OrderBy(x=>x.CreationTime)

                .Select(x => new InfoCompanyFeedBackCompanyViewModel
                {
                    Id = x.Id,
                    CompanyName = x.CompanyName,
                    Description = x.Description,
                    Image = x.CompanyLogoId
                });
            return this.View(getAllCompanyFeedBackCompany);
        }

        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(
            CompanyFeedBackCompanyViewModel feedBackCompany)
        {

            if (feedBackCompany != null && ModelState.IsValid)
            {
                var dbTicket = Mapper.Map<CompanyFeedBackCompany>(feedBackCompany);
                if (feedBackCompany.CompanyLogo != null)
                {
                    using (var memory = new MemoryStream())
                    {
                        feedBackCompany.CompanyLogo.InputStream.CopyTo(memory);
                        var content = memory.GetBuffer();

                        dbTicket.CompanyLogo = new CompanyLogo
                        {
                            Content = content,
                            FileExtension = feedBackCompany.CompanyLogo.FileName.Split(new[] { '.' }).Last()
                        };
                    }
                }

                this.Data.CompanyFeedBackCompany.Add(dbTicket);
                this.Data.SaveChanges();

                return RedirectToAction("All", "Tickets");
            }


            return this.Redirect("/");
        }

        public ActionResult Details(int id)
        {
            var getCurrentFeedBackCompany = this.Data.CompanyFeedBackCompany.All()
                .Where(x => x.Id == id)
                .Select(x => new InfoCompanyFeedBackCompanyViewModel
                {
                    Id = x.Id,
                    CompanyName = x.CompanyName,
                    Description = x.Description,
                    Image = x.CompanyLogoId,
                });
            return View();
        }
        [HttpGet]
        public ActionResult UpdateCompanyContact(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var getCurrentAboutUpdate = this.Data.CompanyFeedBackCompany.GetById(id);
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
            var getCurrentDeleteAbout = this.Data.CompanyFeedBackCompany.GetById(id);

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

            this.Data.CompanyFeedBackCompany.Delete(id);
            this.Data.CompanyFeedBackCompany.SaveChanges();
            return this.Redirect("/");
        }


        public ActionResult Image(int id)
        {
            var image = this.Data.CompanyLogos.GetById(id);
            if (image == null)
            {
                throw new HttpException(404, "Image not found");
            }

            return File(image.Content, "image/" + image.FileExtension);
        }
    }
}
