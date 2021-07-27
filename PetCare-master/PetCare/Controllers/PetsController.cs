namespace PetCare.Controllers
{
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Models.Pets;
    using Microsoft.AspNetCore.Authorization;
    using PetCare.Infrastructure;
    using PetCare.Services.Pets;

    [Authorize]
    public class PetsController : Controller
    {
        private readonly IPetService petService;

        public PetsController(IPetService petService)
        {
            this.petService = petService;
        }

        public IActionResult Add()
        {
            return View(new AddPetFormModel
            {
                AnimalTypes = this.petService.GetAnimalTypes(),
                GengerTypes = this.petService.GetGender()
            });

        }
        [HttpPost]
        public IActionResult Add(AddPetFormModel pet)
        {
            var userId = this.User.GetId();

            if (!this.petService.IsOwnerExist(userId))
            {
                this.petService.AddOwner(userId);
            }

            if (!this.petService.IsAnimalExist(pet.AnimalId))
            {
                this.ModelState.AddModelError(nameof(pet.AnimalId), "Plese select some of the options.");
            }

            var exist = this.petService.IsGenderExist(pet.GenderId);
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
            var ownerId = this.petService.GetOwnerId(userId);

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
           
            var pet = this.petService.All(userId);

            return View(pet);
        }

        public IActionResult Details(string petId)
        {
            var userId = this.User.GetId();

            if (!this.petService.IsUserOwner(userId , petId))
            {
                return RedirectToAction(nameof(All));
            }

            var pet = this.petService.Details(petId);

            return View(pet);
        }
    }
}
