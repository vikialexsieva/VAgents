namespace VAgents.Info.Areas.Businesses.Models
{
    public class BusinessOtherInfoViewModel
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public virtual BusinessViewModels Business { get; set; }
    }
}