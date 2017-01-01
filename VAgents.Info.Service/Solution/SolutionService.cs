namespace VAgents.Info.Service.Solution
{
    using System.Linq;
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.Solution;
    using VAgents.Web.Models.Solution;

    public class SolutionService : ISolutionService
    {
        private readonly IRepository<Solutions> solutions;
        public SolutionService(IRepository<Solutions> solutions)
        {
            this.solutions = solutions;
        }

        public int Add(string name, string description, string image)
        {
            var newSolutions = new Solutions
            {
                 Description = description,
                 Image = image,
                 Name = name,
            };

            this.solutions.Add(newSolutions);
            this.solutions.SaveChanges();
            return newSolutions.Id;
        }

        public IQueryable<Solutions> All(int page = 1, int pageSize = 10)
        {
            return this.solutions
                .All()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public IQueryable<Solutions> ById(string name)
        {
            var test =  this.solutions
                .All()
                .Where(s => s.Name == name);

            return test;
        }
    }
}
