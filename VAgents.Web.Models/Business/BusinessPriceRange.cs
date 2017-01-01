namespace VAgents.Info.Model
{
    public class BusinessPriceRange
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public virtual BusinessInfo Business { get; set; }
    }
}