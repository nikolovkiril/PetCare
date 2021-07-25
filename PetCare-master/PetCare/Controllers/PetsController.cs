namespace PetCare.Controllers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Data;
    using PetCare.Data.Models.Pet;
    using PetCare.Models.Pets;
    using Microsoft.AspNetCore.Authorization;
    using PetCare.Infrastructure;

    [Authorize]
    public class PetsController : Controller
    {
        private readonly PetCareDbContext data;

        public PetsController(PetCareDbContext data)
            => this.data = data;

        public IActionResult Add()
        {
            return View(new AddPetFormModel
            {
                AnimalTypes = this.GetAnimalTypes(),
                GengerTypes = this.GetGender()
            });

        }
        [HttpPost]
        public IActionResult Add(AddPetFormModel pet)
        {
            if (!this.data.Owners.Any(o => o.UserId == this.User.GetId()))
            {
                var owner = new Owner
                {
                    UserId = this.User.GetId()
                };
                this.data.Owners.Add(owner);
                this.data.SaveChanges();
            }

            if (!this.data.Animals.Any(a => a.Id == pet.AnimalId))
            {
                this.ModelState.AddModelError(nameof(pet.AnimalId), "Plese select some of the options.");
            }

            if (!this.data.Genders.Any(a => a.Id == pet.GenderId))
            {
                this.ModelState.AddModelError(nameof(pet.GenderId), "Plese select some of the options.");
            }

            if (!ModelState.IsValid)
            {
                pet.AnimalTypes = this.GetAnimalTypes();
                pet.GengerTypes = this.GetGender();

                return View(pet);
            }
            var ownerId = this.data
                .Owners
                .Where(u => u.UserId == this.User.GetId())
                .Select(u => u.Id)
                .FirstOrDefault();

            var addPet = new Pet
            {
                Name = pet.Name,
                Breed = pet.Breed,
                GenderId = pet.GenderId,
                AnimalId = pet.AnimalId,
                Description = pet.Description,
                BirthDate = pet.BirthDate,
                Image = pet.Image,
                OwnerId = ownerId
            };

            this.data.Pets.Add(addPet);

            this.data.SaveChanges();

            return RedirectToAction(nameof(All));
        }


        public IActionResult All()
        {
            var pet = this.data.Pets
                .Where(u => u.Owner.UserId == this.User.GetId())
                .Select(p => new DetailsPetFormModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Breed = p.Breed,
                    GenderType = p.GenderType.GenderType,
                    Description = p.Description,
                    AnimalType = p.AnimalType.Type,
                    Image = p.Image
                })
                .ToList();

            return View(pet);
        }
        public IActionResult Details(string petId)
        {
            if (!this.data.Pets.Any(t => t.Id == petId))
            {
                return Redirect("/Pets/All");
            }

            var petToDisplay = this.data
                .Pets.FirstOrDefault(p => p.Id == petId);

            var date = DateTime.UtcNow.Year;
            var petAge = date - petToDisplay.BirthDate.Year;


            var pet = this.data
                 .Pets
                 .Where(p => p.Id == petId)
                 .Select(p => new DetailsPetFormModel
                 {
                     Id = petId,
                     Name = p.Name,
                     Breed = p.Breed,
                     Age = (byte)petAge,
                     GenderType = p.GenderType.GenderType,
                     Description = p.Description,
                     Image = p.Image,
                     AnimalType = p.AnimalType.Type,
                 })
                 .FirstOrDefault();

            return View(pet);
        }

        public bool UserIsOwner()
            => this.data.Owners.Any(x => x.UserId == this.User.GetId());

        public IEnumerable<AnimalTypeViewModel> GetAnimalTypes()
             => this.data
                 .Animals
                 .Select(a => new AnimalTypeViewModel
                 {
                     Id = a.Id,
                     Type = a.Type
                 })
                 .ToList();

        public IEnumerable<GenderTypeViewModel> GetGender()
             => this.data
                 .Genders
                 .Select(a => new GenderTypeViewModel
                 {
                     Id = a.Id,
                     Type = a.GenderType
                 })
                 .ToList();
    }
}
