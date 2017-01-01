namespace VAgents.Info.Areas.Administration.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class AboutViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [AllowHtml]
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        public string Description { get; set; }
        public DateTime CreationTime { get; internal set; }
    }
}
