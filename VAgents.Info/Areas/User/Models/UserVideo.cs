using System;
using System.Collections;
using System.Collections.Generic;

namespace VAgents.Info.ViewModel
{
    public class UserVideoViewModels
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public ICollection<VideoViewModels> Video { get; set; }
        public int CommentId { get; set; }
        public ICollection<VideoCommentViewModels> VideoComment { get; set; }
    }
}