namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models;

    public class UserMessageAnswerService : IUserMessageAnswerService
    {
        private IRepository<UserMessageAnswer> messageAnswer;
        public UserMessageAnswerService(IRepository<UserMessageAnswer> messageAnswer)
        {
            this.messageAnswer = messageAnswer;
        }

        public int Add(string Answer)
        {
            var newAnswer = new UserMessageAnswer
            {   
                Answer = Answer
            };
            this.messageAnswer.Add(newAnswer);
            this.messageAnswer.SaveChanges();
            return newAnswer.Id;
        }
    }
}
