namespace VAgents.Info.Controllers
{
    using EVP.WebToPay.ClientAPI;
    using System;
    using System.Web.Mvc;
    using Vagents.Info.Data;

    public class CheckoutController : BaseController
    {
        public CheckoutController(ITicketSystemData data) : base(data)
        {
        }


        // GET: Checkout
        public ActionResult Index()
        {
            
            return View();
        }


        /// <summary>
        /// Payment configuration for paysera acccount
        /// </summary>
        /// <see cref="https://developers.paysera.com/en/payments/current"/>
        /// <returns></returns>
        public ActionResult Payment()
        {
            string siteUrl = Request.Url.GetLeftPart(UriPartial.Authority);

            //config projectID and password from paysera 
            int projectId = 0;
            string signPassword = "6c795eec1c0467ec2121a73e2132604b";
            //Config client for paysra API
            Client client = new Client(projectId, signPassword);
            //create request to Paysera.com
            MacroRequest request = client.NewMacroRequest();
            request.OrderId = "ORDER0001";
            request.Amount = 100;
            request.Currency = "USD";
            request.AcceptUrl = siteUrl + "/payment/accept";
            request.CancelUrl = siteUrl + "/payment/cancel";
            request.CallbackUrl = siteUrl + "/payment/callback";
            request.Test = true;

            //redirect to paysera account for payment 
            string redirectUrl = client.BuildRequestUrl(request);
            return Redirect(redirectUrl);
        }
    }
}