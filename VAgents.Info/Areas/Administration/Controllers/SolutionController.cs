namespace VAgents.Info.Areas.Administration.Controllers
{
    using Info.Controllers;
    using PagedList;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using Model.Solution;
    using Vagents.Info.Data;
    using ViewModel.Solution;

    public class SolutionController : BaseController
    {
        public SolutionController(ITicketSystemData data) : base(data)
        {
        }

        // GET: Administration/Solution
        public ActionResult Index(int? page)
        {
            var listAllSolution = this.Data.Solution.All()
                .Select(x=> new SolutionsViewModel
                {
                    Description = x.Description,
                    ImageId = x.ImageId,
                    Name = x.Name,
                    Price = x.Price,
                })
                .ToPagedList(page?? 1, 50);

            return View(listAllSolution);
        }

        // GET: Administration/Solution/Details/5
        public ActionResult Details(string name)
        {
            var getById = this.Data.Solution.All().Where(x => x.Name == name)
                .Select(x=> new SolutionsViewModel
                {
                   Description = x.Description,
                   Name = x.Name,
                   ImageId = x.ImageId,
                   Price = x.Price,
                }).FirstOrDefault();
            return View(getById);
        }

        // GET: Administration/Solution/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Solution/Create
        [HttpPost]
        public ActionResult Create(SolutionsViewModel solution)
        {
            var createSolution = new Solutions
            {
                Name = solution.Name,
                Description = solution.Description,
                Price = solution.Price,
              
            };
            if (solution.Image != null)
            {
                using (var memory = new MemoryStream())
                {
                    solution.Image.InputStream.CopyTo(memory);
                    var content = memory.GetBuffer();

                    //createSolution.Image = new SolutionImage
                    //{
                    //    Content = content,
                    //    Extension = solution.Image.FileName.Split(new[] { '.' }).Last()
                    //};
                }

            }
            this.Data.Solution.Add(createSolution);
            this.Data.Solution.SaveChanges();

            return this.Redirect("/");
        }

        // GET: Administration/Solution/Edit/5
        public ActionResult Edit(string name)
        {
            var listSolutionForEdit = this.Data.Solution.All().Where(x => x.Name == name).FirstOrDefault();


            return View(listSolutionForEdit);
        }

        // POST: Administration/Solution/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var confirmUpdateSolution = this.Data.Solution.All().Where(x => x.Id == id).FirstOrDefault();
            this.Data.Solution.Update(confirmUpdateSolution);
            this.Data.Solution.SaveChanges();
            return this.Redirect("/");
        }

        // GET: Administration/Solution/Delete/5
        public ActionResult SolutionDelete(int id)
        {
            var getSolutionForDeleteById = this.Data.Solution.All().Where(x => x.Id == id).FirstOrDefault();
            return View(getSolutionForDeleteById);
        }

        //// POST: Administration/Solution/Delete/5
        //public ActionResult ConfirmSolutionDelete()
        //{
        //    var confirmDeleteSolutionById = this.Data.Solution.All().FirstOrDefault();
        //    this.Data.Solution.Delete(confirmDeleteSolutionById);
        //    this.Data.Solution.SaveChanges();
        //    this.Redirect("/");
        //}

        public ActionResult SolutionDelete()
        {
            var confirmDeleteSolutionById = this.Data.Solution.All().FirstOrDefault();
            this.Data.Solution.Delete(confirmDeleteSolutionById);
            this.Data.Solution.SaveChanges();
            return Redirect("/");
        }

        public ActionResult PostSolutionSocLink()
        {
            return this.View();
        }

        public ActionResult PostSolutionSocialLink(int id, SolutionSocialLink solutionSocLink)
        {
            var getCurrentSolution = this.Data.Solution.All().Where(x => x.Id == id).FirstOrDefault();
            var getAllPost = new SolutionSocialLink
            {
                Solution = getCurrentSolution,
                URL = solutionSocLink.URL,
            };

            this.Data.SolutionSocialLink.Add(getAllPost);
            this.Data.SolutionSocialLink.SaveChanges();

            return this.Redirect("/");
        }

        public ActionResult UpdateSolutionSocLink(int id)
        {
            var getCurrentUpdateSocialLink = this.Data.SolutionSocialLink.All().Where(x => x.Id == id);

            return this.View(getCurrentUpdateSocialLink);
        }

        public ActionResult UpdateSolutionSocLink()
        {
            var getSolutionSocialLinkForUpdate = this.Data.SolutionSocialLink.All().FirstOrDefault();
            this.Data.SolutionSocialLink.Update(getSolutionSocialLinkForUpdate);
            this.Data.SolutionSocialLink.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult DeleteSolutionSocLink(int id)
        {
            var getCurrentDeleteSocLink = this.Data.SolutionSocialLink.All().Where(x => x.Id == id);
            return this.View(getCurrentDeleteSocLink);
        }

        public ActionResult DeleteSolutionSocLink()
        {
            var getSolutionSocLink = this.Data.SolutionSocialLink.All().FirstOrDefault();
            this.Data.SolutionSocialLink.Delete(getSolutionSocLink);
            this.Data.SolutionSocialLink.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult AddSolutionDownloadLink()
        {
            return this.View();
        }

        public ActionResult AddSolutionDownloadLink(int id, SolutionDownloadLink solDownloadLink)
        {
            var getSolutionById = this.Data.Solution.All().Where(x => x.Id == id).FirstOrDefault();
            var createDownloadLink = new SolutionDownloadLink
            {
                URL = solDownloadLink.URL,
                Solution = getSolutionById,
            };

            this.Data.SolutionDownloadLink.Add(createDownloadLink);
            this.Data.SolutionDownloadLink.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult UpdateSolutionDownloadLink(int id)
        {
            var getCurrentSolutionDownloadLink = this.Data.SolutionDownloadLink.All().Where(x => x.Id == id);
            return this.View(getCurrentSolutionDownloadLink);
        }

        public ActionResult UpdateSolutionDownloadLink()
        {
            var confirmUpdateSolutionDownloadLink = this.Data.SolutionDownloadLink.All().FirstOrDefault();
            this.Data.SolutionDownloadLink.Update(confirmUpdateSolutionDownloadLink);
            this.Data.SolutionDownloadLink.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult DeleteSolutionDownloadLink(int id)
        {
            var getCurrentDeleteDownloadLink = this.Data.SolutionDownloadLink.All().Where(x => x.Id == id);
            return this.View(getCurrentDeleteDownloadLink);
        }

        public ActionResult DeleteSolutionDownloadLink()
        {
            var confirmSolutionDownloadLink = this.Data.SolutionDownloadLink.All().FirstOrDefault();
            this.Data.SolutionDownloadLink.Delete(confirmSolutionDownloadLink);
            this.Data.SolutionDownloadLink.SaveChanges();
            return this.Redirect("/");
        }
    }
}