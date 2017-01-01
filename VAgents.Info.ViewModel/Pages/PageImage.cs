namespace VAgents.Info.ViewModel.PageViewModels
{
    using GroupsViewModels;
    using System.Collections.Generic;
    public class PageImage
    {
        public int Id { get; set; }
        
        public string DescriptionForFile { get; set; }
        public string Places { get; set; }
        public int ImageId { get; set; }
        public virtual ICollection<PageImageFileViewModels> image { get; set; }
        public int BusinessInfoId { get; set; }
    }
}