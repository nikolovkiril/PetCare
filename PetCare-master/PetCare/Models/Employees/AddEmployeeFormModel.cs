namespace PetCare.Models.Employees
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static PetCare.Models.DataConstants;

    public class AddEmployeeFormModel
    {
        [Required]
        [StringLength(FirstNameMaxLength,
           MinimumLength = FirstNameMinLength,
           ErrorMessage = "First Name must be between '2' and '20' symbols.")]
        public string FirstName { get; init; }

        [Required]
        [StringLength(LastNameMaxLength,
           MinimumLength = LastNameMinLength,
           ErrorMessage = "Last Name must be between '2' and '35' symbols.")]
        public string LastName { get; init; }

        [Required]
        [Range(AgeMinRange, AgeMaxRange, ErrorMessage = "Age must be between 16 and 99.")]
        public byte Age { get; init; }

        public DateTime HireDate { get; init; } 

        [Display(Name = "Please select")]
        [Required]
        public int PositionId { get; init; }

        public IEnumerable<PositionViewModel> EmployeePosition { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MinLength(AutobiographyMinLength, ErrorMessage = "The Autobiography field is required , min 10 symbols.")]
        public string Autobiography { get; set; }
    }
}
