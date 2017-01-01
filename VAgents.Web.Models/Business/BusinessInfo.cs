namespace VAgents.Info.Model
{
    using System.Collections.Generic;

    public class BusinessInfo 
    {
        private ICollection<BusinessPriceRange> businessPriceRange;
        private ICollection<MusicCategory> musicCategory;
        private ICollection<Menus> menus;
        private ICollection<News> news;
        private ICollection<Comment> comment;
        private ICollection<BusinessImage> businessImage;
        public BusinessInfo()
        {
            this.businessImage = new HashSet<BusinessImage>();
            this.comment = new HashSet<Comment>();
            this.musicCategory = new HashSet<MusicCategory>();
            this.news = new HashSet<News>();
            this.menus = new HashSet<Menus>();
            this.businessPriceRange = new HashSet<BusinessPriceRange>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? ImageId { get; set; }
        public virtual BusinessAvatart Image { get; set; }
        public int? BusinessCategoryId { get; set; }
        public virtual BusinessCategory BusinessCategory { get; set; }
        public int AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual ICollection<Menus> Menu
        {
            get
            {
                return this.menus;
            }
            set
            {
                this.menus = value;
            }
        }

        public virtual ICollection<BusinessImage> BusinessImage {
            get
            {
                return this.businessImage;
            }
            set
            {
                this.businessImage = value;
            }
        }
        public virtual ICollection<Comment> Comment {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value; 
            }
        }
        public virtual ICollection<BusinessPriceRange> BusinessPriceRange {
            get
            {
                return this.businessPriceRange;
            }
            set
            {
                this.businessPriceRange = value; 
            }
        }
        public virtual ICollection<News> News {
            get
            {
                return this.news;
            }
            set
            {
                this.news = value;
            }
        }
        public virtual ICollection<MusicCategory> MusicCategory {
            get
            {
                return this.musicCategory;
            }
            set
            {
                this.musicCategory = value;
            }
        }

    }
}
