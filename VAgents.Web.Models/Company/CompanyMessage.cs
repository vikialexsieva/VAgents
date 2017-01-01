namespace VAgents.Info.Model.Company
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CompanyMessage
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "полето трябва да е между 4  и 15 символа")]
        public string Title { get; set; }
        [Required(ErrorMessage ="полето е задължително")]
        [StringLength(1000, MinimumLength = 20, ErrorMessage ="полето трябва да е между 20 и 100 символа")]
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }

        [Required(ErrorMessage ="полето е задължително")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="полето е задължително")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="полето  трябва да е между 3 и 20 символа")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 20 символа")]

        public string LastName { get; set; }
    }
}
