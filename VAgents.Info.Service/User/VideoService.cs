namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class VideoService : IVideoService
    {
        private IRepository<Video> video;
        public VideoService(IRepository<Video> video)
        {
            this.video = video;
        }
        public int Add(string Name, string Description, byte[] Content, string Extension)
        {
            var newVideo = new Video
            {
                Content = Content,
                Name = Name,
                Description = Description,
                Extension = Extension,
            };
            this.video.Add(newVideo);
            this.video.SaveChanges();
            return newVideo.Id;
        }
    }
}
