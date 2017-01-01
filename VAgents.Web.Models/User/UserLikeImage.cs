namespace VAgents.Info.Model
{
    public class UserLikeImage
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public int UserImageId { get; set; }
        public virtual UserImages UserImage { get; set; }
    }
}