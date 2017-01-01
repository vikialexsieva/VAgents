namespace VAgents.Info.Model.User
{
    public class Jobs
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPosition { get; set; }
        public string StartWork { get; set; }
        public string EndWork { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}