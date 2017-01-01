namespace VAgents.Info.Model.Page
{
    using Page;

    public class PageImageFile
    {
        public int Id { get; set; }
        public byte[] Content { get; set; }
        public string FileExtension { get; set; }
        public int businessImageId { get; set; }
        public PageImage businessImage { get; set; }
    }
}
