using System;
using System.Collections.Generic;

namespace VAgents.Info.ViewModel
{
    public class UserPostViewModels
    {
        public int Id { get; set; }
        public string Post { get; set; }
        public DateTime CreationTime { get; set; }
        public int UserPostCommentId { get; set; }
        public virtual ICollection<UserPostCommentViewModels> UserPostComment { get; set; }
    }
}