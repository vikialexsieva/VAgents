namespace VAgents.Info.Model.Events
{
    using System;

    public class EventSocialLink
    {
        public int Id { get; set; }
        public string SocialLinkUrl { get; set; }
        public string SocialLinkImage { get; set; }
        public int EventId { get; set; }
        public virtual EventInformation Event { get; set; }
        public DateTime CreationTime { get; set; }
    }
}