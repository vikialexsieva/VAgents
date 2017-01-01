namespace VAgents.Info.Service.User
{
    using System;
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models;

    public class UserMessageService : IUserMessageService
    {
        private IRepository<UserMessage> userMessage;
        public UserMessageService(IRepository<UserMessage> userMeesage)
        {
            this.userMessage = userMessage;
        }

        public int Add(string name, bool IsAvtive = false)
        {
            var newMessge = new UserMessage
            {
                Message = name
            };
            this.userMessage.Add(newMessge);
            this.userMessage.SaveChanges();
            return newMessge.Id;
        }

        public IQueryable<UserMessage> All(int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserMessage> ById(string name)
        {
            throw new NotImplementedException();
        }
    }
}
