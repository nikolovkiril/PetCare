namespace PetCare.Services.Pets.Models
{
    public class PetDetailsServiceModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public int GenderId { get; set; }
        public string GenderType { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public int AnimalId { get; set; }
        public string Animal { get; set; }
        public string Image { get; set; }
        public string OwnerId { get; set; }
    }
}
