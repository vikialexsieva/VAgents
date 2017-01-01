using System.Linq;
using VAgents.Web.Models.Events;

namespace VAgents.Info.Service.Contracts.Events
{
    public interface IEventInformationService
    {
        IQueryable<EventInformation> All(int page=1, int pageSize=10);
        int Add(string name, string description, string startTime, string image);
        IQueryable<EventInformation> ById(string name);
    }
}
