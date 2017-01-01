namespace VAgents.Info.Service.User
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class UserVideoService : IUserVideoService
    {
        private IRepository<UserVideo> userVideo;
        public UserVideoService(IRepository<UserVideo> userVideo)
        {
            this.userVideo = userVideo;
        }

        public int Add(string image, string url)
        {
            var newVideo = new UserVideo
            {
                Description = url,
                Name = image,
            };

            this.userVideo.Add(newVideo);
            this.userVideo.SaveChanges();
            return newVideo.Id;
        }

        public IQueryable<UserVideo> All(int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserVideo> ById(string url)
        {
            throw new NotImplementedException();
        }
    }
}
