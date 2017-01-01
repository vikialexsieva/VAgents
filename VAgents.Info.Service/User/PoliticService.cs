namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class PoliticService : IPoliticService
    {
        private IRepository<Politic> politic;
        public PoliticService(IRepository<Politic> politic) 
        {
            this.politic = politic;
        }

        public int Add(string Name, string Description)
        {
            var newPolitic = new Politic
            {
                Name = Name,
                Description= Description,
            };

            this.politic.Add(newPolitic);
            this.politic.SaveChanges();
            return newPolitic.Id;
        }
    }
}
