namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class VideoCommentService : IVideoCommentService
    {
        private IRepository<VideoComment> videoComment;
        public VideoCommentService(IRepository<VideoComment> videoComment)
        {
            this.videoComment = videoComment;
        }
        public int Add(string comment)
        {
            var newVideoComment = new VideoComment
            {
                Comment = comment
            };
            this.videoComment.Add(newVideoComment);
            this.videoComment.SaveChanges();
            return newVideoComment.Id;
        }
    }
}
