namespace VAgents.Info.ViewModel
{

    using System.Collections.Generic;
    using VAgents.Info.ViewModels;

    public class MessageSendFromViewModels
    {
        public int Id { get; set; }
        public ICollection<UserMessageViewModels> UserMessage { get; set; }
    }
}