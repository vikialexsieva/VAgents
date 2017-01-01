using System.Linq;
using VAgents.Web.Models.Demo;

namespace VAgents.Info.Service.Contracts.Demo
{
    public interface IDemoRevueService
    {
        IQueryable<DemoRevue> All(int page = 1, int pageSize = 10);
        int Add(string name, string description);
        IQueryable<DemoRevue> ById(int id);
    }
}
