namespace VAgents.Info.Areas.Businesses.Models
{
    using Businesses.Models;
    using Data.Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;
    using System.Web;
    using System.Web.Mvc;
    using VAgents.Info.Model;
    using VAgents.Info.ModelViewModels;

    public class BusinessViewModels : IMapFrom<BusinessInfo>
    {
         
           public int Id { get; set; }
           [DataType(DataType.Text)]
           public string Name { get; set; }
           [DataType(DataType.MultilineText)]
           public string Description { get; set; }
           public string Street { get; set; }
           public string City { get; set; }
           public string Country { get; set; }
        
           public HttpPostedFileBase Image { get; set; }
    }
}