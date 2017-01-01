namespace VAgents.Server.Controllers
{
    using VAgents.Info.ViewModel;
    using System.Web.Mvc;
    using VAgents.Info.Controllers;
    using Vagents.Info.Data;
    using VAgents.Info.Model.User;
    using System.Linq;

    public class UserSchoolController : BaseController
    {
        public UserSchoolController(ITicketSystemData data) : base(data)
        {
        }

        [HttpGet]
        public ActionResult Post()
        {
            return this.View();
        }
        [HttpPost]
        public ActionResult Post(SchoolViewModels solution)
        {
            var currentUser = this.UserProfile;
            var result = new School
            {
                DateEdition = solution.DateEdition,
                MountEdition = solution.MountEdition,
                Name = solution.Name,
                Spaciality = solution.Spaciality,
                YearEdition = solution.YearEdition,
                User = currentUser,
            };
            this.Data.School.Add(result);
            this.Data.School.SaveChanges();
            return this.Redirect("/");
        }
        [HttpGet]
        public ActionResult ListAll(string userId)
        {
            var getCurrentUser = this.UserProfile;
            var getAllSchool = this.Data.School.All()
                .Where(x=>x.UserId == userId)
                .Select(x => new SchoolViewModels
            {
                 DateEdition = x.DateEdition,
                 MountEdition = x.MountEdition,
                 Name = x.Name,
                 Spaciality = x.Spaciality,
                 YearEdition = x.YearEdition
            });
            
            return this.PartialView(getAllSchool);
        }
        [HttpGet]
        public ActionResult Update()
        {
            var getCurrentuser = this.UserProfile;
            var getUpdateSchool = this.Data.School.All().Where(x => x.User == getCurrentuser).FirstOrDefault();
            return this.View(getUpdateSchool);
        }
        [HttpPost]
        public ActionResult ConfirmUpdate()
        {
            var getCurrentuser = this.UserProfile;
            var getUpdateSchool = this.Data.School.All().FirstOrDefault();
            this.Data.School.Update(getUpdateSchool);
            this.Data.School.SaveChanges();
            return this.Redirect("/");
        }
        [HttpGet]
        public ActionResult Delete()
        {
            var getCurrentUser = this.UserProfile;
            var getDeleteSchool = this.Data.School.All().Where(x => x.User == getCurrentUser).FirstOrDefault();
            return this.View(getDeleteSchool);
        }
        [HttpPost]
        public ActionResult ConfirmDelete()
        {
            var getCurrentUser = this.UserProfile;
            var getDeleteSchool = this.Data.School.All().FirstOrDefault();
            this.Data.School.Delete(getDeleteSchool);
            this.Data.School.SaveChanges();
            return this.Redirect("/");
        }

    }
}
