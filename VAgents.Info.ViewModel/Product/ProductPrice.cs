using System;

namespace VAgents.Info.Model
{
    public class ProductPriceViewModels
    {
        public int Id { get; set; }
        public string StartPromoPrice { get; set; }
        public string EndPromoPrice { get; set; }
        public decimal? PromoPrice { get; set; }
        public decimal Price { get; set; }
        public string product{ get; set; }
    }
}