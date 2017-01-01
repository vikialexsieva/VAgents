namespace VAgents.Info.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DemoSample
    {
        public int  Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 200 символа")]

        public string Name { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(20000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 20000 символа")]

        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public string DemoId { get; set; }
        public virtual Demos Demo { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}