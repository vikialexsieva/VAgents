using System;
using System.Collections.Generic;

namespace VAgents.Info.Model.User
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Content { get; set; }
        public string Extension { get; set; }
        public int OneVideoCommentId { get; set; }
        public ICollection<OneVideoComment> OneVideoComment { set; get; }
        public ApplicationUser User { get; set; }
        public DateTime CreationTime { get; set; }
    }
}