namespace VAgents.Info.Service.Event
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Events;
    using VAgents.Web.Models;
    using VAgents.Web.Models.Events;

    public class EventSocialLinkService : IEventSocialLinkService
    {
        private readonly IRepository<EventSocialLink> eventSocialLink;
        private readonly IRepository<ApplicationUser> user;
        public EventSocialLinkService(IRepository<EventSocialLink> eventSocialLink,
            IRepository<ApplicationUser> user)
        {
            this.user = user;
            this.eventSocialLink = eventSocialLink;
        }

        public int Add(string socialLinkUrl, string socialLinkImage)
        {
            var newEventSocialLink = new EventSocialLink
            {
                SocialLinkUrl =  socialLinkUrl,
                SocialLinkImage = socialLinkImage,
                CreationTime = DateTime.Now,
            };
            this.eventSocialLink.Add(newEventSocialLink);
            this.eventSocialLink.SaveChanges();
            return newEventSocialLink.Id;
        }

        public IQueryable<EventSocialLink> All(int page = 1, int pageSize = 10)
        {
            return this.eventSocialLink
                .All()
                .OrderByDescending(evSocLin => evSocLin.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<EventSocialLink> ById(string socialLinkUrl)
        {
            return this.eventSocialLink
                .All()
                .Where(evSocLink => evSocLink.SocialLinkUrl == socialLinkUrl);
        }
    }
}
