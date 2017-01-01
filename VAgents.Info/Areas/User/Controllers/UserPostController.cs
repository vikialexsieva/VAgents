namespace VAgents.Server.Controllers
{
    using VAgents.Info.ViewModel;
    using System.Web.Mvc;
    using VAgents.Info.Controllers;
    using Vagents.Info.Data;
    using VAgents.Info.Model.User;
    using System;
    using System.Linq;

    public class UserPostController : BaseController
    {
        public UserPostController(ITicketSystemData data) : base(data)
        {
        }

        public ActionResult Post()
        {

            return this.View();
        }

        public ActionResult Post(UserPostViewModels solution)
        {
            var getCurrentuser = this.UserProfile;
            var result = new UserPost
            {
                CreationTime = DateTime.Now,
                User = getCurrentuser,
                Post = solution.Post
            };
            this.Data.UserPost.Add(result);
            this.Data.UserPost.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult Update()
        {
            var getCurrentUser = this.UserProfile;
            var getUpdatePost = this.Data.UserPost.All().Where(x => x.User == getCurrentUser).FirstOrDefault();
            return this.View(getUpdatePost);
        }

        public ActionResult AddUpdate()
        {
            var getCurrentUser = this.UserProfile;
            var getUpdatePost = this.Data.UserPost.All().FirstOrDefault();
            this.Data.UserPost.Update(getUpdatePost);
            this.Data.UserPost.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult Delete()
        {
            var getCurrentUser = this.UserProfile;
            var getDeletePost = this.Data.UserPost.All().Where(x => x.User == getCurrentUser).FirstOrDefault();
            return this.View(getDeletePost);
        }

        public ActionResult ConfirmDelete()
        {
            var getCurrentUser = this.UserProfile;
            var confirmDelete = this.Data.UserPost.All().Where(x => x.User == getCurrentUser).FirstOrDefault();
            this.Data.UserPost.Delete(confirmDelete);
            this.Data.UserPost.SaveChanges();
            return this.View();
        }
    }
}
