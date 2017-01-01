using VAgents.Info.ViewModel;
using System.Web.Mvc;

namespace VAgents.Server.Controllers
{
    public class UserPostCommentController :Controller
    {
      

        public ActionResult Post()
        {
            return this.View();
        }

        public ActionResult Post(UserPostCommentViewModels solution)
        {
           
            return this.Redirect("/");
        }

    }
}
