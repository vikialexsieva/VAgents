using System.Collections.Generic;

namespace VAgents.Info.Model.User
{
    public class UserAllInfo
    {
        public int Id { get; set; }
        public string UserPhone { get; set; }
        public string UserUrl { get; set; }
        public string DateOfByrth { get; set; }
        public string YearOfByrth { get; set; }
        public string MountOfByrth { get; set; }
        public string About { get; set; }
        public string OtherNames { get; set; }
        public string OtherInfo { get; set; }
        public int JobsId { get; set; }
        public virtual ICollection<Jobs> Jobs { get; set; }
        public int SchoolId { get; set; }
        public virtual ICollection<School> School { get; set; }
        public int ByrnPlaceId { get; set; }
        public virtual ICollection<ByrnPlace> ByrnPlace { get; set; }
        public int NowLifeCityId { get; set; }
        public virtual ICollection<NowLifeCity> NowLifeCity { get; set; }
        public int OtherContactId { get; set; }
        public virtual ICollection<OtherContact> OtherContact { get; set; }
        public int MutualRalationId { get; set; }
        public virtual ICollection<MutualRalation> MutualRalation { get; set; }
        public int FamilyId { get; set; }
        public virtual ICollection<Family> Family { get; set; }
        
    }
}