using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Event location is required")]
        [StringLength(100, ErrorMessage ="Location is too long, reduce the amount of characters")]
        public string Location { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Range(0, 100000)]
        public int NumberOfAttendees { get; set; }

        public bool IsTrue { get { return true; } }

        [Required]
        [StringLength(3)]
        public string RegistrationRequired { get; set; }


    }
}
