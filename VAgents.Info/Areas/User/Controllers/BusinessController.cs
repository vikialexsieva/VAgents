namespace VAgents.Areas.Users.Controllers
{
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using PagedList;
    using Models;
    using Info.Data.Common;
    using Info.Areas.Businesses.Models;
    using VAgencyes.Data.Models.Business;
    using Info.Model;

    public class BusinessController : Controller
    {
        ITicketSystemData Data;

        [HttpGet]
        /// <summary>
        /// lsit all busines from current users
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int? page)
        {
            var getCurrentUser = this.User.Identity.Name;

            var getAllBusinessFromCurrentUser = this.Data.Business
                .All()
                .Where(x => x.Author.Id == getCurrentUser)
                .OrderBy(x => x.Name)
                .Select(x => new ListAllBusinessViewModels
                {
                     Id= x.Id,
                     Name = x.Name,
                     Description = x.Description,
                     Country = x.Country,
                     City = x.City,
                     Street = x.Street,
                       
                })
                .ToPagedList(page ?? GlobalConstants.Page, GlobalConstants.PageListItem);
                       
           return View(getAllBusinessFromCurrentUser);
        }

        [HttpGet]
        public ActionResult Add()
        {
          
            return View();
        }

        /// <summary>
        /// User create business
        /// </summary>
        /// <param name="businessView"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(BusinessViewModels businessView)
        {
            if (businessView != null && ModelState.IsValid)
            {
                var newBusiness = new Info.Model.BusinessInfo
                {
                    Name = businessView.Name,
                    Street = businessView.Street,
                    City = businessView.City,
                    Country = businessView.Country,
                    Description = businessView.Description,

                };
                if (businessView.Image != null)
                {
                    using (var memory = new MemoryStream())
                    {
                        businessView.Image.InputStream.CopyToAsync(memory);
                        var content = memory.GetBuffer();
                        newBusiness.Image = new BusinessAvatart
                        {
                            Content = content,
                            FileExtension = businessView.Image.FileName.Split(new[] { '.' }).Last()
                        };
                    }
                    this.Data.Business.Add(newBusiness);
                    this.Data.SaveChanges();

                    return RedirectToAction("/");

                }
            }
            
            return View(businessView);
        }
        [HttpPost]
        public ActionResult OtherInformation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OtherInformation(BusinessOtherInfo businessOtherInformation, int businessId)
        {
            if (businessOtherInformation != null && ModelState.IsValid)
            {
                var getBusinessById = this.Data.Business.All().Where(x => x.Id == businessId).FirstOrDefault();
                var newBusinessOtherInfo = new BusinessOtherInfo
                {
                    City = businessOtherInformation.City,
                    Country  = businessOtherInformation.Country,
                    Street = businessOtherInformation.Street
                };

                this.Data.BusinessOtherInfos.Add(newBusinessOtherInfo);
                this.Data.SaveChanges();
                return Redirect("/");
            }
            return this.View(businessOtherInformation);
        }

        [HttpGet]
        public ActionResult AddProductMenu()
        {
            return View();
        }
        [HttpPost]
        /// <summary>
        /// Business menus 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddProductMenu(Menus menu, int Businessid)
        {
            if (menu != null && ModelState.IsValid)
            {
                var getBusinessById = this.Data.Business.All().Where(x => x.Id == Businessid).FirstOrDefault();
                var postNewMenu = new Menus
                {
                    Description = menu.Description,
                    Name = menu.Name,
                    Price = menu.Price,
                    Business = getBusinessById
                };
                this.Data.Menus.Add(postNewMenu);
                this.Data.SaveChanges();
                return Redirect("/");
            }

            return View(menu);
        }
        [HttpGet]
        public ActionResult MusicCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMusicCategory(MusicCategory musicCategory)
        {
            if (ModelState.IsValid)
            {
                var newMusicCategory = new MusicCategory
                {
                     Category = musicCategory.Category,
                };

                this.Data.MusicCategoryes.Add(newMusicCategory);
                this.Data.SaveChanges();

                return Redirect("/");
            }
            return View();
        }
    }
}