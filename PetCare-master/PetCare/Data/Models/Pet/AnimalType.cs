namespace PetCare.Data.Models.Pet
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AnimalType
    {
        public int Id { get; init; }

        [Required]
        public string Type { get; set; }

        public IEnumerable<Pet> Pets { get; set; } = new List<Pet>();

    }
}
