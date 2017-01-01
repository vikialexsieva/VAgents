namespace VAgents.Info.Model
{
    using System;
    using System.Collections.Generic;

    public class Post
    {
        private ICollection<ApplicationUser> user;
        private ICollection<BusinessInfo> business;
        public Post()
        {
            this.user = new HashSet<ApplicationUser>();
            this.business = new HashSet<BusinessInfo>();
        }
        public int Id { get; set; }
        public string Content { get; set; }
        public virtual ICollection<ApplicationUser> User {
            get
            {
                return this.user;
            }
            set
            {
                this.user = value;
            }
        }
        public virtual ICollection<BusinessInfo> Business {
            get
            {
                return this.business;
            }
            set
            {
                this.business = value;  
            }
        }
        public DateTime CreationTime { get; set; }
    }
}
