namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class JobsService : IJobsService
    {
        private IRepository<Jobs> jobs;
        public JobsService(IRepository<Jobs> jobs)
        {
            this.jobs = jobs;
        }
        public int Add(string CompanyName, string CompanyPosit, string StartWork, string EndWork)
        {
            var newJobs = new Jobs
            {
                CompanyName = CompanyName,
                CompanyPosition = CompanyPosit,
                StartWork = StartWork,
                EndWork = EndWork
            };

            this.jobs.Add(newJobs);
            this.jobs.SaveChanges();
            return newJobs.Id;
        }
    }
}
