namespace PetCare.Test.Controllers
{
    using System;
    using Xunit;
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;
    using PetCare.Models.Pets;
    using PetCare.Test.Data;
    using PetCare.Services.Pet.Models;
    using PetCare.Data.Models.Pet;
    using System.Linq;

    public class PetsControllerTest
    {

        [Fact]
        public void AllShouldReturnCorrectView()
          => MyController<PetsController>
              .Instance()
              .Calling(c => c.All())
              .ShouldReturn()
              .View();

        [Fact]
        public void AddShouldReturnCorrectView()
          => MyController<PetsController>
              .Instance()
              .Calling(c => c.Add())
              .ShouldReturn()
              .View(view => view
                    .WithModelOfType<PetFormModel>());

        [Theory]
        [InlineData("Roshko", 1, 1, "asd asd asda ", "8/10/2020 12:00:00 AM", "Street", "a")]
        public void PostAddShouldBeForAuthorizedUsersAndReturnViewIfModelIsNotValid(
            string petName,
            int animalId,
            int genderId,
            string description,
            DateTime birthDate,
            string breed,
            string image)
            => MyController<PetsController>
                .Instance(controller => controller
                    .WithUser())
                .Calling(c => c
                    .Add(new PetFormModel
                    {
                        Name = petName,
                        Breed = breed,
                        Description = description,
                        BirthDate = birthDate,
                        GenderId = genderId,
                        AnimalId = animalId,
                        Image = image,
                    }))
                .ShouldHave()
                .ActionAttributes(attributes => attributes
                    .RestrictingForHttpMethod(HttpMethod.Post)
                    .RestrictingForAuthorizedRequests())
                .AndAlso()
                .ShouldReturn()
                .View(view => view
                    .WithModelOfType<PetFormModel>());


        [Theory]
        [InlineData("Roshko", 1, 1, "asd asd asda ", "8/10/2020 12:00:00 AM", "Street", "a")]
        public void PostAddShouldBeForAuthorizedUsersAndRedirectToAll(
            string petName,
            int animalId,
            int genderId,
            string description,
            DateTime birthDate,
            string breed,
            string image)
            => MyController<PetsController>
                .Instance(controller => controller
                    .WithUser()
                    .WithData(PetTestData.CreateGender())
                    .WithData(PetTestData.CreateAnimal()))
                .Calling(c => c
                    .Add(new PetFormModel
                    {
                        Name = petName,
                        Breed = breed,
                        Description = description,
                        BirthDate = birthDate,
                        GenderId = genderId,
                        AnimalId = animalId,
                        Image = image,
                    }))
                .ShouldHave()
                .ActionAttributes(attributes => attributes
                    .RestrictingForHttpMethod(HttpMethod.Post)
                    .RestrictingForAuthorizedRequests())
                .ValidModelState()
                .Data(data => data
                    .WithSet<Pet>(pets => pets
                        .Any(p =>
                            p.AnimalId == animalId &&
                            p.GenderId == genderId)))
                .AndAlso()
                .ShouldReturn()
                .RedirectToAction("All", "/Pets");

        [Fact]
        public void GetDetailsShouldReturnCorrectView()
            => MyController<PetsController>
                 .Instance(controller => controller
                    .WithUser()
                    .WithData(PetTestData.CreatePet()))
                 .Calling(c => c.Details(PetTestData.PetId()))
                 .ShouldReturn()
                 .View(view => view
                       .WithModelOfType<PetDetailsServiceModel>());



        [Fact]
        public void GetEditShouldBeForAuthorizedUsersAndRedirectToAll()
             => MyController<PetsController>
                 .Instance(controller => controller
                    .WithUser()
                    .WithData(PetTestData.CreatePet()))
                 .Calling(c => c.Edit(PetTestData.PetId()))
                 .ShouldReturn()
                 .View();





        [Fact]
        public void PostEditShouldBeForAuthorizedUsersAndRedirectToAll()
            => MyController<PetsController>
                .Instance(controller => controller
                    .WithUser()
                    .WithData(PetTestData.CreatePet()))
                .Calling(c => c
                    .Edit(PetTestData.PetId(), new PetFormModel
                    {
                        Name = "Roshko",
                        GenderId = 1,
                        AnimalId = 1,
                        Description = "asd asd asda ",
                        BirthDate = DateTime.UtcNow,
                        Breed = "Street",
                        Image = "asd",
                    }))
                .ShouldHave()
                .ActionAttributes(attributes => attributes
                    .RestrictingForHttpMethod(HttpMethod.Post)
                    .RestrictingForAuthorizedRequests())
                .ValidModelState()
                .Data(data => data
                    .WithSet<Pet>(pets => pets
                        .Any(p =>
                            p.AnimalId == 1 &&
                            p.GenderId == 1)))
                .AndAlso()
                .ShouldReturn()
                .RedirectToAction("/All", "/Pets");

    }
}
