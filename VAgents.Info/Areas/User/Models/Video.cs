using System;
using System.Collections.Generic;

namespace VAgents.Info.ViewModel
{
    public class VideoViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Content { get; set; }
        public string Extension { get; set; }
        public int OneVideoCommentId { get; set; }
        public ICollection<OneVideoCommentViewModels> OneVideoComment { set; get; }
        public DateTime CreationTime { get; set; }
    }
}