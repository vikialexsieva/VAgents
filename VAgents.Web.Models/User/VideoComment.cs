using System;

namespace VAgents.Info.Model.User
{
    public class VideoComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime  CreationTime { get; set; }
        public ApplicationUser User { get; set; }
        public UserVideo UserVideo { get; set; }
    }
}