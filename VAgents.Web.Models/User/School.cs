namespace VAgents.Info.Model.User
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Spaciality { get; set; }
        public string YearEdition { get; set; }
        public string MountEdition { get; set; }
        public string DateEdition { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}