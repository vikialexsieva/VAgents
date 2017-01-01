namespace VAgents.Info.Model
{
    
    public class ForumPostVote
    {
        public int Id { get; set; }
        public bool IsVote { get; set; }
        public ApplicationUser User { get; set; }
        public ForumPost ForumPost { get; set; }
    }
}
