using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Web.Mvc;
using VAgents.Info.ViewModel.PageViewModels;

namespace VAgents.Areas.Page.Controllers
{
    public class PageAllInfoController : Controller
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

        public ActionResult Post(PageAllInfoViewModels solution)
        {
          
            return this.Redirect("/");

        }
    } 
}
