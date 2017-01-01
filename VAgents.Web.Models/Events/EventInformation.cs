namespace VAgents.Info.Model.Events
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class EventInformation
    {
        private ICollection<EventSocialLink> eventSocialLink;
        public EventInformation()
        {
            this.eventSocialLink = new HashSet<EventSocialLink>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 200 символа")]

        public string Name { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(20000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 20000 символа")]

        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public string StartTime { get; set; }
        public int? ImageId { get; set; }
        public virtual EventImage Image { get; set; }
        public virtual ICollection<EventSocialLink> EventSocialLink
        {
            get
            {
                return this.eventSocialLink;
            }

            set
            {
                this.eventSocialLink = value;
            }
        }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
