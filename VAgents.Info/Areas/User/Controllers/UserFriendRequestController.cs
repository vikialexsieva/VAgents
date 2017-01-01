using VAgents.Info.ViewModel;
using System.Web.Mvc;

namespace VAgents.Server.Controllers
{
    public class UserFriendRequestController : Controller
    {
      

        public ActionResult Post()
        {
            return this.View();
        }


        public ActionResult Post(UserFriendRequestViewModels solution)
        {
            var result = "Heeloo";
            return this.Redirect("/");
        }
    }
}
