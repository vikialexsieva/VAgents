namespace VAgents.Info.Areas.Forum.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Info.Controllers;
    using Vagents.Info.Data;
    using System;
    using VAgents.Info.ViewModel.Forums;
    using VAgents.Info.Model;

    public class ForumPostController : BaseController
    {
        public ForumPostController(ITicketSystemData data) : base(data)
        {
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult GetAll(int page, int pageSize = 10)
        {

            var result = this.Data.ForumPost.All()
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(x => new ForumPostViewModel
                {
                     CreationTime = x.CreationTime,
                     Description = x.Description,
                     Title = x.Title,
                     UserId = x.UserId,
                });
            return this.View(result);
        }

        public ActionResult GetById(string name)
        {
            var result = this.Data.ForumPost.All().Where(x => x.Title == name)
                .Select(x => new ForumPostViewModel
                {
                    Title = x.Title,
                    Description = x.Description,
                    UserId = x.UserId,
                    CreationTime = x.CreationTime
                });
            return this.View(result);
        }

        public ActionResult Post()
        {
            return View();
        }   

        public ActionResult Post(ForumPostViewModel forumPost)
        {
            var currentUser = this.UserProfile;
            var newForuPost = new ForumPost
            {
                Title = forumPost.Title,
                CreationTime = DateTime.Now,
                Description = forumPost.Description,
                User = currentUser
            };
            this.Data.ForumPost.Add(newForuPost);
            this.Data.SaveChanges();
            return this.View(newForuPost);
        }

        public ActionResult UpdateForumPost(string title)
        {
            var getUpdateForumPost = this.Data.ForumPost.All().Where(x => x.Title == title).FirstOrDefault();
            return this.View(getUpdateForumPost);
        }

        public ActionResult UpdateForumPost()
        {
            var confirmUpdateForumPost = this.Data.ForumPost.All().FirstOrDefault();
            this.Data.ForumPost.Update(confirmUpdateForumPost);
            this.Data.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult DeleteForumPost(int id)
        {
            var getDeleteForumPost = this.Data.ForumPost.All().Where(x => x.Id == id).FirstOrDefault();
            return this.View(getDeleteForumPost);
        }

        public ActionResult DeleteForumPost()
        {
            var confirmDelteForumPost = this.Data.ForumPost.All().FirstOrDefault();
            this.Data.ForumPost.Delete(confirmDelteForumPost);
            this.Data.ForumPost.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult CreatePostComment(int id, ForumPostAnswerViewModel forumPostAnswer)
        {
            var getCurrentForumPost = this.Data.ForumPost.All().Where(x => x.Id == id).FirstOrDefault();
            var currentUser = this.UserProfile;

            var createForumPostComment = new ForumPostAnswer
            {
                CreationTime = forumPostAnswer.CreationTime,
                Name = forumPostAnswer.Name,
                ForumPosts = getCurrentForumPost,
                User = currentUser
            };
            this.Data.ForumPostAnswer.Add(createForumPostComment);
            this.Data.ForumPostAnswer.SaveChanges();
            return this.PartialView();
        }


    }
}
