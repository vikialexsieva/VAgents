namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class FamilyService : IFamilyService
    {
        private IRepository<Family> family;
        public FamilyService(IRepository<Family> family)
        {
            this.family = family;
        }

        public int Add(string FamilyRole)
        {
            var newFamily = new Family
            {
                FamilyRole = FamilyRole
            };

            this.family.Add(newFamily);
            this.family.SaveChanges();
            return newFamily.Id;
        }
    }
}
