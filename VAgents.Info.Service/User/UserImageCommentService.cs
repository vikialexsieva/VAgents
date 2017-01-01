namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;
    using Web.Models;

    public class UserImageCommentService : IUserImageCommentService
    {
        private IRepository<UserImageComment> userImageComment;
        public UserImageCommentService(IRepository<UserImageComment> userImageComment)
        {
            this.userImageComment = userImageComment;
        }

        public int Add(string comment)
        {
            var newUserImageComment = new UserImageComment
            {
                Comment = comment
            };
            this.userImageComment.Add(newUserImageComment);
            this.userImageComment.SaveChanges();
            return newUserImageComment.Id;
        }
    }
}
