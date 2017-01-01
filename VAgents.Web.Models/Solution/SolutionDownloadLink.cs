namespace VAgents.Info.Model.Solution
{
    public class SolutionDownloadLink
    {
        public  int Id { get; set; }
        public string URL { get; set;}
        public string Image { get; set; }
        public int SolutionId { get; set; }
        public Solutions Solution { get; set; }
    }
}