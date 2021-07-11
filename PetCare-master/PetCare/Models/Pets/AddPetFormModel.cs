namespace PetCare.Models.Pets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static PetCare.Models.DataConstants;

    public class AddPetFormModel 
    {
        [Required]
        [StringLength(PetNameMaxLength,
            MinimumLength = PetNameMinLength,
            ErrorMessage = "Name must be between '2' and '40' symbols.")]
        public string Name { get; init; }

        [Required]
        [Range(PetAgeMinRange,PetAgeMaxRange,ErrorMessage = "Age must be between 1 and 100.")]
        public byte Age { get; init; }

        [Display(Name = "Please select")]
        public int AnimalId { get; init; }
        
        [Required]
        [StringLength(int.MaxValue ,
            MinimumLength = DescriptionMinLength ,
            ErrorMessage = "Description must be with a minimum length of '10' symbols.")]
        public string Description { get; init; }

        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        public DateTime DateTime { get; init; } = DateTime.UtcNow;

        [Required]
        [StringLength(BreedMaxLength,
            MinimumLength = BreedMinLength,
            ErrorMessage = "Breed must be between '3' and '25' symbols.")]
        public string Breed { get; init; }

        public IEnumerable<AnimalTypeViewModel> AnimalTypes { get; set; }
    }
}
