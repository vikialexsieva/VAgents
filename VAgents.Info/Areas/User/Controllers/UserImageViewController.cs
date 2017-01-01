using VAgents.Info.ViewModel;
using System.Web.Mvc;

namespace VAgents.Server.Controllers
{
    public class UserImageViewController : Controller
    {
       
        public ActionResult Post(UserImageViewModels solution)
        {
            //var result = this.solutionCat.
            //    Add(
            //        solution.Name,
            //        solution.Description
            //       );
            return this.View();
        }
    }
}
