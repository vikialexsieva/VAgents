namespace VAgents.Info.Model.Page
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class PageInfo
    {
        private ICollection<PageImage> pageImage;
        private ICollection<PageAllInfo> pageAllinfo;
        private ICollection<UserMessage> userMessage;
        public PageInfo()
        {
            this.userMessage = new HashSet<UserMessage>();
            this.pageImage = new HashSet<PageImage>();
            this.pageAllinfo = new HashSet<PageAllInfo>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 200 символа")]
        public string Name { get; set; }

        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(2000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 2000 символа")]
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual ICollection<PageImage> GroupImage
        {
            get
            {
                return this.pageImage;
            }
            set
            {
                this.pageImage = value;
            }
        }
        public virtual ICollection<PageAllInfo> GroupAllInfo
        {
            get
            {
                return this.pageAllinfo;
            }
            set
            {
                this.pageAllinfo = value;
            }
        }    }
}
