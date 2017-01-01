using System;
using System.Collections.Generic;
using VAgents.Info.ViewModels;

namespace VAgents.Info.ViewModel
{
    public class UserImageViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public ICollection<UserImageCommentViewModels> UserImageComment { get; set; }
        public ICollection<UserImageViewViewModels> UserImageView { get; set; }
    }
}