namespace VAgents.Info.Model.Groups
{
    public class GroupImageFile
    {
        public  int Id { get; set; }
        public byte[] Content { get; set;}
        public string FileExtension { get; set; }
        public int businessImageId { get; set; }
        public virtual GroupImage businessImage { get; set; }
    }
}