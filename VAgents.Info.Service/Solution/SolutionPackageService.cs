namespace VAgents.Info.Service.Release
{
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.Solution;

    public class SolutionPackageService : ISolutionPackageService
    {
        private readonly IRepository<SolutionPackage> solutionPackage;
        public SolutionPackageService(IRepository<SolutionPackage> solutionPackage)
        {
            this.solutionPackage = solutionPackage;
        }

        public int Add(string name, string price, string count)
        {
            var newSolutionPackage = new SolutionPackage
            {
                Name = name,
                Price = price,
                Count = count
            };
            this.solutionPackage.Add(newSolutionPackage);
            this.solutionPackage.SaveChanges();
            return newSolutionPackage.Id;
        }

        public IQueryable<SolutionPackage> All(int page = 1, int pageSize = 10)
        {
            return this.solutionPackage
                .All()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<SolutionPackage> ById(string prace)
        {
            return this.solutionPackage
                .All()
                .Where(SolPack => SolPack.Price == prace);
        }
    }
}
