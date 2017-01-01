namespace VAgents.Info.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using VAgents.Info.Model;
    using VAgents.Info.ViewModel;
    using Info.Controllers;
    using AutoMapper;

    public class MarketingController : BaseController
    {
        public MarketingController(ITicketSystemData data) : base(data)
        {
        }

        /// <summary>
        /// TODOS: 
        /// If user is complete 1 or more funcctions get the point ho we post 
        /// If user is buy set new role for the time 
        /// If Current time == time ho user is in current role get all function else set default role 
        /// If user is buy credit for business he can select what like 
        /// If user is select what buy for business get points and change user credit to current credits 
        /// </summary>
        /// <returns></returns>
        // GET: Administration/Marketing
        public ActionResult Index()
        {

            var getAll = this.Data.Marketings
                .All()
                .Select(x=> new MarketingViewModels
                {
                     Description = x.Description, 
                     EndTime = x.EndTime,
                     Name = x.Name,
                     StartTime = x.StartTime
                });
            return View(getAll);
        }

        public ActionResult AddCampain()
        {
            return View();
        }

        /// <summary>
        /// Create new marketing campain
        /// </summary>
        /// <param name="marketing"></param>
        /// <returns></returns>
        public ActionResult AddNewCompain(Marketing marketing)
        {
            var newCompain = new Marketing
            {
                Name = marketing.Name,
                StartTime = marketing.StartTime,
                EndTime = marketing.EndTime,
                Description = marketing.Description
            };
            this.Data.Marketings.Add(newCompain);
            this.Data.SaveChanges();
            return Redirect("");
        }

        /// <summary>
        /// List one campain 
        /// whit all Params 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            var getCampain = this.Data.Marketings.All()
                .Where(x => x.Id == id)
                .Select( x=> new MarketingViewModels
                {
                    Name = x.Name,
                    Description = x.Description,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime
                }).FirstOrDefault();
            return View(getCampain);
        }

        /// <summary>
        /// Create New points for marketing campain
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public ActionResult AddPoint(PointViewModels point)
        {
            if (point != null && ModelState.IsValid)
            {
                var dbPoint = Mapper.Map<Point>(point);
                var marketing = this.Data.Marketings.GetById(point.marketingId);
                if (marketing == null)
                {
                    throw new HttpException(404, "Marketing campain not found");
                }

                marketing.Point.Add(dbPoint);
                this.Data.SaveChanges();

                var viewModel = Mapper.Map<PointViewModels>(dbPoint);
                return PartialView("_PointPartial", viewModel);
            }

            throw new HttpException(400, "invalid point");
        }
        
        public ActionResult ListPoint()
        {
            var listAllPoint = this.Data.Points.All()
                .Select(x => new PointViewModels
                {
                    Name = x.Name,
                    Points = x.Points
                });
            return PartialView("listPoint", listAllPoint);
        }
    }
}