namespace VAgents.Info.Model.Company
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CompanyFeedBackCompany
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="полето е задлжително")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Полето трябва да е между 3 и 50 символа")]
        [Display(Name = "Име на компанията")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage ="Полето е задължително")]
        [StringLength(400, MinimumLength = 10, ErrorMessage = "Полето трябва да е между 10 и 400 символа")]
        [Display(Name = "Мнение")]
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public int CompanyLogoId { get; set; }
        public virtual CompanyLogo CompanyLogo { get; set; }
    }
}
