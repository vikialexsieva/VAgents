namespace VAgents.Info.ViewModel.PageViewModels
{
    using System.Collections.Generic;

    public class PageInfoViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<PageImage> GroupImage { get; set; }
        public virtual ICollection<PageAllInfoViewModels> GroupAllInfo { get; set; }
        
   }
}
