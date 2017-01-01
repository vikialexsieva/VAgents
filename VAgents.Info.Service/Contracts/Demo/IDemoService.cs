using System.Linq;
using VAgents.Web.Models.Demo;

namespace VAgents.Info.Service.Demo
{
    public interface IDemoService
    {
        IQueryable<Demos> All(int page = 1, int pageSize = 10);
        int Add(string name,
            string description,
            string image);
        IQueryable<Demos> ById(string name);
    }
}
