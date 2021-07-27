namespace PetCare.Models.Pets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using PetCare.Services.Pets.Models;

    using static DataConstants.Pet;

    public class AddPetFormModel 
    {
        [Required]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = "Name must be between '2' and '40' symbols.")]
        public string Name { get; init; }

        [Display(Name = "Gender")]
        public int GenderId { get; init; }

        [Display(Name = "Animal Type")]
        public int AnimalId { get; init; }
        
        [Required]
        [StringLength(int.MaxValue ,
            MinimumLength = DescriptionMinLength ,
            ErrorMessage = "Description must be with a minimum length of '10' symbols.")]
        public string Description { get; init; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        [Display(Name = "Birth Date")]

        public DateTime BirthDate { get; init; }

        [Required]
        [StringLength(BreedMaxLength,
            MinimumLength = BreedMinLength,
            ErrorMessage = "Breed must be between '3' and '25' symbols.")]

        public string Breed { get; init; }

        [Required]
        public string Image { get; set; }

        public IEnumerable<AnimalTypeServiceModel> AnimalTypes { get; set; }
        public IEnumerable<GenderTypeServiceModel> GengerTypes { get; set; }

       
    }
}
