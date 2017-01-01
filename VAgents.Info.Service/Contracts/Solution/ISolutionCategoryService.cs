namespace VAgents.Info.Service.Contracts.Solution
{
    public interface IUserAllInfoService
    {
        int Add(string UserPhone, string UserUrl, string DateOfByrt, string YearOfByrt, string MountOfByr, string About, string OtherNames, string OtherInfo);
    }
}
