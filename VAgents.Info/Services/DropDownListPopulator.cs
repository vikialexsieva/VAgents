namespace VAgents.Info.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Vagents.Info.Data;

    public class DropDownListPopulator : IDropDownListPopulator
    {
        private ITicketSystemData data;
        private ICacheService cache;
        public DropDownListPopulator(ITicketSystemData data, ICacheService cache)
        {
            this.cache = cache;
            this.data = data;
        }

        public IEnumerable<SelectListItem> GetBusinessCategores()
        {
            var categories = this.cache.Get<IEnumerable<SelectListItem>>("categories",
               () =>
               {
                   return this.data.BusinessCategorys.All()
                   .Select(x => new SelectListItem
                   {
                       Value = x.Id.ToString(),
                       Text = x.Category
                   })
                   .ToList();
               });

            return categories;
        }
    }
}