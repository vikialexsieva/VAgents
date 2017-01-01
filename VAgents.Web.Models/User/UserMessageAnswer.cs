using System;

namespace VAgents.Info.Model
{
    public class UserMessageAnswer
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public DateTime CreationTime { get; set; }
        public virtual UserMessage UserMessage { get; set; }
        public virtual ApplicationUser FromUser { get; set; }
        public virtual ApplicationUser ToUser { get; set; }

    }
}