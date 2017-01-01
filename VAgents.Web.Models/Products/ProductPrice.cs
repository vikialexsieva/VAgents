using System;

namespace VAgents.Info.Model
{
    public class ProductPrice
    {
        public int Id { get; set; }
        public virtual Product product{ get; set; }
    }
}