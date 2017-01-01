namespace VAgents.Info.Service.User
{
    using System;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;

    public class UserImageViewService : IUserImageViewService
    {
        private IRepository<UserImageView> userImageView;

        public int Add(string Name, string Description, byte[] Content, string Extension)
        {
            throw new NotImplementedException();
        }
    }
}
