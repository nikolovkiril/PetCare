﻿namespace PetCare.Data.Models.Clinic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static PetCare.Models.DataConstants.Clinic;

    public class Clinic
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public int AddresId { get; set; }
        public Address Address { get; set; }

        [Required]
        public int CityId { get; set; }
        public City City { get; set; }


        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        public IEnumerable<City> Cities { get; set; } = new List<City>();
        public IEnumerable<Address> Addresses { get; set; } = new List<Address>();
    }
}