using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Web.Mvc;
using VAgents.Info.ViewModel.PageViewModels;

namespace VAgents.Server.Controllers
{
    public class PageInfoController : Controller
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

        public ActionResult Post(PageInfoViewModels solution)
        {
           
            return this.Redirect("/");

        }
    }
}
