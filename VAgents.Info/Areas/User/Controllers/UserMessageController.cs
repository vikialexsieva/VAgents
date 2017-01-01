namespace VAgents.Areas.Users.Controllers
{
    using Info.Controllers;
    using PagedList;
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using VAgents.Info.Model;
    using VAgents.Info.ViewModels;


    /// <summary>
    /// TODOS:
    /// Add FirstMessage 
    ///     
    /// List all message 
    /// Get one message 
    /// </summary>
    public class UserMessageController : BaseController
    {
        public UserMessageController(ITicketSystemData data) : base(data)
        {
        }


        /// <summary>
        /// Get all message 
        /// </summary>
        /// <returns></returns>
        // GET: User/UserMessage

        [HttpGet]
        public ActionResult Index(int? page)
        {
            var currentUser = this.UserProfile;
            var getAllUser = this.Data.UserMessages.All()
                .OrderByDescending(x=>x.CreationTime)
                .Select(x=> new UserMessageViewModels
                {
                    CreationTime = x.CreationTime,
                    Message = x.Message,
                    FromUser = currentUser.Id,
                   
                }).ToPagedList(page ?? 1, 50);
                     
            return View(getAllUser);
        }
        
        /// <summary>
        /// get one message from user 
        /// </summary>
        /// <returns></returns>
        public ActionResult Details(int id, string Userid)
        {
            if (!this.Data.UserMessages.All().Any())
            {
                return Redirect("/");
            }

            var firstUser = this.UserProfile.Id;
            var secondUser = this.Data.Users.All().Where(x => x.Id == Userid).FirstOrDefault().ToString(); 
            var getOneMessage = this.Data.UserMessages.All()
                .Where(x => x.Id == id)
                .Select(x=> new UserMessageViewModels {
                     CreationTime = x.CreationTime,
                     ToUser = secondUser,
                     FromUser = firstUser
                });

            return Json(getOneMessage, JsonRequestBehavior.AllowGet);
        }
        
        /// <summary>
        /// Partial for new message 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddNewMessage(int id)
        {
            var getCurrentMessage = this.Data.UserMessages.All().Where(x => x.Id == id).FirstOrDefault();
            return PartialView(getCurrentMessage);
        }

        /// <summary>
        /// post answer message from user
        /// </summary>
        /// <returns></returns>
        public ActionResult AddNewMessage()
        {
            return Redirect("");
        }
        
        /// <summary>
        /// add first message for one user
        /// </summary>
        /// <returns></returns>
        public ActionResult AddFirstMessage(UserMessageViewModels message,string userName)
        {
            var getUser = this.Data.Users.All()
                .Where(x => x.UserName == userName)
                .FirstOrDefault();
            var getCurrentUser = this.UserProfile;
            var addNewUser = new UserMessage
            {
                CreationTime = DateTime.Now,
                FromUser = getCurrentUser,
                ToUser = getUser
            };
            this.Data.UserMessages.Add(addNewUser);
            this.Data.SaveChanges();
            return PartialView("AddFirstMessage",addNewUser);
        }
    }
}