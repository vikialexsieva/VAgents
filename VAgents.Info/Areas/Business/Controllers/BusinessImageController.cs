namespace VAgents.Info.Areas.Business.Controllers
{
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using VAgents.Info.Controllers;

    public class BusinessImageController : BaseController
    {
        public BusinessImageController(ITicketSystemData data) : base(data)
        {
        }

        // GET: Business/BusinessImage
        public ActionResult Index()
        {
            return View();
        }
    }
}