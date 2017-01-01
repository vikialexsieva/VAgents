namespace VAgents.Info.Model.User
{
    public class Family
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int SecondUserId { get; set; }
        public ApplicationUser SecondUser { get; set; }
        public string FamilyRole { get; set; }
    }
}