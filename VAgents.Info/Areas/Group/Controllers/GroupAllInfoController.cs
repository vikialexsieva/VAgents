using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Web.Mvc;
using VAgents.Info.ViewModel.GroupsViewModels;

namespace VAgents.Server.Controllers
{
    public class GroupAllInfoController : Controller
    {
        
        public ActionResult GetAll(int page, int pageSize = 10)
        {

            return this.View();
        }

        public ActionResult GetById(string name)
        {
          
            return this.View();
        }

        public ActionResult Post()
        {
            return View();
        }

        public ActionResult Post(GroupAllInfoViewModel solution)
        {
          
            return this.Redirect("/");
        }
    }
}
