namespace VAgents.Info.Service.Event
{
    using Contracts.Events;
    using System;
    using System.IO;
    using System.Linq;
    using Vagents.Info.Data;
    using Web.Models;
    using Web.Models.Events;

    public class EventInformationService : IEventInformationService
    {
        private readonly IRepository<EventInformation> eventInformation;
        private readonly IRepository<ApplicationUser> user; 
        public EventInformationService(IRepository<EventInformation> eventInformation, IRepository<ApplicationUser> user)
        {
            this.eventInformation = eventInformation;
            this.user = user;
        }
        public int Add(string name,
            string description, string startTime, string image)
        {
            var newEventInformation = new EventInformation
            {
                Description = description,
                Name = name,
                StartTime = startTime,
                CreationTime = DateTime.Now,
            };
            if (image != null)
            {
                
            }
            this.eventInformation.Add(newEventInformation);
            this.eventInformation.SaveChanges();
            return newEventInformation.Id;
        }

        public IQueryable<EventInformation> All(int page = 1, int pageSize = 10)
        {
            return this.eventInformation
                .All()
                .OrderByDescending(evInfo => evInfo.CreationTime)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);    
        }

        public IQueryable<EventInformation> ById(string name)
        {
            return this.eventInformation
                .All()
                .Where(evInfo => evInfo.Name == name);
        }
    }
}
