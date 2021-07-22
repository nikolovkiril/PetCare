namespace PetCare.Data.Models.Pet
{
    using System;
    using System.Linq;
    using System.Globalization;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Principal;

    using static PetCare.Models.DataConstants.Pet;
    using PetCare.Data.Models.Enums;

    public class Pet 
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(BreedMaxLength)]
        public string Breed { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public Gender Gender { get; set; }

        //public string UserId { get; set; }

        [Required]
        public int AnimalId { get; set; }
        public AnimalType AnimalType { get; set; }

        [Url]
        [Required]
        public string Image { get; set; }
    }
}
