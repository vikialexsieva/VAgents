using System;
using System.Collections.Generic;

namespace VAgents.Info.Model
{
    public class UserMessage
    {
        private ICollection<UserMessageAnswer> userMessageAnswer;
        public UserMessage()
        {
            this.userMessageAnswer = new HashSet<UserMessageAnswer>();
        }
        public int Id { get; set; }
        public string Message { get; set; }
        public virtual ICollection<UserMessageAnswer> UserMessageAnswer {
            get
            {
                return this.userMessageAnswer;
            }
            set
            {
                this.userMessageAnswer = value;
            }

        }
        public DateTime CreationTime { get; set; }
        public virtual ApplicationUser FromUser { get; set; }
        public virtual ApplicationUser ToUser { get; set; }
    }
}
