namespace PetCare.Models.Pets
{
    using PetCare.Data.Models.Enums;

    public class DetailsPetFormModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public Gender Gender{ get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public string AnimalType { get; set; }
        public string Image { get; set; }
    }
}
