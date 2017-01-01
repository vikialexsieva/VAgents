namespace VAgents.Info.Areas.Businesses.Models
{
    public class BusinessPriceRangeViewModel
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public virtual BusinessPriceRangeViewModel BusinessPrice { get; set; }
    }
}