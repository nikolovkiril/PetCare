namespace PetCare.Data.Models.Clinic
{
    using System.Collections.Generic;


    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AddressId { get; set; }
        public int ClinicId { get; set; }

        public IEnumerable<Address> Addresses { get; set; } = new List<Address>();
        public IEnumerable<Clinic> Clinics { get; set; } = new List<Clinic>();

    }
}
