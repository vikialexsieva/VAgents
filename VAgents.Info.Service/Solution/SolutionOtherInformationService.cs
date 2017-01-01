namespace VAgents.Info.Service.Solution
{
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.Solution;

    public class SolutionOtherInformationService : ISolutionOtherInformationService
    {
        private readonly IRepository<SolutionOtherInformation> solutionOtherInformation;
        public SolutionOtherInformationService(IRepository<SolutionOtherInformation> solutionOtherInformation)
        {
            this.solutionOtherInformation = solutionOtherInformation;
        }

        public int Add(string name, string description)
        {
            var newSolutionOtherInformation = new SolutionOtherInformation
            {
                Name = name,
                Description = description,
            };
            this.solutionOtherInformation.Add(newSolutionOtherInformation);
            this.solutionOtherInformation.SaveChanges();
            return newSolutionOtherInformation.Id;
        }

        public IQueryable<SolutionOtherInformation> All(int page = 1, int pageSize = 10)
        {
            return this.solutionOtherInformation
                .All()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<SolutionOtherInformation> ById(string name)
        {
            return this.solutionOtherInformation
                .All()
                .Where(solInfo => solInfo.Name == name);
        }
    }
}
