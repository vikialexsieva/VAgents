namespace VAgents.Server.Controllers
{
    using VAgents.Info.ViewModel;
    using System.Web.Mvc;
    using VAgents.Info.Controllers;
    using Vagents.Info.Data;
    using VAgents.Info.Model;
    using System.Linq;

    public class UserPoliticController : BaseController
    {
        public UserPoliticController(ITicketSystemData data) : base(data)
        {
        }

        [HttpGet]
        public ActionResult Post()
        {
            return this.View();
        }
        [HttpPost]
        public ActionResult Post(PoliticViewModels solution)
        {
            var getCurrentUser = this.UserProfile;
            var result = new Politic
            {
                Name = solution.Name,
                Description = solution.Description,
                User = getCurrentUser
            };

            this.Data.Politics.Add(result);
            this.Data.Politics.SaveChanges();
            return this.Redirect("/");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var getUpdatePolitic = this.Data.Politics.All().Where(x => x.Id == id).FirstOrDefault();
            return this.View(getUpdatePolitic);
        }
        [HttpPost]
        public ActionResult Update()
        {
            var getCurrentUser = this.UserProfile;
            var getUpdateDelete = this.Data.Politics.All().Where(x=>x.User == getCurrentUser).FirstOrDefault();
            this.Data.Politics.Update(getUpdateDelete);
            this.Data.Politics.SaveChanges();
            return this.Redirect("/");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var getDeletePolitic = this.Data.Politics.All().Where(x=>x.Id == id).FirstOrDefault();
            return this.View(getDeletePolitic);
        }
        [HttpPost]
        public ActionResult Delete()
        {
            var getCurrentUser = this.UserProfile;
            var getDeltePolitic = this.Data.Politics.All().Where(x => x.User == getCurrentUser);
            this.Data.Politics.Delete(getDeltePolitic);
            this.Data.Politics.SaveChanges();
            return this.Redirect("/");
        }
    }
}
