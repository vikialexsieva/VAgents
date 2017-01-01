namespace VAgents.Info.Service.User
{
    using Vagents.Info.Data;
    using VAgents.Info.Service.Contracts.User;
    using VAgents.Web.Models.User;

    public class SchoolService : ISchoolService
    {
        private IRepository<School> school;
        public SchoolService(IRepository<School> school)
        {
            this.school = school;
        }

        public int Add(string Name, string Spaciality, string YearEdition,
            string MountEdition, string DateEdition)
        {
            var newSchool = new School
            {
                Name = Name,
                Spaciality = Spaciality,
                YearEdition = YearEdition,
                MountEdition = MountEdition, 
                DateEdition = DateEdition,
            };
            this.school.Add(newSchool);
            this.school.SaveChanges();
            return newSchool.Id;
        }
    }
}
