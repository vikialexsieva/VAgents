namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class OneVideoCommentService : IOneVideoCommentService
    {
        private IRepository<OneVideoComment> oneVideoComment;
        public OneVideoCommentService(IRepository<OneVideoComment> oneVideoComment)
        {
            this.oneVideoComment = oneVideoComment;
        }

        public int Add(string Comment)
        {
            var newVideoComment = new OneVideoComment
            {
                Comment = Comment
            };
            this.oneVideoComment.Add(newVideoComment);
            this.oneVideoComment.SaveChanges();
            return newVideoComment.Id;
        }
    }
}
