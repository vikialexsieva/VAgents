namespace VAgents.Info.Service.Contracts.User
{
    public interface ISchoolService
    {
        int Add(string Name,
            string Spaciality,
            string YearEdition,
            string MountEdition,
            string DateEdition);
    }
}
