namespace PetCare.Data.Models.Pet
{
    using System;
    using System.Linq;
    using System.Globalization;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Principal;

    using static PetCare.Models.DataConstants;

    public class Pet 
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(PetNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [Range(PetAgeMinRange , PetAgeMaxRange)]
        public byte Age { get; set; }

        [Required]
        [MaxLength(BreedMaxLength)]
        public string Breed { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime BirthDate { get; set; }

        //public string UserId { get; set; }

        [Required]
        public int AnimalId { get; set; }
        public AnimalType AnimalType { get; set; }

        [Required]
        public string Image { get; set; }
    }
}
