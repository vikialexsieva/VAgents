namespace VAgents.Info.Model
{
    using System;

    public class Point
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public int Points { get; set; }
        public virtual Marketing Marketing { get; set; }
    }
}