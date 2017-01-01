namespace VAgents.Info.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DemoAllInformation
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 200 символа")]

        public string Name { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(10000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 10000 символа")]

        public string Description { get; set; }
        public int DemoId { get; set; }
        public virtual Demos Demo { get; set; }
    }
}