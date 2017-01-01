namespace VAgents.Info.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public class ForumPost
    {
        private ICollection<ForumPostCategory> forumPostCategory;
        private ICollection<ForumPostAnswer> forumPostAnswer;
        public ForumPost()
        {
            this.forumPostCategory = new HashSet<ForumPostCategory>();
            this.forumPostAnswer = new HashSet<ForumPostAnswer>();
        }
        public int  Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 20 символа")]

        public string Title { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(2000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 2000 символа")]

        public string Description { get; set; }
        public string UserId { get; set; }
        public ApplicationUser  User { get; set; }
        public DateTime CreationTime { get; set; }
        public virtual ICollection<ForumPostCategory> ForumPostCategory
        {
            get
            {
                return this.forumPostCategory;
            } 
            set
            {
                this.forumPostCategory = value;
            }
        }
        public virtual ICollection<ForumPostAnswer> ForumPostAnswer
        {
            get
            {
                return this.forumPostAnswer;
            }

           set
            {
                this.forumPostAnswer = value;
            }
        }
    }
}
