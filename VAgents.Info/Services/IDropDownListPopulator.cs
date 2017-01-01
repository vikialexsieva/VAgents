namespace VAgents.Info.Services
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    public interface IDropDownListPopulator
    {
        IEnumerable<SelectListItem> GetBusinessCategores();
    }
}