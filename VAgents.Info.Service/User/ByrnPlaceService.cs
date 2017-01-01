namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.User;
    using VAgents.Web.Models.User;

    public class ByrnPlaceService : IByrnPlaceService
    {
        private IRepository<ByrnPlace> byrnPlace;
        public ByrnPlaceService(IRepository<ByrnPlace> byrnPlace)
        {
            byrnPlace = byrnPlace;
        }
        public int Add(string Country, string City, string PostCode)
        {
            var newByrnPlace = new ByrnPlace
            {
                Country = Country,
                City = City,
                PostCode = PostCode,
            };
            this.byrnPlace.Add(newByrnPlace);
            this.byrnPlace.SaveChanges();
            return newByrnPlace.Id;
        }
    }
}
