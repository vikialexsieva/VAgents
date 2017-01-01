namespace VAgents.Server.Controllers
{
    using VAgents.Info.ViewModel;
    using System.Web.Mvc;
    using VAgents.Info.Model.User;
    using VAgents.Info.Controllers;
    using Vagents.Info.Data;
    using System.Linq;

    public class UserJobsController : BaseController
    {
        public UserJobsController(ITicketSystemData data) : base(data)
        {
        }

        [HttpGet]
        public ActionResult Post()
        {
            return this.View();
        }
        [HttpPost]
        public ActionResult Post(JobsViewModels jobs)
        {
            var currentUser = this.UserProfile;
            var result = new Jobs
            {
                CompanyName = jobs.CompanyName,
                CompanyPosition = jobs.CompanyPosition,
                EndWork = jobs.EndWork,
                StartWork = jobs.StartWork,
                User = currentUser
            };
            this.Data.Jobs.Add(result);
            this.Data.Jobs.SaveChanges();
            return this.Redirect("/");
        }

        [HttpGet]
        public ActionResult Update()
        {
            var getCurrentUser = this.UserProfile;
            var getJobsUpdate = this.Data.Jobs.All().Where(x => x.User == getCurrentUser).FirstOrDefault();

            return this.View(getJobsUpdate);
        }

        [HttpPost]
        public ActionResult ConfirmUpdate()
        {
            var confirmUpdate = this.Data.Jobs.All().FirstOrDefault();
            this.Data.Jobs.Update(confirmUpdate);
            this.Data.Jobs.SaveChanges();

            return this.Redirect("/");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            var getCurrentUser = this.UserProfile;
            var getJobsDelete = this.Data.Jobs.All().Where(x => x.User == getCurrentUser).FirstOrDefault();
            return this.View(getJobsDelete);
        }
        [HttpPost]
        public ActionResult ConfirmDelete()
        {
            var confirmDelete = this.Data.Jobs.All().FirstOrDefault();
            this.Data.Jobs.Update(confirmDelete);
            this.Data.Jobs.SaveChanges();
            return this.Redirect("/");
        }
    }
}
