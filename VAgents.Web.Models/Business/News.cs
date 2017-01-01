using System;
using System.Collections.Generic;

namespace VAgents.Info.Model
{
    public class News
    {
        private ICollection<NewsCategory> newsCategory;
        public News()
        {
            this.newsCategory = new HashSet<NewsCategory>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BusinessId { get; set; }
        public virtual BusinessInfo Business { get; set; }
        public DateTime CreationTime { get; set; }
        public virtual ICollection<NewsCategory> NewsCategory { get; set; } 
    }
}