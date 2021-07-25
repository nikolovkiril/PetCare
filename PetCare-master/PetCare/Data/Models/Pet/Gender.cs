namespace PetCare.Data.Models.Pet
{
    using System.Collections.Generic;

    public class Gender
    {
        public int Id { get; init; }

        public string GenderType { get; set; }

        public IEnumerable<Pet> Pets { get; set; } = new List<Pet>();
    }
}
