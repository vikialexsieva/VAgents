namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class LanguegeService : ILanguegeService
    {
        private IRepository<Languege> languege;
        public LanguegeService(IRepository<Languege> languege)
        {
            this.languege = languege;
        }

        public int Add(string Name)
        {
            var newLanguege = new Languege
            {
                Name = Name,
            };

            this.languege.Add(newLanguege);
            this.languege.SaveChanges();
            return newLanguege.Id;
        }
    }
}
