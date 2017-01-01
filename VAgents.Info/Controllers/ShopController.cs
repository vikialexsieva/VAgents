namespace VAgents.Info.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Vagents.Info.Data;

    public class ShopController : BaseController
    {
        public ShopController(ITicketSystemData data) : base(data)
        {
        }


        /// <summary>
        /// Get all product 
        /// </summary>
        /// <example>
        ///     Name
        ///     Description
        ///     Price
        ///     PromoPrice
        /// </example>
        /// <returns>Collection for products</returns>
        public ActionResult Index()
        {
            var getAllProduct = this.Data.Products.All();
            return View(getAllProduct);
        }
        
        ///<summary>
        /// Get one products
        /// </summary>
        /// <example>
        ///     Name
        /// </example>
        /// <returns>
        ///  one product
        /// </returns>
        public ActionResult Details(int id)
        {
            var getAll = this.Data.Products.All()
                .Where(x => x.Id == id);
            return View(getAll);
        }
    }
}