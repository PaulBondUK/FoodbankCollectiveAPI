using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Foodbank
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Foodbank name is a required field")]
        [MaxLength(100, ErrorMessage = "Max length for Foodbank name is 100 characters")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "Max length for website is 100 characters")]
        public string Website { get; set; }

        [MaxLength(100, ErrorMessage = "Max length for the email address is 100 characters")]
        public string EmailAddress { get; set; }

        [MaxLength(15, ErrorMessage = "Max length for contact number is 15")]
        public string ContactNumber { get; set; }

        public ICollection<Location> Locations { get; set; }
    }
}