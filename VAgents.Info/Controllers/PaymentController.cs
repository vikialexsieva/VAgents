namespace VAgents.Info.Controllers
{
    using EVP.WebToPay.ClientAPI;
    using System;
    using System.Web.Mvc;

    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Accept()
        {
            return View("/");
        }

        public ActionResult Cancel()
        {
            return Redirect("/");
        }

        public ActionResult CalbackUrl()
        {

            ///<summary>
            ///  Set Paysera Id 
            /// Set Paysera passowrd 
            /// </summary>
            int projectId = 90827;
            string signPassword = "6c795eec1c0467ec2121a73e2132604b";

            //config payser user
            Client client = new Client(projectId, signPassword);

            //get information for sucess payment
            MacroCallbackData data = client.GetMacroCallbackData(Request.Params);

            //if have sucess payment get this
            if (data.Status == 1)
            {
                //set information for sucess payment

                MacroCallbackResponse response = new MacroCallbackResponse(MacroCallbackResponseStatus.Ok);
                var view =  response.ToString();

                return View(view);
            }

            else
            {
                return PartialView();
            }
        }
        
        public ActionResult MicroAnswer()
        {

            ///<summary>
            ///  Set Paysera Id 
            /// Set Paysera passowrd 
            /// </summary>
            int projectId = 90827;
            string signPassword = "6c795eec1c0467ec2121a73e2132604b";

            //config for paysera dev tools 
            Client client = new Client(projectId, signPassword);

            //creat SMS sucess paysment
            MicroAnswer microAnswer = client.NewMicroAnswer();
            microAnswer.SmsId = 1;
            microAnswer.Message = "Your account has been filled. Thank you!";

            client.SendMicroAnswer(microAnswer);

            return Redirect("/");
        }

        public ActionResult RepeatRequest()
        {
            string siteUrl = Request.Url.GetLeftPart(UriPartial.Authority);

            ///<summary>
            ///  Set Paysera Id 
            /// Set Paysera passowrd 
            /// </summary>
            int projectId = 90827;
            string signPassword = "6c795eec1c0467ec2121a73e2132604b";

            //config client for paysera
            Client client = new Client(projectId, signPassword);

            // create orderID
            string orderId = "ORDER00001";
            string redirectUrl = client.BuildRepeatRequestUrl(orderId);

            return  Redirect(redirectUrl);
        }

        public ActionResult MicroCalback()
        {
            ///<summary>
            ///  Set Paysera Id 
            /// Set Paysera passowrd 
            /// </summary>
            int projectId = 90827;
            string signPassword = "6c795eec1c0467ec2121a73e2132604b";

            Client client = new Client(projectId, signPassword);

            // This throws if callback didn't came from us
            ICallbackData data = client.GetMicroCallbackData(Request.Params);

            // Callback identity check passed and here you can provide services below

            MicroCallbackResponse response = new MicroCallbackResponse(MicroCallbackResponseStatus.Ok, "Thank you!");

            return View(response.ToString());
        }
    }
}