using VAgents.Info.ViewModel;
using System.Web.Mvc;

namespace VAgents.Server.Controllers
{
    public class UserOneVideoCommentController : Controller
    {
        public ActionResult Post()
        {
            return View();
        }

        public ActionResult Post(OneVideoCommentViewModels solution)
        {
           
            return this.Redirect("/");
        }
    }
}
