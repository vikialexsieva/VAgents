using VAgents.Info.ViewModel;
using System.Web.Mvc;

namespace VAgents.Server.Controllers
{
    public class UserFamilyController : Controller
    {
      

        public ActionResult Post()
        {
            return this.View();
        }

        public ActionResult Post(FamilyViewModels solution)
        {
           
            return this.Redirect("/");
        }
    }
}
