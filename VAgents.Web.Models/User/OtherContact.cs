namespace VAgents.Info.Model.User
{
    using System.Collections.Generic;
    public class OtherContact
    {
        public int Id { get; set; }
        public string Links { get; set; }
        public string FateDay { get; set; }
        public int LanguegesId { get; set; }
        public virtual ICollection<Languege> Languege { get; set; }
        public int PoliticId { get; set; }
        public virtual ICollection<Politic> Politic { get; set; }
    }
}