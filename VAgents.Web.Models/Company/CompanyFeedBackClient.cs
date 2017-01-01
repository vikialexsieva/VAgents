namespace VAgents.Info.Model.Company
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CompanyFeedBackClient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(20, MinimumLength =3, ErrorMessage ="Полето трябва е нежду 3 и 20 символа")]
        [Display(Name="Име")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Полето трябва е нежду 3 и 20 символа")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Полето трябва е нежду 3 и 20 символа")]
        [Display(Name = "Име на фирмата")]
        public string WorkInCompany { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Полето трябва е нежду 3 и 20 символа")]
        [Display(Name = "Позиция във фирмата")]
        public string CompanyPosition { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Полето трябва е нежду 3 и 20 символа")]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
