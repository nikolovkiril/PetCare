namespace PetCare.Services.Adoption
{
    using System.Linq;
    using System.Collections.Generic;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using PetCare.Data;
    using PetCare.Services.Pet.Models;
    using System;

    public class AdoptionService : IAdoptionService
    {
        private readonly PetCareDbContext data;
        private readonly IMapper mapper;

        public AdoptionService(
            PetCareDbContext data,
            IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }
        public IEnumerable<PetDetailsServiceModel> All()
        {
            var all = this.data
                    .Pets
                    .Where(u => u.IsForAdoption == true)
                    .ProjectTo<PetDetailsServiceModel>(this.mapper.ConfigurationProvider)
                    .ToList();

            return all;
        }

        public PetDetailsServiceModel Details(string petId, string userId)
        {
            var date = DateTime.UtcNow.Year;

            var pet = this.data
                 .Pets
                 .Where(p => p.Id == petId)
                 .ProjectTo<PetDetailsServiceModel>(this.mapper.ConfigurationProvider)
                 .FirstOrDefault();

            var petAge = date - pet.BirthDate.Year;

            pet.Age = (byte)petAge;

            pet.IsOwner = IsOwner(petId, userId);

            return pet;
        }

        public bool IsOwner(string petId, string userId)
             => this.data
                .Pets
                .Any(p => p.Id == petId && p.Owner.UserId == userId);


        public bool Edit(
            string petId,
            string userId)
        {
            var petToEdit = this.data.Pets.Find(petId);
            var owner = this.data.Owners.Where(x => x.UserId == userId).FirstOrDefault();

            if (petToEdit == null || owner == null)
            {
                return false;
            }

            petToEdit.OwnerId = owner.Id;
            petToEdit.IsForAdoption = false;

            this.data.SaveChanges();

            return true;
        }
    }
}
