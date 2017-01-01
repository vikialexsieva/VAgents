using System.Collections.Generic;

namespace VAgents.Info.ViewModel
{
    public class UserImageViewViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Content { get; set; }
        public string  Extension { get; set; }
        public ICollection<UserImageViewCommentViewModels> UserImageViewComment { get; set; }
    }
}