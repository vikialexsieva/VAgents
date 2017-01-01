namespace VAgents.Info.Service.Solution
{

    ////public class SolutionCategoryService : ISolutionCategoryService
    ////{
    ////    private readonly IRepository<SolutionCategory> solutionCategory;
    ////    public SolutionCategoryService(IRepository<SolutionCategory> solutionCategory)
    ////    {
    ////        this.solutionCategory = solutionCategory;
    ////    }
    ////    public int Add(string name)
    ////    {
    ////        var newSolutionCategory = new SolutionCategory
    ////        {
    ////            Name = name
    ////        };
    ////        this.solutionCategory.Add(newSolutionCategory);
    ////        this.solutionCategory.SaveChanges();
    ////        return newSolutionCategory.Id;
    ////    }

    ////    public IQueryable<SolutionCategory> All(int page = 1, int pageSIze = 10)
    ////    {
    ////        return this.solutionCategory
    ////            .All()
    ////            .Skip((page - 1) * pageSIze)
    ////            .Take(pageSIze);
    ////    }

    ////    public IQueryable<SolutionCategory> ById(string name)
    ////    {
    ////        return this.solutionCategory
    ////            .All()
    ////            .Where(SolCat => SolCat.Name == name);
    ////    }
    ////}

}
