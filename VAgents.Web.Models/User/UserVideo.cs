using System;
using System.Collections.Generic;

namespace VAgents.Info.Model.User
{
    public class UserVideo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Video> Video { get; set; }
        public int CommentId { get; set; }
        public ICollection<VideoComment> VideoComment { get; set; }
    }
}