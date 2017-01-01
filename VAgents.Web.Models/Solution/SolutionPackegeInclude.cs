namespace VAgents.Info.Model.Solution
{
    public class SolutionPackegeInclude
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int SolutionId { get; set; }
        public Solutions Solution { get; set; }
    }
}