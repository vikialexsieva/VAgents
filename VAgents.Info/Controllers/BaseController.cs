
namespace VAgents.Info.Controllers
{
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Model;

    [HandleError]
    public class BaseController : Controller
    {
        public BaseController(ITicketSystemData data)
        {
            this.Data = data;
        }


        protected ITicketSystemData Data { get; private set; }

        protected ApplicationUser UserProfile { get; private set; }
        

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                this.UserProfile = this.Data.Users.All()
                    .Where(u => u.UserName == requestContext.HttpContext.User.Identity.Name)
                    .FirstOrDefault();
            }

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}
