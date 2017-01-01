namespace VAgents.Info.Areas.Administration.Controllers
{
    using System;
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using VAgents.Info.Controllers;
    using VAgents.Info.Model.Events;
    using VAgents.Info.ViewModel.Events;
    using System.IO;
    using System.Linq;

    public class EventController : BaseController
    {
        public EventController(ITicketSystemData data) : base(data)
        {
        }



        // GET: Administration/Event
        public ActionResult Index()
        {
            var listAllEvent = this.Data.EvetnInformations.All()
                .Select(x => new EventInformationViewModel
                {
                     CreationTime = x.CreationTime,
                     Description = x.Description,
                     Name = x.Name,
                     StartTime = x.StartTime,
                     
                });
            return View(listAllEvent);
        }

        // GET: Administration/Event/Details/5
        public ActionResult Details(string name)
        {
            var getDetailsInformation = this.Data.EvetnInformations.All()
                .Where(x => x.Name == name)
                .Select(x => new EventInformationViewModel
                {
                    CreationTime = x.CreationTime,
                    Name = x.Name,
                    Description = x.Description,
                    StartTime = x.StartTime,
                    
                });

            return View(getDetailsInformation);
        }

        // GET: Administration/Event/Create
        
        public ActionResult Post()
        {
            return View();
        }

        // POST: Administration/Event/Create
        [HttpPost]
        public ActionResult Post(EventInformationViewModel EventInfo)
        {
            var newEventInformation = new EventInformation
            {
                Description = EventInfo.Description,
                Name = EventInfo.Name,
                StartTime = EventInfo.StartTime,
                CreationTime = DateTime.Now,
            };
            if (EventInfo.Image != null)
            {
                using (var memory = new MemoryStream())
                {
                    EventInfo.Image.InputStream.CopyTo(memory);
                    var content = memory.GetBuffer();

                    newEventInformation.Image = new EventImage
                    {
                        Content = content,
                        Extension = EventInfo.Image.FileName.Split(new[] { '.' }).Last()
                    };
                }
            }
            this.Data.EvetnInformations.Add(newEventInformation);
            this.Data.EvetnInformations.SaveChanges();

            return Redirect("/");
        }

        // GET: Administration/Event/Edit/5
        public ActionResult Edit(int id)
        {
            return this.View();
        }

        // POST: Administration/Event/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var updateEvent = this.Data.EvetnInformations.All().FirstOrDefault();

            this.Data.EvetnInformations.Update(updateEvent);
            this.Data.EvetnInformations.SaveChanges();

            return Redirect("/");
        }

        // GET: Administration/Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administration/Event/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var deleteEvent = this.Data.EvetnInformations.All().FirstOrDefault();

            this.Data.EvetnInformations.Delete(deleteEvent);
            this.Data.EvetnInformations.SaveChanges();

            return Redirect("/");
        }
        
        [HttpGet]
        public ActionResult NewSocialLink()
        {
            return this.View();
        }
        [HttpPost]
        public ActionResult AddNewSocialLink(EventSocialLink eventSocLink)
        {

            var createNewSocialLink = new EventSocialLink
            {
                CreationTime = DateTime.Now,
                SocialLinkUrl = eventSocLink.SocialLinkUrl,

            };

            this.Data.EventSocialLink.Add(createNewSocialLink);
            this.Data.EventSocialLink.SaveChanges();

            return this.Redirect("/");
        }

        public ActionResult UpdateNewSocialLink(int id)
        {
            return this.View();
        }

        public ActionResult AddUpdateSocialLink()
        {
            var updateEvent = this.Data.EventSocialLink.All().FirstOrDefault();

            this.Data.EventSocialLink.Update(updateEvent);
            this.Data.SaveChanges();
            return this.Redirect("/");
        }

        public ActionResult DeleteEventSocialLink()
        {
            var deleteEvent = this.Data.EventSocialLink.All().FirstOrDefault();
            this.Data.EventSocialLink.Delete(deleteEvent);
            this.Data.EventSocialLink.SaveChanges();

            return this.Redirect("/");
        }
    }
}
