namespace VAgents.Info.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ForumPostCategory
    {
        private ICollection<ForumPostSubCategory> forumPostSubCategory;
        public ForumPostCategory()
        {
            this.forumPostSubCategory = new HashSet<ForumPostSubCategory>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 200 символа")]

        public string Name { get; set; }
        public virtual ForumPost ForumPost { get; set; }
        public int ForumPostSubCategoryId { get; set; }
        public virtual ICollection<ForumPostSubCategory> ForumPostSubCategory
        {
            get
            {
                return this.forumPostSubCategory;
            }
            set
            {
                this.forumPostSubCategory = value;
            }
        }
    }
}