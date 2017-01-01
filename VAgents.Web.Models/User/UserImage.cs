using System;
using System.Collections.Generic;

namespace VAgents.Info.Model.User
{
    public class UserImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public ICollection<UserImageComment> UserImageComment { get; set; }
        public ICollection<UserImageView> UserImageView { get; set; }
    }
}