namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class OtherContactService : IOtherContactService
    {
        private IRepository<OtherContact> otherContact;
        public OtherContactService(IRepository<OtherContact> otherContact)
        {
            this.otherContact = otherContact;
        }

        public int Add(string Links, string FateDay)
        {
            var newOtherContact = new OtherContact
            {
                FateDay = FateDay,
                Links = Links
            };
            this.otherContact.Add(newOtherContact);
            this.otherContact.SaveChanges();

            return newOtherContact.Id;
        }
    }
}
