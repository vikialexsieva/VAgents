namespace VAgents.Info.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using Vagents.Info.Data;
    using FourSquare.SharpSquare.Core;
    using FourSquare.SharpSquare.Entities;

    public class HomeController : Controller
    {
        ITicketSystemData Data;
        public HomeController(ITicketSystemData data) 
        {
            this.Data = data;
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Business()
        {
            //var getAllBusiness = this.Data.busies.All().ProjectTo<BusinessViewModels>();
            //return View(getAllBusiness);
            return View();
        }
        
        public ActionResult Foursqueres()
        {
            string clientId = "CLIENT_ID";
            string clientSecret = "CLIEND_SECRET";
            string redirectUri = "REDIRECT_URI";
            SharpSquare sharpSquare = new SharpSquare(clientId, clientSecret);
            if (Request["code"] != null)
            {
                sharpSquare.GetAccessToken(redirectUri, Request["code"]);
                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("venueId", "VENUE_ID");
                parameters.Add("broadcast", "public");
                Checkin checkin = sharpSquare.AddCheckin(parameters);
                
                 sharpSquare.SearchVenues(parameters);

            }

            
            return PartialView();
        }

        public ActionResult ListUser()
        {
            return View();
        }
        /// <summary>
        /// List policy with name
        /// </summary>
        /// <returns></returns>
        public ActionResult GetAllPolicy()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// Read policy
        /// </returns>
        public ActionResult PolicyesDetail(int id)
        {
            //var listFullPolicy = this.Data.Policies.All()
            // .Where(x => x.Id == id)
            // .Select(x => new PolicyViewModels
            // {
            //     Id = x.Id,
            //     Name = x.Name,
            //     Description = x.Description,
            //     CreationTime = x.CreationTime
            // });
            //return View(listFullPolicy);

            return View();
        }
    }
}