namespace VAgents.Info.Model.Page
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class PageImage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 20 символа")]

        public string DescriptionForFile { get; set; }
        public string Places { get; set; }
        public int ImageId { get; set; }
        public virtual ICollection<PageImageFile> image { get; set; }
        public int BusinessInfoId { get; set; }
        public PageInfo BusinessInfo { get; set; }
    }
}