namespace VAgents.Info.Areas.Business.Controllers
{
    using Businesses.Models;
    using Info.Controllers;
    using System.Linq;
    using System.Web.Mvc;
    using Vagents.Info.Data;

    public class BusinessController : BaseController
    {
        public BusinessController(ITicketSystemData data) : base(data)
        {
        }


        /// <summary>
        /// List all Business
        /// </summary>
        /// <returns></returns>
        // GET: Business/Business
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// List one business 
        /// </summary>
        /// <returns></returns>
        public ActionResult Business(int id)
        {
            var listBusiness = this.Data.Business.All().Where(x => x.Id == id)
                .Select(x => new BusinessViewModels
                {

                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,

                                        
                });
            return View();
        }

        /// <summary>
        /// Get Business avatar
        /// </summary>
        /// <returns></returns>
        public ActionResult BusinessImage()
        {

            return View();
        }
        
    }
}