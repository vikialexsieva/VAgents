namespace VAgents.Info.Service.User
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class UserImageService : IUserImageService
    {
        private IRepository<UserImage> userImage;
        public UserImageService(IRepository<UserImage> userImage)
        {
            this.userImage = userImage;
        }

        public int Add(string URL, string image)
        {
            var newUserImage = new UserImage
            {
                Name = URL,
                Description = image
            };

            this.userImage.Add(newUserImage);
            this.userImage.SaveChanges();
            return newUserImage.Id;
        }

        public IQueryable<UserImage> All(int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserImage> ById(string url)
        {
            throw new NotImplementedException();
        }
    }
}
