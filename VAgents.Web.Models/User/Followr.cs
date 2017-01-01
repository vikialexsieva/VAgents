namespace VAgents.Info.Model
{
    public class Followr
    {
        public int Id { get; set; }
        public bool Follow { get; set; }
        public ApplicationUser FollowUser { get; set; }
        public ApplicationUser FollowingUser { get; set; }
    }
}
