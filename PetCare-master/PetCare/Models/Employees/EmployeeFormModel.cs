namespace PetCare.Models.Employees
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using PetCare.Services.Employee.Models;

    using static DataConstants.Employee;

    public class EmployeeFormModel
    {
        [Required]
        [StringLength(FirstNameMaxLength,
           MinimumLength = FirstNameMinLength,
           ErrorMessage = "First Name must be between '2' and '20' symbols.")]
        [Display(Name = "First Name")]

        public string FirstName { get; init; }

        [Required]
        [StringLength(LastNameMaxLength,
           MinimumLength = LastNameMinLength,
           ErrorMessage = "Last Name must be between '2' and '35' symbols.")]
        [Display(Name = "Last Name")]

        public string LastName { get; init; }

        [Required]
        [Range(AgeMinRange, AgeMaxRange, ErrorMessage = "Age must be between 16 and 99.")]
        public byte Age { get; init; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; init; } 

        [Display(Name = "Position")]
        [Required]
        public int PositionId { get; init; }

        [Required]
        [Display(Name = "Image Url")]

        public string ImageUrl { get; set; }

        [Required]
        [MinLength(AutobiographyMinLength, ErrorMessage = "The Autobiography field is required , min 10 symbols.")]
        public string Autobiography { get; set; }

        public IEnumerable<PositionTypeServiceModel> EmployeePosition { get; set; }

    }
}
