using System;

namespace VAgents.Info.ViewModel
{
    public class VideoCommentViewModels
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime  CreationTime { get; set; }
        public UserVideoViewModels UserVideo { get; set; }
    }
}