namespace VAgents.Info.Model
{
    using System.ComponentModel.DataAnnotations;

    public class BusinessAvatart
    {
        [Key]
        public int Id { get; set; }

        public byte[] Content { get; set; }

        public string FileExtension { get; set; }
    }
}
