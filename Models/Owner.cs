using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShowsProject.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string UserId { get; set; }
        public List<Show> Shows { get; set; }

    }

}
