namespace VAgents.Info.Model
{
    public class Following
    {
        public int id { get; set; }
        public bool Follow { get; set; }
        public ApplicationUser UserFollow { get; set; }
        public ApplicationUser User { get; set; }
    }
}
