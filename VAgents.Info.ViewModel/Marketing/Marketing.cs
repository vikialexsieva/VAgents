namespace VAgents.Info.ViewModel
{
    using Info.Data.Common;
    using Model;
    using System;

    public class MarketingViewModels : IMapFrom<Marketing>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
