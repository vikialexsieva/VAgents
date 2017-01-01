namespace VAgents.Info.Areas.Administration.Controllers
{
    using Info.Controllers;
    using Models;
    using PagedList;
    using System.Linq;
    using System.Web.Mvc;
    using Vagents.Info.Data;

    public class StaticPageController : BaseController
    {
        public StaticPageController(ITicketSystemData data) : base(data)
        {
        }

        // GET: Administration/StaticPage
        public ActionResult Index(int? page)
        {
            var getAllStaticPage = this.Data.StatciPageURLs.All()
                .OrderByDescending(x => x.Name)
                .Select(x => new StaticPageViewModels
                {
                    Name = x.Name,
                    Url = x.URL,
                }).ToPagedList(page ?? 1, 50);
            return this.View(getAllStaticPage);
        }
        
        public ActionResult Post()
        {

            return this.View();
        }

        public ActionResult Post(StaticPageViewModels staticPage)
        {

            return this.Redirect("/");
        }
    }
}