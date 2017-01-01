using System.ComponentModel.DataAnnotations;

namespace VAgents.Info.Model.Solution
{
    public class SolutionOtherInformation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 200 символа")]

        public string Name { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(2000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 2000 символа")]

        public string Description { get; set; }
        public int SolutionId { get; set; }
        public Solutions Solution { get; set; }
    }
}