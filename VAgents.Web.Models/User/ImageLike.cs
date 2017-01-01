namespace VAgents.Info.Model.User
{
    public class ImageLike
    {
        public int Id { get; set; }
        public bool Like { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual UserImages userImage { get; set; }
    }
}
