namespace VAgents.Info.Model.Groups
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class GroupsInfo
    {
        private ICollection<GroupImage> groupImage;
        private ICollection<GroupAllInfo> groupAllinfo;
        private ICollection<UserMessage> userMassage;
        public GroupsInfo()
        {
            this.userMassage = new HashSet<UserMessage>();
            this.groupImage = new HashSet<GroupImage>();
            this.groupAllinfo = new HashSet<GroupAllInfo>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 200 символа")]
        public string Name { get; set; }

        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(2000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 2000 символа")]
        public string Description { get; set; }

        public virtual ICollection<UserMessage> UserMessage
        {
            get
            {
                return this.userMassage;
            }
            set
            {
                this.userMassage = value;
            }
        }
        public string Image { get; set; }
        public virtual ICollection<GroupImage> GroupImage
        {
            get
            {
                return this.groupImage;
            }
            set
            {
                this.groupImage = value;
            }
        }
        public virtual ICollection<GroupAllInfo> GroupAllInfo
        {
            get
            {
                return this.groupAllinfo;
            }
            set
            {
                this.groupAllinfo = value;
            }
        }    }
}
