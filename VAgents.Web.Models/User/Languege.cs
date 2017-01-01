namespace VAgents.Info.Model.User
{
    public class Languege
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}