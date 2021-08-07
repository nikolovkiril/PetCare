namespace PetCare.Data.Models.Pet
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static PetCare.Models.DataConstants.Pet;

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
        public int GenderId { get; set; }
        public Gender GenderType { get; set; }

        [Required]
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        [Required]
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        [Url]
        [Required]
        public string Image { get; set; }

        [Required]
        public bool IsForAdoption { get; set; }
    }
}
