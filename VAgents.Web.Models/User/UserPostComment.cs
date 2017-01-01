using System;

namespace VAgents.Info.Model.User
{
    public class UserPostComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime CreationTime{ get; set; }
        public UserPost UserPost { get; set; }
        public ApplicationUser User { get; set; }
    }
}