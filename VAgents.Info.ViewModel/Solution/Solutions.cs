namespace VAgents.Info.ViewModel.Solution
{
    using System.Collections.Generic;
    using System.Web;
    using ViewModels;

    public class SolutionsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ImageId { get; set; }
        public HttpPostedFileBase Image { get; set; }
        public decimal Price { get; set; }
        public ICollection<SolutionDownloadLinkViewModel> SolutionDownloadLink { get; set; }
        public ICollection<SolutionSocialLinkViewModel> SolutionSocialLink { get; set; }
    }
}
