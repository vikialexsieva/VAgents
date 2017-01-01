namespace VAgents.Info.Model
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class ApplicationUser : IdentityUser
    {
        private ICollection<BusinessInfo> business;
        private ICollection<UserMessage> userMessage;
        private ICollection<UserImages> userImage;
        private ICollection<UserLike> userLeke;
        private ICollection<Followr> Foolewr;
        private ICollection<Following> following;
        private ICollection<UserLikeImage> userLikeImage;
        public ApplicationUser()
        {
            this.userLikeImage = new HashSet<UserLikeImage>();
            this.business = new HashSet<BusinessInfo>();
            this.userMessage = new HashSet<UserMessage>();
            this.userImage = new HashSet<UserImages>();
            this.userLeke = new HashSet<UserLike>();
            this.Foolewr = new HashSet<Followr>();
            this.following = new HashSet<Following>();
        }

        public int DateOfByrth { get; set; }

        public int MuntOfByrth { get; set; }

        public int YearOfByrth { get; set; }

        public string FirsName { get; set; }

        public string LastName { get; set; }

        public string Cuntry { get; set; }

        public string City { get; set; }


        public virtual ICollection<UserLikeImage> UserLikeImage
        {
            get
            {
                return this.userLikeImage;
            }
            set
            {
                this.userLikeImage = value;
            }
        }

        public virtual ICollection<UserMessage> UserMessage
        {
            get
            {
                return this.userMessage;
            }

            set
            {
                this.userMessage = value;
            }
        }

        public virtual ICollection<UserLike> UserLike
        {
            get
            {
                return this.userLeke;
            }
            set
            {
                this.userLeke = value;
            }
        }

        public virtual ICollection<Following> Following
        {
            get
            {
                return this.following;
            }
            set
            {
                this.following = value;
            }
        }

        public virtual ICollection<Followr> Followr
        {
            get
            {
                return this.Foolewr;
            }
            set
            {
                this.Foolewr = value;
            }
        }

        public virtual ICollection<BusinessInfo> Business
        {
            get
            {
                return this.business;
            }
            set
            {
                this.business = value;
            }
        }
        
        public int UserImagesId { get; set; }
        public virtual  ICollection<UserImages> UserImages
        {
            get
            {
                return this.userImage;
            }
            set
            {
                this.userImage = value;
            }
        }
        
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
