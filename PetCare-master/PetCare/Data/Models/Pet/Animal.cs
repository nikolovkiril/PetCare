namespace PetCare.Data.Models.Pet
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Animal
    {
        public int Id { get; init; }

        [Required]
        public string AnimalType { get; set; }

        public IEnumerable<Pet> Pets { get; set; } = new List<Pet>();
    }
}
