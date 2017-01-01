namespace VAgents.Info.ViewModel.User
{
    using Areas.Businesses.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Model;
    using Info.ViewModels;

    public class UserViewModels
    {
        public UserViewModels()
        {
            this.Sort = "Id";
            this.SortDir = "DESC";
            this.Page = 1;
            this.PageSize = 15;
        }
        public static  Expression<Func<ApplicationUser, UserViewModels>> ViewModel
        {
            get {
                return x => new UserViewModels
                {
                     Id = x.Id,
                     UserLike = x.UserLike.AsQueryable().Select(UserLikeViewModels.ViewModel),
                     UserImageViewModels = x.UserImages.AsQueryable().Select(UserImagesViewModels.ViewModel),
                  
                };
            }
        }
        public string Id { get; set; }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String SortDir { get; set; }
        public String Sort { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }


        public List<ApplicationUser> User { get; set; }

        public  UserLikeImage Avatar { get; set; }
        public  FollowingViewModels Following { get; set; }
        public  FollowrViewModels Followr { get; set; }
        /// <summary>
        /// get 20 result from user like info
        /// Tip I converted the Price property to a string using the ToString("c") method, which renders numerical values as 
        /// currency according to the culture settings that are in effect on your server.For example, if the server is set up as 
        /// en-US, then (1002.3).ToString("c") will return $1,002.30, but if the server is set to en-GB, then the same method will return £1,002.30.
        /// You can change the culture setting for your server by adding a section to the
        /// <system.web> node in the Web.config file like this: <globalization culture = "en-GB" uiCulture= "en-GB" />
        /// 
        ///             repository = repo;
        ///}
        ///public PartialViewResult Menu(string category = null)
        ///{
        ///    ViewBag.SelectedCategory = category;
        ///    IEnumerable<string> categories = repository.Products
        ///                            .Select(x => x.Category)
        ///                            .Distinct()
        ///                            .OrderBy(x => x);
        ///    return PartialView(categories);
        ///}
        /// TotalItems = category == null ?
        ///        repository.Products.Count() :
        ///repository.Products.Where(e  =>  e.Category  ==
        ///category).Count()
        /// .Where(p  =>  category  ==  null  ||  p.Category  == category)

        /// </summary>
        public virtual IEnumerable<UserLikeViewModels> UserLike { get; set; }

        public virtual IEnumerable<BusinessViewModels> Business { get; set; }

        public virtual IEnumerable<UserMessageViewModels> UserMessage { get; set; }

        public virtual IEnumerable<UserImagesViewModels> UserImageViewModels { get; set; }

        public virtual IEnumerable<ProductViewModels> Product { get; set; }
    }
}
