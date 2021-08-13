namespace PetCare.Areas.Admin.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using PetCare.Models.Pets;
    using PetCare.Services.Pet;
    using PetCare.Infrastructure;
    using PetCare.Services.Owner;

    using static AdminConstans;

    [Area(AdminConstans.AreaName)]
    [Authorize(Roles = AdministartorRoleName)]
    public class PetsController : Controller //: AdminController
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

            var pet = this.petService.Details(petId , userId);

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
                BirthDate = DateTime.UtcNow,
                Image = pet.Image,
                IsForAdoption = pet.IsForAdoption
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
