namespace VAgents.Info.ViewModel.Forums
{   
    using System;

    public class ForumPostViewModel
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
