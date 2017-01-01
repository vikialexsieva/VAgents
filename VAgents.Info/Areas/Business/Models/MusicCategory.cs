namespace VAgents.Info.Areas.Businesses.Models
{
    using VAgents.Info.ViewModels;

    public class MusicCategoryViewModels
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public virtual BusinessViewModels Business { get; set; }
    }
}