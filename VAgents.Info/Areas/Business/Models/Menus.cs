namespace VAgents.Info.Areas.Businesses.Models
{

    public class MenusViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public virtual BusinessViewModels Business { get; set; }
    }
}