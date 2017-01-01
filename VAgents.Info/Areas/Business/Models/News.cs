using System;
using System.Collections.Generic;

namespace VAgents.Info.ModelViewModels
{
    public class NewsViewModels
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public virtual NewsCategoryViewModels NewsCategory { get; set; } 
    }
}