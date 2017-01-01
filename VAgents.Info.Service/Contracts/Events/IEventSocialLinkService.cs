using System.Linq;
using VAgents.Web.Models.Events;

namespace VAgents.Info.Service.Contracts.Events
{
    public interface IEventSocialLinkService
    {
        IQueryable<EventSocialLink> All(int page = 1, int pageSize = 10);
        int Add(string socialLinkUrl, string socialLinkImage);
        IQueryable<EventSocialLink> ById(string socialLinkUrl);
    }
}
