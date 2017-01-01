namespace VAgents.Info.Model.Company
{
    public class StaticPageURL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public int ImageId { get; set; }
        public virtual StaticPageUrlImage Image { get; set; }
    }
}
