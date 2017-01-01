using System.Collections.Generic;

namespace VAgents.Info.ViewModel
{
    public class UserAllInfoViewModels
    {
        public int Id { get; set; }
        public string UserPhone { get; set; }
        public string UserUrl { get; set; }
        public string DateOfByrth { get; set; }
        public string YearOfByrth { get; set; }
        public string MountOfByrth { get; set; }
        public int JobsId { get; set; }
        public virtual ICollection<JobsViewModels> Jobs { get; set; }
        public int SchoolId { get; set; }
        public virtual ICollection<SchoolViewModels> School { get; set; }
        public int ByrnPlaceId { get; set; }
        public virtual ICollection<ByrnPlaceViewModels> ByrnPlace { get; set; }
        public int NowLifeCityId { get; set; }
        public virtual ICollection<NowLifeCityViewModels> NowLifeCity { get; set; }
        public int OtherContactId { get; set; }
        public virtual ICollection<OtherContactViewModels> OtherContact { get; set; }
        public int MutualRalationId { get; set; }
        public virtual ICollection<MutualRalationViewModels> MutualRalation { get; set; }
        public int FamilyId { get; set; }
        public virtual ICollection<FamilyViewModels> Family { get; set; }
        public string About { get; set; }
        public string OtherNames { get; set;}
        public string OtherInfo { get; set; }
    }
}