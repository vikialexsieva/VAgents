namespace VAgents.Info.Areas.Administration.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using Info.Controllers;
    using ViewModel;
    using ViewModel.Demo;
    using Model;

    public class DemoController : BaseController
    {
        public DemoController(ITicketSystemData data) : base(data)
        {
        }

        // GET: Administration/Demo
        public ActionResult Index(int id)
        {
            var getAllDemos = this.Data.Demos.All()
                .Select(x=>new DemosViewModel
                {
                    CreationTime = x.CreationTime,
                    Description = x.Description,
                    Name = x.Name,
                    Image = x.Image,
                });
            return View(getAllDemos);
        }

        // GET: Administration/Demo/Details/5
        public ActionResult Details(int id)
        {
            var getDemoById = this.Data.Demos.All().Where(x => x.Id == id)
                .Select(x=> new DemosViewModel
                {
                    CreationTime = x.CreationTime,
                    Description = x.Description,
                    Image = x.Image,
                    Name = x.Name,
                }).FirstOrDefault();

            return View(getDemoById);
        }

        // GET: Administration/Demo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Demo/Create
        [HttpPost]
        public ActionResult Create(DemosViewModel demo)
        {
            var currentUser = this.UserProfile;
            var createDemo = new VAgents.Info.Model.Demos
            {
                 Name = demo.Name, 
                 Description = demo.Description,
                 CreationTime = DateTime.Now,
                 User = currentUser,
            };

            this.Data.Demos.Add(createDemo);
            this.Data.Demos.SaveChanges();

            return this.Redirect("/");
        }

        // GET: Administration/Demo/Edit/5
        public ActionResult Edit(int id)
        {
            var getDemoEditById = this.Data.Demos.All().Where(x => x.Id == id).FirstOrDefault();
            return View(getDemoEditById);
        }

        // POST: Administration/Demo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var confirmEditDemoById = this.Data.Demos.All().Where(x => x.Id == id).FirstOrDefault();
            this.Data.Demos.Update(confirmEditDemoById);
            this.Data.Demos.SaveChanges();
            return this.Redirect("/");

        }

        // GET: Administration/Demo/Delete/5
        public ActionResult Delete(int id)
        {
            var getDemoDeleteById = this.Data.Demos.All().Where(x => x.Id == id).FirstOrDefault();
            
            return View(getDemoDeleteById);
        }

        // POST: Administration/Demo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var confirmDeleteDemoById = this.Data.Demos.All().Where(x => x.Id == id).FirstOrDefault();
            this.Data.Demos.Delete(confirmDeleteDemoById);
            this.Data.Demos.SaveChanges();

            return this.Redirect("/");
        }

        public ActionResult CreateDemoRevuew()
        {
            return this.View();
        }

        public ActionResult AddDemoRevue(int demoId, DemoRevueViewModel demoRevue)
        {
            var getCurrentDemo = this.Data.Demos.All().Where(x => x.Id == demoId).FirstOrDefault();

            var createDemoRevuew = new DemoRevue()
            {
                CreationTime = DateTime.Now,
                Name = demoRevue.Name,
                Description = demoRevue.Description,
                Demmo = getCurrentDemo,
            };

            this.Data.DemoRevue.Add(createDemoRevuew);
            this.Data.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult UpdateDemoRevue(int id)
        {
            var getDemoRevueById = this.Data.DemoRevue.All().Where(x => x.Id == id).FirstOrDefault();

            return this.View(getDemoRevueById);
        }

        public ActionResult ConfirmUpdateDemoRevue()
        {
            var confirmUpdateDemoRevue = this.Data.DemoRevue.All().FirstOrDefault();
            this.Data.DemoRevue.Update(confirmUpdateDemoRevue);
            this.Data.DemoRevue.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult DeleteDemoRevue(int id)
        {
            var getDeleteDemoRevueById = this.Data.DemoRevue.All().Where(x => x.Id == id).FirstOrDefault();
            
            return this.View(getDeleteDemoRevueById);
        }

        public ActionResult ConfirmDemoRevue(int id)
        {
            var confirmDemoRevueById = this.Data.DemoRevue.All().Where(x => x.Id == id).FirstOrDefault();
            this.Data.DemoRevue.Delete(confirmDemoRevueById);
            this.Data.DemoRevue.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult CreateDemoSample()
        {
            return this.View();
        }

        public ActionResult AddDemoSample(int demoId, DemoSampleViewModel demoSample)
        {
            var getCurrentDemo = this.Data.Demos.All().Where(x => x.Id ==demoId).FirstOrDefault();
            var createDemoSample = new DemoSample
            {
                CreationTime = DateTime.Now,
                Name = demoSample.Name,
                Description = demoSample.Description,
                Demo = getCurrentDemo,
            };

            this.Data.DemoSample.Add(createDemoSample);
            this.Data.DemoSample.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult UpdateDemoSample(string name)
        {
            var getDemoSampleUpdateById = this.Data.DemoSample.All().Where(x => x.Name == name).FirstOrDefault();
            return this.View(getDemoSampleUpdateById);
        }

        public ActionResult ConfirmUpdateDemoSample()
        {
            var confirmDemoSampleById = this.Data.DemoSample.All().FirstOrDefault();
            this.Data.DemoSample.Update(confirmDemoSampleById);
            this.Data.DemoSample.SaveChanges();
            return this.Redirect("/");
        }

                                                
    }
}
