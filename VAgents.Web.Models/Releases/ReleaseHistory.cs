namespace VAgents.Info.Model.Releases
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class ReleaseHistory
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 200 символа")]

        public string Name { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(20000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 20000 символа")]
        [AllowHtml]
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        public string Description { get; set; }

        public DateTime CreatioTime { get; set; }
        
    }
}
