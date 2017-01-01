namespace VAgents.Info.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Demos
    {
        private ICollection<DemoRevue> demoRevue;
        private ICollection<DemoSample> demoSample;

        public Demos()
        {
            this.demoRevue = new HashSet<DemoRevue>();
            this.demoSample = new HashSet<DemoSample>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 20 символа")]
        public string Name { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(2000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 2000 символа")]
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreationTime { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
     
        public virtual ICollection<DemoRevue> DemoRevue
        {
            get
            {
                return this.demoRevue;
            }
            set
            {
                this.demoRevue = value;
            }
        }
        public virtual ICollection<DemoSample> DemoSample
        {
            get
            {
                return this.demoSample;
            }
            set
            {
                this.demoSample = value;
            }
        }
    }
}
