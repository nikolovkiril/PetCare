﻿namespace PetCare.Services.Pet
{
    using System;
    using System.Collections.Generic;
    using PetCare.Services.Pet.Models;

    public interface IPetService
    {
        bool IsAnimalExist(int AnimalId);

        bool IsGenderExist(int GenderId);

        void CreatePet(
            string name,
            string breed,
            int genderId,
            int animalId,
            string description,
            DateTime birthDate,
            string image,
            int ownerId,
            bool isForAdoption);

        bool Edit(
          string petId,
          string name,
          string breed,
          int genderId,
          int animalId,
          string description,
          DateTime birthDate,
          string image,
          bool isForAdoption);


        PetDetailsServiceModel Details(string petId);

        public IEnumerable<PetDetailsServiceModel> All();
        IEnumerable<PetDetailsServiceModel> All(string userId);
        IEnumerable<PetDetailsServiceModel> All(bool isAdmin);

        IEnumerable<AnimalTypeServiceModel> GetAnimalTypes();

        IEnumerable<GenderTypeServiceModel> GetGender();

    }
}
