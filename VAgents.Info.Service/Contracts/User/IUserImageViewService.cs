namespace VAgents.Info.Service.Contracts.User
{
    public interface IUserImageViewService
    {
        int Add(string Name, string Description, byte[] Content, string Extension);
    }
}
