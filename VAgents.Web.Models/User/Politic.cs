using System;

namespace VAgents.Info.Model
{
    public class Politic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime CreationTime { get; set; }
    }
}