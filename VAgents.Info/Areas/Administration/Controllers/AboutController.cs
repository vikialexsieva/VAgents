namespace VAgents.Info.Areas.Administration.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Models;
    using Info.Controllers;
    using Vagents.Info.Data;
    using PagedList;
    using VAgents.Info.Model.Company;
    using System.Data.Entity;
    using System.Net;

    public class AboutController : BaseController
    {
        public AboutController(ITicketSystemData data) : base(data)
        {
        }

        public ActionResult GetAll(int? page)
        {
            var getAll = this.Data.About.All()
                .OrderBy(x=>x.CreationTime)
                .Select(x=>new AboutViewModel {
                  Id = x.Id,
                  CreationTime = x.CreationTime,
                  Description = x.Description,
                  Name = x.Name,
            }).ToPagedList(page ?? 1, 20);
            return this.View(getAll);
        }

        public ActionResult GetById(string name)
        {
            var getAboutById = this.Data.About.All().Where(x => x.Name == name)
                .Select(x => new AboutViewModel
                {
                    Id = x.Id,
                    CreationTime = x.CreationTime,
                    Name = x.Name,
                });

            return this.View(getAboutById);
        }

        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(AboutViewModel about)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/");
            }
            var newPost = new About
            {
                CreationTime = DateTime.Now,
                Name = about.Name,
                Description = about.Description,
            };

            this.Data.About.Add(newPost);
            this.Data.SaveChanges();
            return this.Redirect("/");
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var getCurrentAboutUpdate = this.Data.About.GetById(id);
            if (getCurrentAboutUpdate == null)
            {
                return HttpNotFound();
            }


            return this.View(getCurrentAboutUpdate);
        }
        [HttpPost]
        public ActionResult Edit(About about)
        {
            if (ModelState.IsValid)
            {
                this.Data.Context.Entry(about).State = EntityState.Modified;
                this.Data.SaveChanges();
                return Redirect("/");
            }
            return this.View(about);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var getCurrentDeleteAbout = this.Data.About.GetById(id);

            if (getCurrentDeleteAbout == null)
            {
                return HttpNotFound();
            }
            return View(getCurrentDeleteAbout);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
          
            this.Data.About.Delete(id);
            this.Data.About.SaveChanges();
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
