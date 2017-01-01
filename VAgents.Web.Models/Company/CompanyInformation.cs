namespace VAgents.Info.Model.Company
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CompanyInformation
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="полето е заддължително")]
        
        public string Name { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
