namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class UserPostCommentService : IUserPostCommentService
    {
        private IRepository<UserPostComment> userPostComment;
        public UserPostCommentService(IRepository<UserPostComment> userPostComment)
        {
            this.userPostComment = userPostComment;
        }

        public int Add(string comment)
        {
            var newPost = new UserPostComment
            {
                Comment = comment
            };

            this.userPostComment.Add(newPost);
            this.userPostComment.SaveChanges();
            return newPost.Id;

        }
    }
}
