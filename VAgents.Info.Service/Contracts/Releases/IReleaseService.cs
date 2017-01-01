using System.Linq;
using VAgents.Web.Models.Releases;

namespace VAgents.Info.Service.Contracts.Releases
{
    public interface IReleaseService
    {
        IQueryable<ReleaseHistory> All(int page = 1, int pageSIze = 10);
        int Add(string name, string description, string  image);
        IQueryable<ReleaseHistory> ById(string id);
    }
}
