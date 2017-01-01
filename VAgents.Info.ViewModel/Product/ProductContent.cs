using VAgents.Info.Data.Common;
using VAgents.Info.Model;

namespace VAgents.Info.ViewModels
{
    public class ProductContentViewModels : IMapFrom<ProductContent>
    {
        public ProductContentViewModels()
        {

        }

        public ProductContentViewModels(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; set; }
        public string description { get; set; }
    }
}