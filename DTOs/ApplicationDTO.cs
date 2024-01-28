namespace ShowsProject.DTOs
{
    public class ApplicationDTO
    {
        public bool IsApproved { get; set; }
        public int ShowId { get; set; }
        public ShowDTO Show { get; set; }
        public int PerformerId { get; set; }
        public PerformerDTO Performer { get; set; }
    }
}
