namespace VAgents.Info.Areas.Business.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using Info.Controllers;
    using VAgents.Info.Model;
    using System;
    using Businesses.Models;
    using PagedList;

    public class BusinessNewsController : BaseController
    {
        public BusinessNewsController(ITicketSystemData data) : base(data)
        {
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Business/BusinessNews
        public ActionResult Index(int businessId, int? page)
        {

            var getAllNewsFromCurrentBusiness = this.Data.News.All().Where(x => x.Business.Id == businessId)
                .OrderByDescending(x => x.CreationTime)
                .Select(x => new BusinessNewsViewModels
                {
                    Id = x.Id,
                    Name = x.Title,

                }).ToPagedList(page??1, 50);


            return View(getAllNewsFromCurrentBusiness);


        }
        
        /// <summary>
        /// Get all news from current Business
        /// Get detail for 1 news author is current business
        /// 
        /// </summary>
        /// <param name="business">
        /// url/business/1 = pesho
        /// 
        /// url/CreatBusiness/1
        /// url/createBusiness/1 = Pesho
        /// 
        /// url/BusinessNews/details/
        /// url/Businessnews/details/1
        /// </param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Details(int id)
        {
            var businessNews = this.Data
                .Business
                .All()
                .Where(x => x.Id == id)
                .Select(x => new BusinessViewModels
                {
                     Name = x.Name,
                })
                .FirstOrDefault();
            //businessNews.News = this.Data.News.All()
            //    .Where(news => news.Business.Id == id)
            //    .OrderByDescending(news=>news.Id == id)
            //    .Select(x=> new NewsViewModels
            //    {
            //         Description = x.Description,
            //         Title = x.Title,
            //         CreationTime = x.CreationTime
            //    })
            //    .ToList();
            return PartialView("NewsDetails", businessNews);
        }

        /// <summary>
        /// If business have like image get like image 
        /// If busines have 1 or more image  get first and set profile
        /// if business note have image get default image
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Image(int id)
        {
           
            return View();
        }

        [HttpGet]
        public ActionResult BusinessNews()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BusinessNews(News news, int businessId)
        {
            var getBusinessById = this.Data.Business.All().Where(x => x.Id == businessId).FirstOrDefault();
            if (ModelState.IsValid && news != null)
            {
                var createNews = new News
                {
                    CreationTime = DateTime.Now,
                    Business = getBusinessById,
                    Description = news.Description,
                    Title = news.Title,
                    NewsCategory = news.NewsCategory,
                };

                this.Data.News.Add(createNews);
                this.Data.SaveChanges();

                return Redirect("/");
            }


            return View();
        }
    }
}