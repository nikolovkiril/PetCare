namespace PetCare.Services.Pet
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using PetCare.Data;
    using PetCare.Data.Models.Pet;
    using PetCare.Services.Pet.Models;

    public class PetService : IPetService
    {
        private readonly PetCareDbContext data;
        private readonly IMapper mapper;

        public PetService(
            PetCareDbContext data,
            IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }


        public void CreatePet(
            string name,
            string breed,
            int genderId,
            int animalId,
            string description,
            DateTime birthDate,
            string image,
            int ownerId,
             bool isForAdoption)
        {
            var pet = new Pet
            {
                Name = name,
                Breed = breed,
                GenderId = genderId,
                AnimalId = animalId,
                Description = description,
                BirthDate = birthDate,
                Image = image,
                OwnerId = ownerId,
                IsForAdoption = isForAdoption
            };

            this.data.Pets.Add(pet);

            this.data.SaveChanges();
        }

        public bool IsPetExist(string petId)
             => this.data
                .Pets
                .Any(t => t.Id == petId);


        public bool IsAnimalExist(int AnimalId)
            => this.data
                .Animals
                .Any(a => a.Id == AnimalId);


        public bool IsGenderExist(int GenderId)
            => this.data
                .Genders
                .Any(g => g.Id == GenderId);


        public IEnumerable<PetDetailsServiceModel> All()
        {
            var all = this.data
                .Pets
                .Where(u => u.IsForAdoption == true)
                .ProjectTo<PetDetailsServiceModel>(this.mapper.ConfigurationProvider)
                .ToList();

            return all;
        }

        public IEnumerable<PetDetailsServiceModel> All(string userId)
        {
            var all = this.data
                .Pets
                .Where(u => u.Owner.UserId == userId)
                .ProjectTo<PetDetailsServiceModel>(this.mapper.ConfigurationProvider)
                .ToList();

            return all;
        }

        public IEnumerable<PetDetailsServiceModel> All(bool isAdmin)
        {
            var all = this.data
                .Pets
                .ProjectTo<PetDetailsServiceModel>(this.mapper.ConfigurationProvider)
                .OrderBy(p => p.OwnerId)
                .ToList();

            return all;
        }

        public PetDetailsServiceModel Details(string petId)
        {
            var petToDisplay = this.data
               .Pets
               .FirstOrDefault(p => p.Id == petId);

            var date = DateTime.UtcNow.Year;
            var petAge = date - petToDisplay.BirthDate.Year;


            var pet = this.data
                 .Pets
                 .Where(p => p.Id == petId)
                 .ProjectTo<PetDetailsServiceModel>(this.mapper.ConfigurationProvider)
                 .FirstOrDefault();

            pet.Age = (byte)petAge;

            return pet;
        }

        public IEnumerable<AnimalTypeServiceModel> GetAnimalTypes()
            => this.data
                 .Animals
                 .ProjectTo<AnimalTypeServiceModel>(this.mapper.ConfigurationProvider)
                 .ToList();

        public IEnumerable<GenderTypeServiceModel> GetGender()
             => this.data
                 .Genders
                 .ProjectTo<GenderTypeServiceModel>(this.mapper.ConfigurationProvider)
                 .ToList();


        public bool Edit(
            string petId,
            string name,
            string breed,
            int genderId,
            int animalId,
            string description,
            DateTime birthDate,
            string image,
            bool isForAdoption)
        {
            var petToEdit = this.data.Pets.Find(petId);

            if (petToEdit == null)
            {
                return false;
            }

            petToEdit.Name = name;
            petToEdit.Breed = breed;
            petToEdit.GenderId = genderId;
            petToEdit.AnimalId = animalId;
            petToEdit.Description = description;
            petToEdit.BirthDate = birthDate;
            petToEdit.Image = image;
            petToEdit.IsForAdoption = isForAdoption;

            this.data.SaveChanges();

            return true;
        }
    }
}
