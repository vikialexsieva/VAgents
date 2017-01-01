using VAgents.Info.ViewModel;
using System.Web.Mvc;

namespace VAgents.Server.Controllers
{
    public class UserOtherContactController : Controller
    {
        

        public ActionResult Post()
        {
            return this.View();
        }

        public ActionResult Post(OtherContactViewModels solution)
        {
           
            return this.View("/");
        }
    }
}
