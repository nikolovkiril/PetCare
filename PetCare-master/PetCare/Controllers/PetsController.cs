namespace PetCare.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Models.Pets;
    using Microsoft.AspNetCore.Authorization;
    using PetCare.Infrastructure;
    using PetCare.Services.Pets;
    using PetCare.Services.Owner;
    using System;

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
                ownerId);

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

            if (!this.ownerService.IsUserOwner(userId, petId) && !User.IsAdmin())
            {
                return RedirectToAction(nameof(All));
            }

            var pet = this.petService.Details(petId);

            return View(pet);
        }

        public IActionResult Edit(string petId)
        {
            var pet = this.petService.Details(petId);

            return View(new PetFormModel 
            {
                Name = pet.Name,
                Breed = pet.Breed,
                Description = pet.Description,
                GengerTypes = this.petService.GetGender(),
                AnimalTypes = this.petService.GetAnimalTypes(),
                BirthDate = DateTime.UtcNow,
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
                pet.Image);

            if (!petIsEdited)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(All));
        }
    }
}
