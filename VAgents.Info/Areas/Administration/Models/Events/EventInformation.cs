namespace VAgents.Info.ViewModel.Events
{
    using System;
    using System.Web;

    public class EventInformationViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public string StartTime { get; set; }
        public HttpPostedFileBase Image { get; set; }
        public string UserId { get; set; }
    }
}
