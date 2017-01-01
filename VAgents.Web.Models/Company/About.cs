namespace VAgents.Info.Model.Company
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class About
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [AllowHtml]
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
