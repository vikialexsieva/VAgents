namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class NowLifeCityService : INowLifeCityService
    {
        private IRepository<NowLifeCity> nowLifeCity;
        public NowLifeCityService(IRepository<NowLifeCity> nowLifeCity)
        {
            nowLifeCity = nowLifeCity;
        }

        public int Add(string Cit, string Country)
        {
            var newLifeCity = new NowLifeCity
            {
                City= Cit,
                Country = Country,
            };

            this.nowLifeCity.Add(newLifeCity);
            this.nowLifeCity.SaveChanges();
            return newLifeCity.Id;
        }
    }
}
