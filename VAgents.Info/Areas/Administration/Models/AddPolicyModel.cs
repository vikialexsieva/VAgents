namespace VAgents.Info.Areas.Administration.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class AddPolicyModel
    {

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Полето трябва да е между 10 и 50 символа")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Полето е задължително")]
        [AllowHtml]
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        public string Description { get; set; }
    }
}