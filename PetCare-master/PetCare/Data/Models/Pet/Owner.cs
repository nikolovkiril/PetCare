﻿namespace PetCare.Data.Models.Pet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Owner 
    {
        public int Id { get; init; }

        [Required]
        public string UserId { get; init; }
        public IEnumerable<Pet> Pets { get; init; } = new List<Pet>();
    }
}
