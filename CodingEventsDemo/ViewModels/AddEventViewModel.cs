using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage ="Event name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Event name must be between 3 and 50 characters long")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Event description is required")]
        [StringLength(500, ErrorMessage ="Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }
    }
}
