namespace VAgents.Info.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
   
    public class Policy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        
        
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        public string Description { get; set; }
    }
}
