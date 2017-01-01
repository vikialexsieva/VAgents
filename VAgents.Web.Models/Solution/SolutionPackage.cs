namespace VAgents.Info.Model.Solution
{
    public class SolutionPackage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SolutionId { get; set; }
        public Solutions Solution { get; set; }
    }
}