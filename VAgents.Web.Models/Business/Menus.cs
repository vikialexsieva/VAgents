namespace VAgents.Info.Model
{
    public class Menus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int BusinessId { get; set; }
        public virtual BusinessInfo Business { get; set; }
    }
}