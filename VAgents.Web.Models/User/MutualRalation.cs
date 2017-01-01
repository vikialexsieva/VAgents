namespace VAgents.Info.Model.User
{
    public class MutualRalation
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public ApplicationUser SecondUser { get; set; }
        public Ralation relation { get; set; }
    }
}