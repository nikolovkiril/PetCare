namespace PetCare.Models.Clinics
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using PetCare.Services.Clinics.Models;

    using static DataConstants.Clinic;
    public class ClinicFormModel
    {
        [Required]
        [StringLength(
            NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = "Clinic Name must be between '3' and '30' symbols.")]
        public string Name { get; set; }

        [Required]
        [StringLength(
            StreetMaxLength,
            MinimumLength = StreetMinLength,
            ErrorMessage = "Street Name must be between '10' and '50' symbols.")]

        public string Street { get; set; }


        [Required]
        [Display(Name = "City")]
        public int CityId { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [StringLength(
            PhoneNumberMaxLength,
            MinimumLength = PhoneNumberMinLength,
            ErrorMessage = "PhoneNumber Name must be between '8' and '25' symbols.")]
        public string PhoneNumber { get; set; }

        public IEnumerable<CityNameServiceModel> CityNames { get; set; }

    }
}
