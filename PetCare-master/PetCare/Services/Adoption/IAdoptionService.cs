namespace PetCare.Services.Adoption
{
    using System.Collections.Generic;
    using PetCare.Services.Pet.Models;

    public interface IAdoptionService
    {
        public IEnumerable<PetDetailsServiceModel> All();
        PetDetailsServiceModel Details(string petId, string userId);
        bool IsOwner(string userId, string petId);
        public bool Edit(string petId, string userId);

    }
}
