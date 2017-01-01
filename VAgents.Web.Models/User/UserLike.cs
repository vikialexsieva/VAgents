using System.ComponentModel.DataAnnotations;

namespace VAgents.Info.Model
{
    public class UserLike
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Like { get; set; }
        public ApplicationUser User { get; set; }
    }
}
