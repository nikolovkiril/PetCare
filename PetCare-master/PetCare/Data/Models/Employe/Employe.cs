﻿namespace PetCare.Data.Models.Employe
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static PetCare.Models.DataConstants;
    public class Employe
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

        public DateTime HireDate { get; init; }

        [Required]
        public int PositionId { get; set; }
        public Position Position { get; set; }

    }
}
