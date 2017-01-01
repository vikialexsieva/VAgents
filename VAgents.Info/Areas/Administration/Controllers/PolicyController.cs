namespace VAgents.Info.Areas.Administration.Controllers
{
    using Info.Controllers;
    using Models;
    using Services;
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using VAgents.Info.Model;
    using VAgents.Info.ViewModel;
    using ViewModel.Policy;

    public class PolicyController : BaseController
    {
        private readonly ISanitizer sanitizer;

        public PolicyController(ITicketSystemData data) : base(data)
        {
        }


        // GET: Administration/Policy
        public ActionResult Index()
        {
            var listAllPolicyViewModel = this.Data.Policy.All()
                .OrderByDescending(x => x.CreationTime)
                .Take(10)
                .Select(x => new ListPolicyViewModel
                {
                    Id = x.Id,
                    DateTime = x.CreationTime,
                    Name = x.Name
                });
            return View(listAllPolicyViewModel);
        }

        public ActionResult Details(int id)
        {
            var listFullPolicy = this.Data.Policy.All()
                .Where(x => x.Id == id)
                .Select(x => new PolicyViewModels
                {
                    Id = x.Id,
                    Name = x.Name,
                    CreationTime = x.CreationTime
                }).FirstOrDefault();

            return View(listFullPolicy);
        }

        public ActionResult AddNewPolicy()
        {
            var model = new AddPolicyModel();
            return View(model);
        }

        public ActionResult CreateNewPolicy(AddPolicyModel policy)
        {

            var createPolicy = new Policy
            {
                 CreationTime= DateTime.Now,
                 Description = policy.Description,
                 Name = policy.Name
            };

            this.Data.Policy.Add(createPolicy);
            this.Data.SaveChanges();

            return Redirect("/");
        }
    }
}