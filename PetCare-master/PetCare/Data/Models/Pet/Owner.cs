namespace PetCare.Data.Models.Pet
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Owner 
    {
        public int Id { get; init; }

        [Required]
        public string UserId { get; init; }
        public IEnumerable<Pet> Pets { get; set; } = new List<Pet>();
    }
}
