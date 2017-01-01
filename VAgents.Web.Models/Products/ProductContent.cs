namespace VAgents.Info.Model
{
    public class ProductContent
    {
        public int Id { get; set; }
        public string description { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}