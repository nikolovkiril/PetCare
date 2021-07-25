namespace PetCare.Data.Models.Clinic
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static PetCare.Models.DataConstants.Address;

    public class Address
    {
        public int Id { get; init; }

        [Required]
        public int CityId { get; set; }
        public City City { get; set; }

        [Required]
        [MaxLength(StreetMaxLength)]
        public string Street { get; set; }

        [Required]
        [MaxLength(StreetMaxLength)]
        public int PostCode { get; set; }

    }
}
