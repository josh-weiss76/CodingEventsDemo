using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
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
        public RegistrationRequired Registration { get; set; }
        public List<SelectListItem> RegistrationRequirement { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(RegistrationRequired.Yes.ToString(), ((int)RegistrationRequired.Yes).ToString()),
            new SelectListItem(RegistrationRequired.No.ToString(), ((int)RegistrationRequired.No).ToString())
        };

        public EventType Type { get; set; }
        public List<SelectListItem> EventTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(EventType.Conference.ToString(), ((int)EventType.Conference).ToString()),
            new SelectListItem(EventType.Meetup.ToString(), ((int) EventType.Meetup).ToString()),
            new SelectListItem(EventType.Workshop.ToString(), ((int) EventType.Workshop).ToString()),
            new SelectListItem(EventType.Social.ToString(), ((int) EventType.Social).ToString())
        };
        // <option value="0">Conference</option>

    }
}
