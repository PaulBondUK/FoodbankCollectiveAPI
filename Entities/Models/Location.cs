using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Location
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "AddressLine1 is a required field.")]
        [MaxLength(100, ErrorMessage = "Max length for AddressLine1 is 100 characters")]
        public string AddressLine1 { get; set; }

        [Required(ErrorMessage = "AddressTown is a required field")]
        [MaxLength(30, ErrorMessage = "Max length for AddressTown is 30 characters")]
        public string AddressTown { get; set; }

        [Required(ErrorMessage = "AddressCounty is a required field")]
        [MaxLength(30, ErrorMessage = "Max length for AddressCounty is 30 characters")]
        public string AddressCounty { get; set; }

        [Required(ErrorMessage = "AddressPostcode is a required field")]
        [MaxLength(10, ErrorMessage = "Max length for AddressPostcode is 10 characters")]
        public string AddressPostcode { get; set; }

        [ForeignKey(nameof(Foodbank))]
        public Guid FoodbankId { get; set; }
        public Foodbank Foodbank { get; set; }

    }
}