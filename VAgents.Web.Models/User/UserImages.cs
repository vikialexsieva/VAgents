namespace VAgents.Info.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UserImages
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Decription")]
        [Required]
        public string Decription { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }

        [Display(Name = "Thumb Path")]
        public string ThumbPath { get; set; }
        
        public ApplicationUser User { get; set; }

        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
    }
}
