using VAgents.Info.ViewModel;
using System.Web.Mvc;

namespace VAgents.Server.Controllers
{
    public class UserImageViewCommentController : Controller
    {
       
        public ActionResult Post()
        {
            return this.View();
        }

        public ActionResult Post(UserImageViewCommentViewModels solution)
        {
           
            return this.Redirect("/");
        }
    }
}
