using VAgents.Info.ViewModel;
using System.Web.Mvc;

namespace VAgents.Server.Controllers
{
    public class UserVideoController : Controller
    {
      
        public ActionResult Post()
        {
            return this.View();
        }

        public ActionResult Post(UserVideoViewModels solution)
        {
          
            return this.Redirect("/");
        }
    }
}
