using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAgents.Info.Model
{
    public class Product
    {
        
        public int Id { get; set; }
        public string ProductName { get; set; }
        public virtual ICollection<ProductContent> ProductContent { get; set; }
        public DateTime StartPromoPrice { get; set; }
        public DateTime EndPromoPrice { get; set; }
        public decimal? PromoPrice { get; set; }
        public decimal Price { get; set; }
    }
}
