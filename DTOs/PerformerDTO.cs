namespace ShowsProject.DTOs
{
    public class PerformerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Perform { get; set; }
        public string Description { get; set; }
        public string TelNumber { get; set; }
        public ApplicationDTO[] Applications { get; set; }

    }
}
