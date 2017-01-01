namespace VAgents.Server.Controllers
{
    using VAgents.Info.ViewModel;
    using System.Web.Mvc;
    using VAgents.Info.Controllers;
    using Vagents.Info.Data;
    using System.Linq;
    using Info.Model.User;

    public class UserLanguegeController : BaseController
    {
        public UserLanguegeController(ITicketSystemData data) : base(data)
        {
        }

        [HttpPost]
        public ActionResult Post()
        {
            return this.View();
        }
        [HttpGet]
        public ActionResult Post(LanguegeViewModels solution)
        {
            var currentUser = this.UserProfile;
            var result = new Languege
            {
                Name = solution.Name,
                User = currentUser
            };
            this.Data.Languege.Add(result);
            this.Data.SaveChanges();
            return this.Redirect("/");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var getUpdateLanguege = this.Data.Languege.All().Where(x => x.Id == id);
            return this.View(getUpdateLanguege);
        }
        [HttpPost]
        public ActionResult Update()
        {
            var currentUser = this.UserProfile;
            var getUpdateLangueage = this.Data.Languege.All().Where(x => x.User == currentUser).FirstOrDefault();
            this.Data.Languege.Update(getUpdateLangueage);
            this.Data.Languege.SaveChanges();
            return this.Redirect("/");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var getDeleteLanguege = this.Data.Languege.All().Where(x => x.Id == id);
            return this.View(getDeleteLanguege);
        }
        [HttpPost]
        public ActionResult Delete()
        {
            var currentUser = this.UserProfile;
            var getDeleteLanguege = this.Data.Languege.All().FirstOrDefault();

            this.Data.Languege.Delete(getDeleteLanguege);
            this.Data.Languege.SaveChanges();
            return this.Redirect("/");
        }
    }
}
