namespace VAgents.Info.Areas.Commubity.Controllers
{
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using VAgents.Info.Controllers;

    public class MusicController : BaseController
    {
        public MusicController(ITicketSystemData data) : base(data)
        {
        }
    }
}