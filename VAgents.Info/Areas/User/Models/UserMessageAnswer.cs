using System;

namespace VAgents.Info.ViewModels
{
    public class UserMessageAnswerViewModels
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string CreationTime { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
    }
}