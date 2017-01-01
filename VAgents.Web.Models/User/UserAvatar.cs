namespace VAgents.Info.Model
{
    public class UserAvatar
    {
        public int Id { get; set; }

        public byte[] Content { get; set; }

        public string FileExtension { get; set; }

        public virtual UserImages Avatar { get; set; } 
        public bool IsAvatart { get; set; }
    }
}
