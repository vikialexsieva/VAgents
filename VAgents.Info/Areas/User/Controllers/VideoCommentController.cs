using VAgents.Info.ViewModel;
using System.Web.Mvc;

namespace VAgents.Server.Controllers
{
    public class VideoCommentController : Controller
    {
      
        public ActionResult Post()
        {
            return this.View();
        }

        public ActionResult Post(VideoCommentViewModels solution)
        {
          
            return this.Redirect("/");
        }
    }
}
