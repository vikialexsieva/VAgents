using System.ComponentModel.DataAnnotations;

namespace VAgents.Info.Model.Solution
{
    public class SolutionCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 20 символа")]

        public string Name { get; set; }
        public int SolutionId { get; set; }
        public Solutions Solution { get; set; }
    }
}