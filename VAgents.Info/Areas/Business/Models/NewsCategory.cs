namespace VAgents.Info.ModelViewModels
{
    public class NewsCategoryViewModels
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public virtual NewsViewModels NewsCategory { get; set; }
    }
}