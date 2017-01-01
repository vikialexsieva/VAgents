namespace VAgents.Info.Model
{
    using System;
    using System.Collections.Generic;
    
    public class Marketing
    {
        private ICollection<Point> point;
        public Marketing()
        {
            this.point = new HashSet<Point>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public int PointId { get; set; }
        public virtual ICollection<Point> Point {
            get
            {
                return this.point;
            }
            set
            {
                this.point = value;
            } }
    }
}
