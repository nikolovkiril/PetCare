namespace PetCare.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using PetCare.Models.Pets;
    using PetCare.Services.Pet;
    using PetCare.Infrastructure;
    using PetCare.Services.Owner;
    using System.Globalization;

    [Authorize]
    public class PetsController : Controller
    {
        private readonly IPetService petService;
        private readonly IOwnerService ownerService;

        public PetsController(
            IPetService petService,
            IOwnerService ownerService)
        {
            this.petService = petService;
            this.ownerService = ownerService;
        }

        public IActionResult Add()
        {
            return View(new PetFormModel
            {
                AnimalTypes = this.petService.GetAnimalTypes(),
                GengerTypes = this.petService.GetGender()
            });

        }
        [HttpPost]
        public IActionResult Add(PetFormModel pet)
        {
            var userId = this.User.GetId();

            if (!this.ownerService.IsOwnerExist(userId))
            {
                this.ownerService.AddOwner(userId);
            }

            if (!this.petService.IsAnimalExist(pet.AnimalId))
            {
                this.ModelState.AddModelError(nameof(pet.AnimalId), "Plese select some of the options.");
            }

            if (!this.petService.IsGenderExist(pet.GenderId))
            {
                this.ModelState.AddModelError(nameof(pet.GenderId), "Plese select some of the options.");
            }

            if (!ModelState.IsValid)
            {
                pet.AnimalTypes = this.petService.GetAnimalTypes();
                pet.GengerTypes = this.petService.GetGender();

                return View(pet);
            }

            var ownerId = this.ownerService.GetOwnerId(userId);

            this.petService.CreatePet(
                pet.Name,
                pet.Breed,
                pet.GenderId,
                pet.AnimalId,
                pet.Description,
                pet.BirthDate,
                pet.Image,
                ownerId,
                pet.IsForAdoption);

            return RedirectToAction(nameof(All));
        }


        public IActionResult All()
        {
            var userId = this.User.GetId();

            if (User.IsAdmin())
            {
                var pets = this.petService.All(User.IsAdmin());

                return View(pets);
            }

            var pet = this.petService.All(userId);

            return View(pet);
        }

        public IActionResult Details(string petId)
        {
            var userId = this.User.GetId();

            var pet = this.petService.Details(petId , userId);

            if (!this.ownerService.IsUserOwner(userId, petId) && !User.IsAdmin() && pet.IsForAdoption == false)
            {
                return RedirectToAction(nameof(All));
            }


            return View(pet);
        }

        public IActionResult Edit(string petId)
        {
            var userId = this.User.GetId();

            var pet = this.petService.Details(petId , userId);

            return View(new PetFormModel 
            {
                Name = pet.Name,
                Breed = pet.Breed,
                Description = pet.Description,
                GenderId = pet.GenderId,
                AnimalId = pet.AnimalId,
                GengerTypes = this.petService.GetGender(),
                AnimalTypes = this.petService.GetAnimalTypes(),
                BirthDate = pet.BirthDate.Date,
                Image = pet.Image
            });
        }

        [HttpPost]
        public IActionResult Edit(string petId, PetFormModel pet)
        {
            var userId = this.User.GetId();

            if (!this.petService.IsAnimalExist(pet.AnimalId))
            {
                this.ModelState.AddModelError(nameof(pet.AnimalId), "Plese select some of the options.");
            }

            if (!this.petService.IsGenderExist(pet.GenderId))
            {
                this.ModelState.AddModelError(nameof(pet.GenderId), "Plese select some of the options.");
            }

            if (!ModelState.IsValid)
            {
                pet.AnimalTypes = this.petService.GetAnimalTypes();
                pet.GengerTypes = this.petService.GetGender();

                return View(pet);
            }

            var ownerId = this.ownerService.GetOwnerId(userId);

            var petIsEdited = this.petService.Edit(
                petId,
                pet.Name,
                pet.Breed,
                pet.GenderId,
                pet.AnimalId,
                pet.Description,
                pet.BirthDate,
                pet.Image,
                pet.IsForAdoption);

            if (!petIsEdited)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(All));
        }

        public IActionResult Delete(string petId)
        {
            this.petService.Delete(petId);

            return RedirectToAction(nameof(All));
        }
    }
}
