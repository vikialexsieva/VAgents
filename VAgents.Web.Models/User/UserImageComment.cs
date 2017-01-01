using System;

namespace VAgents.Info.Model
{
    public class UserImageComment
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Comment { get; set; } 
        public ApplicationUser User { get; set; }
        public int UserImageId { get; set; }
        public  virtual UserImages UserImage { set; get; }
    }
}
