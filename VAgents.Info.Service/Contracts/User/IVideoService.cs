namespace VAgents.Info.Service.Contracts.User
{
    public interface IVideoService
    {
        int Add(string Name, string Description, byte[] Content, string Extension);
    }
}
