using System.Linq;
using VAgents.Web.Models.Demo;

namespace VAgents.Info.Service.Contracts.Demo
{
    public interface IDemoInformationAllService
    {
        IQueryable<DemoAllInformation> All(int page = 1, int pageSize = 10);
        int Add(string name, string Description);
        IQueryable<DemoAllInformation> ById(string name);
    }
}
