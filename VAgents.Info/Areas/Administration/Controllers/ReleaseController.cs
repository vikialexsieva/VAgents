namespace VAgents.Info.Areas.Administration.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using VAgencyes.ViewModels;
    using Vagents.Info.Data;
    using VAgents.Info.Controllers;
    using PagedList;
    using VAgents.Info.Model.Releases;
    using System.Net;
    using System.Data.Entity;

    public class ReleaseController : BaseController
    {
        public ReleaseController(ITicketSystemData data) : base(data)
        {
        }


        // GET: Administration/Release
        public ActionResult Index(int? page)
        {
            var getAllRelease = this.Data.Release.All()
                .OrderBy(x=>x.CreatioTime)
                .Select(x => new ReleaseHistoryViewModel
                    {
                        CreatioTime = x.CreatioTime,
                            Name = x.Name,

                        }).ToPagedList(page ?? 1, 20);

            return View(getAllRelease);
        }

        // GET: Administration/Release/Details/5
        public ActionResult Details(int id)
        {
            if (!this.Data.Release.All().Any())
            {
                return Redirect("/");
            }
            var getDetails = this.Data.Release.All()
                .Where(x => x.Id == id)
                .Select(x=> new ReleaseHistoryViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    CreatioTime = x.CreatioTime,
                }).FirstOrDefault(  );

            return View(getDetails);
        }

        // GET: Administration/Release/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Release/Create
        [HttpPost]
        public ActionResult Create(ReleaseHistoryViewModel release)
        {
            var createRelease = new ReleaseHistory
            {
                CreatioTime = DateTime.Now,
                Description = release.Description,
                Name = release.Name
            };

            this.Data.Release.Add(createRelease);
            this.Data.Release.SaveChanges();
            return this.Redirect("/");
        }
        
        [HttpGet]
        // GET: Administration/Release/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var getCurrentAboutUpdate = this.Data.Release.GetById(id);
            if (getCurrentAboutUpdate == null)
            {
                return HttpNotFound();
            }
           
            return this.View(getCurrentAboutUpdate);
        }

        // POST: Administration/Release/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ReleaseHistory release)
        {
            if (ModelState.IsValid)
            {
                this.Data.Context.Entry(release).State = EntityState.Modified;
                this.Data.SaveChanges();
                return Redirect("/");
            }
            return this.View(release);
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var getCurrentDeleteAbout = this.Data.Release.GetById(id);

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
            this.Data.Release.Delete(id);
            this.Data.Release.SaveChanges();
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
