namespace VAgents.Info.ViewModel.GroupsViewModels
{
    using System.Collections.Generic;

    public class GroupsInfoViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public virtual ICollection<GroupImageViewModels> GroupImage { get; set; }

    }
}
