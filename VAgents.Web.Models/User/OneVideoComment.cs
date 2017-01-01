namespace VAgents.Info.Model.User
{
    public class OneVideoComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public ApplicationUser user { get; set; }
        public Video Video { get; set; }
    }
}