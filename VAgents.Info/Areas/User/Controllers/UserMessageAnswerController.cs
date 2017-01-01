using System.Web.Mvc;
using VAgents.Info.ViewModels;

namespace VAgents.Server.Controllers
{
    public class UserMessageAnswerController : Controller
    {
      
        public ActionResult Post(UserMessageAnswerViewModels solution)
        {
           
            return this.View();
        }
    }
}
