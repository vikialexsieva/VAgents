using System.Web.Mvc;
using VAgents.Info.ViewModels;

namespace VAgents.Server.Controllers
{
    public class UserImageCommentController : Controller
    {
      
        public ActionResult Post()
        {
            return this.View();
        }
        public ActionResult Post(UserImageCommentViewModels solution)
        {
            
            return this.Redirect("/");
        }
    }
}
