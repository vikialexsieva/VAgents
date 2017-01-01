namespace VAgents.Info.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class BusinessImage
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Decription")]
        [Required]
        public String Decription { get; set; }

        [Display(Name = "Image Path")]
        public String ImagePath { get; set; }

        [Display(Name = "Thumb Path")]
        public String ThumbPath { get; set; }


        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
    }
}