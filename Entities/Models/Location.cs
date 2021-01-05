using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressTownOrCity { get; set; }
        public string AddressCounty { get; set; }
        public string AddressPostcode { get; set; }

        public int FoodbankId { get; set; }
        public Foodbank Foodbank { get; set; }
    }
}