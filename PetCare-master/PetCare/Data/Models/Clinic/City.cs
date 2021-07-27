namespace PetCare.Data.Models.Clinic
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class City
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<Clinic> Clinics { get; set; } = new List<Clinic>();
    }
}
