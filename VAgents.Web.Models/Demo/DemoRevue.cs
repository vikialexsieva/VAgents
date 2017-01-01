namespace VAgents.Info.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DemoRevue
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 20 символа")]

        public string Name { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(20000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 20000 символа")]

        public string Description { get; set; }
        public virtual string DemoId { get; set; }
        public virtual Demos Demmo { get; set; }
        public DateTime CreationTime { get; set; }
    }
}