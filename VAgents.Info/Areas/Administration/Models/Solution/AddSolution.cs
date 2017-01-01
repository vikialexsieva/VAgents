namespace VAgents.Info.Areas.Administration.Models.Solution
{
    using System.Web;

    public class AddSolution
    {

        public string Name { get; set; }
        public string Description { get; set; }

        public HttpPostedFileBase Image { get; set; }

    }
}