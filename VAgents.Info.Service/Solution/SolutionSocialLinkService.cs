namespace VAgents.Info.Service.Solution
{
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.Solution;

    public class SolutionSocialLinkService : ISolutionSocialLinkService
    {
        private readonly IRepository<SolutionSocialLink> solutionSocialLink;
        public SolutionSocialLinkService(IRepository<SolutionSocialLink> solutionSocialLink)
        {
            this.solutionSocialLink = solutionSocialLink;
        }

        public int Add(string image, string Url)
        {
            var newSolutionSocialLink = new SolutionSocialLink
            {
                 Image = image,
                 URL = Url
            };

            this.solutionSocialLink.Add(newSolutionSocialLink);
            this.solutionSocialLink.SaveChanges();
            return newSolutionSocialLink.Id;
        }

        public IQueryable<SolutionSocialLink> All(int page = 1, int pageSize = 10)
        {
            return this.solutionSocialLink
                .All()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<SolutionSocialLink> ById(string url)
        {
            return this.solutionSocialLink
                .All()
                .Where(solSocLink => solSocLink.URL == url);
        }
    }
}
