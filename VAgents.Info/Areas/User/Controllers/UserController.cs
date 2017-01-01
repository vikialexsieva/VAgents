namespace VAgents.Areas.Users.Controllers
{
    using Info.Controllers;
    using Info.Model;
    using Info.ViewModel.User;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.Entity;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Vagents.Info.Data;

    [Route("/user/")]
    public class UserController : BaseController
    {
        public UserController(ITicketSystemData data) : base(data)
        {
        }


        /// <summary>
        /// List all user from search!
        /// 
        /// how to convert year to current ages 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Search(UserViewModels model)
        {
            model.User = this.Data.Users.All()
                //.Where(
                //    //x => (model.FirstName == null || x.FirsName.Contains(model.FirstName))
                //    //    && (model.LastName == null || x.LastName.Contains(model.LastName))
                //)
                .OrderBy(models => model.Sort + " " + model.SortDir)
                .Skip((model.Page - 1) * model.PageSize)
                .Take(model.PageSize)
                .ToList();
            
            //model.TotalRecords = this.Data.Users.All()
            //    .Count(x =>
            //            (model.UserName == null || x.UserName.Contains(model.UserName))
            //            &&
            //            (model.FirstName == null || x.FirsName.Contains(model.FirstName))
            //        );
            return View(model);
        }
        /// <summary>
        /// list all post in current user 
        /// </summary>
        /// <returns></returns>
        public ActionResult Info()
        {
            return View();
        }
        /// <summary>
        /// POST request for current user post
        /// </summary>
        /// <returns></returns>
        public ActionResult PostInfo()
        {
            return Redirect("");
        }
        /// <summary>
        /// this is view for FileUpload system for users
        /// </summary>
        /// <returns></returns>
        public ActionResult FileUpload()
        {
            return View();
        }

        /// <summary>
        /// POST method for fileUpload view 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(UserImages photo, IEnumerable<HttpPostedFileBase> files)
        {
            if (!ModelState.IsValid)
                return View(photo);
            if (files.Count() == 0 || files.FirstOrDefault() == null)
            {
                ViewBag.error = "Please choose a file";
                return View(photo);
            }

            var model = new UserImages();
            foreach (var file in files)
            {
                if (file.ContentLength == 0) continue;

                model.Decription = photo.Decription;
                var fileName = Guid.NewGuid().ToString();
                var extension = Path.GetExtension(file.FileName).ToLower();

                using (var img = Image.FromStream(file.InputStream))
                {
                    model.ThumbPath = string.Format("/GalleryImages/thumbs/{0}{1}", fileName, extension);
                    model.ImagePath = string.Format("/GalleryImages/{0}{1}", fileName, extension);

                    // Save thumbnail size image, 100 x 100
                    SaveToFolder(img, fileName, extension, new Size(100, 100), model.ThumbPath);

                    // Save large size image, 800 x 800
                    SaveToFolder(img, fileName, extension, new Size(600, 600), model.ImagePath);
                }

                // Save record to database
                model.CreatedOn = DateTime.Now;
                this.Data.UserImages.Add(model);
                this.Data.SaveChanges();
            }

            return RedirectPermanent("/home");
        }

        public Size NewImageSize(Size imageSize, Size newSize)
        {
            Size finalSize;
            double tempval;
            if (imageSize.Height > newSize.Height || imageSize.Width > newSize.Width)
            {
                if (imageSize.Height > imageSize.Width)
                    tempval = newSize.Height / (imageSize.Height * 1.0);
                else
                    tempval = newSize.Width / (imageSize.Width * 1.0);

                finalSize = new Size((int)(tempval * imageSize.Width), (int)(tempval * imageSize.Height));
            }
            else
                finalSize = imageSize; // image is already small size

            return finalSize;
        }
        private void SaveToFolder(Image img, string fileName, string extension, Size newSize, string pathToSave)
        {
            // Get new resolution
            string path = ConfigurationSettings.AppSettings["path"].ToString();
            Size imgSize = NewImageSize(img.Size, newSize);
            using (System.Drawing.Image newImg = new Bitmap(img, imgSize.Width, imgSize.Height))
            {
                newImg.Save(Path.GetTempFileName(), img.RawFormat);
            }
        }
        /// <summary>
        /// partial view for vote system Follow user 
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public ActionResult UserLike()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserLike(UserLike userLike)
        {
            if (ModelState.IsValid && userLike != null)
            {
                var currentUser = this.UserProfile;
                var newUserLike = new UserLike
                {
                    Like = userLike.Like,
                    User = currentUser,
                };
                return Redirect("/");
            }
            throw new HttpException(400, "Invalid comment");
        }

        public ActionResult Options()
        {
            return View();
        }

        /// <summary>
        /// partial view for all vote user for the current user 
        /// </summary>
        /// <returns></returns>
        public ActionResult UserFollow(string id)
        {
            var getCurrentUser = this.UserProfile;
            var likeUser = this.Data.Users.All().Where(x => x.Id == id);

            return View();
        }

        [HttpGet]
        public ActionResult Profil(string userName)
        {
            var getUser = this.Data.Users.All()
                .Include(x => x.Followr)
                .Include(x => x.Following)
                .Include(x => x.Business)
                .Include(x => x.UserImages)
                .Where(x => x.UserName == userName)
                .Select(UserViewModels.ViewModel)
                .FirstOrDefault();

            return View(getUser);
        }
    }
}