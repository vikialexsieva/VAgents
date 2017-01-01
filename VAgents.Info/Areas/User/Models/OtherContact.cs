using System.Collections.Generic;

namespace VAgents.Info.ViewModel
{
    public class OtherContactViewModels
    {
        public int Id { get; set; }
        public string Links { get; set; }
        public string FateDay { get; set; }
        public int LanguegesId { get; set; }
        public virtual ICollection<LanguegeViewModels> Languege { get; set; }
        public int PoliticId { get; set; }
        public virtual ICollection<PoliticViewModels> Politic { get; set; }
    }
}