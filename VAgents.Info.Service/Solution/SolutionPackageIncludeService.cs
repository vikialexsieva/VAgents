namespace VAgents.Info.Service.Solution
{
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.Solution;

    public class SolutionPackageIncludeService : ISolutionPackageIncludeService
    {
        private readonly IRepository<SolutionPackegeInclude> solutionPackageInclude;
        public SolutionPackageIncludeService(IRepository<SolutionPackegeInclude> solutionPackageInclude)
        {
            this.solutionPackageInclude = solutionPackageInclude;
        }

        public int Add(string name, bool IsAvtive = false)
        {
            var newSolutionPackageInclude = new SolutionPackegeInclude
            {
                Name = name,
                IsActive = IsAvtive
            };
            this.solutionPackageInclude.Add(newSolutionPackageInclude);
            this.solutionPackageInclude.SaveChanges();
            return newSolutionPackageInclude.Id;
        }

        public IQueryable<SolutionPackegeInclude> All(int page = 1, int pageSize = 10)
        {
            return this.solutionPackageInclude
                .All()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<SolutionPackegeInclude> ById(string name)
        {
            return this.solutionPackageInclude
                .All()
                .Where(solPackIncluder => solPackIncluder.Name == name);
        }
    }
}
