using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShowsProject.Models
{
    public class Show
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [MaxLength(100)]
        public string Location { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Duration is required")]
        public string Duration { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public List<Application> Applications { get; set; }
    }

}
