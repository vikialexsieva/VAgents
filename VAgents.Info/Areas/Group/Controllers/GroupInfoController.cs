namespace VAgents.Server.Controllers
{
    using System.Web.Mvc;
    using VAgents.Info.ViewModel.GroupsViewModels;

    public class GroupInfoController : Controller
    {
        

        public ActionResult GetAll(int page, int pageSize = 10)
        {
           
            return this.View();
        }

        public ActionResult GetById(string name)
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Post(GroupsInfoViewModels solution)
        {
         
            return this.View();
        }
    }
}
