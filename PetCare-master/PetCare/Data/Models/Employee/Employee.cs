namespace PetCare.Data.Models.Employee
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static PetCare.Models.DataConstants.Employee;
    public class Employee
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; init; }

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; init; }

        [Required]
        [Range(AgeMinRange, AgeMaxRange)]
        public byte Age { get; init; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; init; }

        [Required]
        public int PositionId { get; set; }
        public Position Position { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Autobiography { get; set; }

    }
}
