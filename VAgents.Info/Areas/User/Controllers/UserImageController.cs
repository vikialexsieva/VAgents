namespace VAgents.Areas.Users.Controllers
{
    using Info.Controllers;
    using Info.Data.Common;
    using Models;
    using System.Linq;
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using VAgents.Info.Model;
    using VAgents.Info.ViewModels;

    public class UserImageController : BaseController
    {
        public UserImageController(ITicketSystemData data) : base(data)
        {
        }

        /// <summary>
        /// list all image from current user
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public ActionResult Index(string filter = null, int page = 1, int pageSize = 20)
        {
            var records = new PagedList<UserImages>();
            ViewBag.filter = filter;

            records.Content = this.Data.UserImages.All()
                        .Where(x => filter == null || (x.Decription.Contains(filter)))
                        .OrderByDescending(x => x.Id)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

            // Count
            records.TotalRecords = this.Data.UserImages
                            .All()
                            .Where(x => filter == null || (x.Decription.Contains(filter))).Count();

            records.CurrentPage = page;
            records.PageSize = pageSize;

            return View(records);
        }
        /// <summary>
        /// get 1 image and information from images 
        /// </summary>
        /// <example>
        ///     UserImage 
        ///     Comment 
        ///     DataTime
        ///     LikeImage
        ///     Image place
        /// </example>
        /// <returns></returns>
        /// 
        [HttpGet]
        public ActionResult Details()
        {

            return View();
        }

        /// <summary>
        /// POST for current user image
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpPost]
        public ActionResult PostComment(UserImageCommentViewModels comment)
        {
            if (ModelState.IsValid)
            {
                var userId = this.UserProfile;
                var userName = this.User.Identity.Name;
                //this.Data.UserImageComments.Add(new UserImageComment()
                //{
                //   Comment= comment.Comment,
                //   CreationTime = comment.CreationTime,
                //   User = userId,
                //   UserImageId = comment.UserImage
                //});
                this.Data.SaveChanges();
                var viewModels = new ListUserImageCommentViewModel
                {
                    AuthorUserName = userName,
                    Content = comment.Comment
                };
                return PartialView("_CommentPartial", viewModels);
            } 
            return PartialView();
        }

        /// <summary>
        /// Post and get for current user iamge
        /// </summary>
        /// <returns></returns>
        public ActionResult VoteImages()
        {
            var getUserId = this.UserProfile;
          
            return Redirect("");
        }
    }
}