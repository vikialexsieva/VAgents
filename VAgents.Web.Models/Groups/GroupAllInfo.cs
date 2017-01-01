namespace VAgents.Info.Model.Groups
{
    public class GroupAllInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Count { get; set; }
        public int SolutionId { get; set; }
        public virtual GroupsInfo Solution { get; set; }
    }
}