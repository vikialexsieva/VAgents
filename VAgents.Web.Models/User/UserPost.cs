using System;
using System.Collections.Generic;

namespace VAgents.Info.Model.User
{
    public class UserPost
    {
        public int Id { get; set; }
        public string Post { get; set; }
        public DateTime CreationTime { get; set; }
        public ApplicationUser User { get; set; }
        public int UserPostCommentId { get; set; }
        public virtual ICollection<UserPostComment> UserPostComment { get; set; }
    }
}