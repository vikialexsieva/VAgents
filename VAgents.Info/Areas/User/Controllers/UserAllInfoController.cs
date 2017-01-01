namespace VAgents.Server.Controllers
{
    using VAgents.Info.ViewModel;
    using System.Web.Mvc;

    public class UserAllInfoController : Controller
    {
     
        public ActionResult Post(UserAllInfoViewModels solution)
        {
           
            return this.Redirect("/");
        }
    }
}
