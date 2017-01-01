namespace VAgents.Info.Model.Company
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CompanyContact
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="полето е задължително")]
        [Phone]
        public string Phonenumber { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(15, ErrorMessage ="полето трябва да е между 3 и 15 символа", MinimumLength = 3)]
        public string OfficeCountry { get; set; }
        [Required(ErrorMessage ="полето е задължително")]
        public string WorkFrom { get; set; }
        [Required(ErrorMessage ="полето е задължително")]
        public string WorkTo { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
