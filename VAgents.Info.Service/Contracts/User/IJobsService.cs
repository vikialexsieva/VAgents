namespace VAgents.Info.Service.Contracts.User
{
    public interface IJobsService
    {
        int Add(string CompanyName, string CompanyPosit, string StartWork, string EndWork);
    }
}
