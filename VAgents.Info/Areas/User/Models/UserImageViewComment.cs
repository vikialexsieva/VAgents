using System;

namespace VAgents.Info.ViewModel
{
    public class UserImageViewCommentViewModels
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public UserImageViewViewModels UserImageView { get; set; }
    }
}