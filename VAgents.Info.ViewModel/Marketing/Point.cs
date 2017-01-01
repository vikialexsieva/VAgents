namespace VAgents.Info.ViewModel
{
    using VAgents.Info.Data.Common;
    using VAgents.Info.Model;

    public class PointViewModels : IMapFrom<Point> 
    {
        public PointViewModels()
        {

        }
        public PointViewModels(int marktingId)
        {
            this.marketingId = marketingId;
        }
        public int Id { get; set; }
        public int marketingId { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
    }
}