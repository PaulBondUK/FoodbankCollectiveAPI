using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Foodbank
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public string FacebookPage { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}