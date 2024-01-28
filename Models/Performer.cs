using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShowsProject.Models
{
    public class Performer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Perform is required")]
        public string Perform { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "TelNumber is required")]
        public string TelNumber { get; set; }

        public List<Application> Applications { get; set; }
    }
}
