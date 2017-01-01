namespace VAgents.Info.Model.Products
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}
