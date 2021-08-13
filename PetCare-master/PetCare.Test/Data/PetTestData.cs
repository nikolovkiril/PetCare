namespace PetCare.Test.Data
{
    using MyTested.AspNetCore.Mvc;
    using PetCare.Data.Models.Pet;
    using PetCare.Data.Models.User;
    using PetCare.Services.Pet.Models;
    using PetCare.Test.Mocks;
    using System.Linq;

    public static class PetTestData
    {
        public static Animal CreateAnimal()
        {
            var data = DatabaseMock.Instance;

            var animal = new Animal
            {
                AnimalType = "Dog"
            };

            data.Animals.Add(animal);
            data.SaveChanges();

            return animal;
        }
        public static Gender CreateGender()
        {
            var data = DatabaseMock.Instance;

            var gender = new Gender
            {
                GenderType = "M"
            };

            data.Genders.Add(gender);
            data.SaveChanges();

            return gender;
        }
        public static string PetId()
        {
            var data = DatabaseMock.Instance;

            var user = new User
            {
                Id = TestUser.Identifier,
                UserName = TestUser.Username
            };

            var petId = data.Pets.Select(x => x.Id).FirstOrDefault();

            return petId;
        }
        public static Pet CreatePet()
        {
            var data = DatabaseMock.Instance;

            var user = new User
            {
                Id = TestUser.Identifier,
                UserName = TestUser.Username
            };

            var animal = new Animal
            {
                AnimalType = "Dog"
            };

            var gender = new Gender
            {
                GenderType = "M"
            };
            var owner = new Owner
            {
                UserId = user.Id
            };

            var pet = new Pet
            {
                Name = "Roshko",
                AnimalId = 1,
                GenderId = 1,
                OwnerId = 1,
            };

            data.Animals.Add(animal);
            data.Genders.Add(gender);
            data.Owners.Add(owner);
            data.Pets.Add(pet);
            data.SaveChanges();

            return pet;
        }
    }
}