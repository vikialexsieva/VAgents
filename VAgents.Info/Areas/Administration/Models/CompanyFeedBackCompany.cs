using System.Web;

namespace VAgents.Info.ViewModel
{
    public class CompanyFeedBackCompanyViewModel
    {

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public HttpPostedFileBase CompanyLogo { get; set; }
        public string Description { get; set; }
    }
}
