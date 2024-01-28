using System;

namespace ShowsProject.Models
{
    public class Application
    {
        public int Id { get; set; }

        public bool IsApproved { get; set; }

        public int ShowId { get; set; }
        public Show Show { get; set; }

        public int PerformerId { get; set; }
        public Performer Performer { get; set; }

    }
}
