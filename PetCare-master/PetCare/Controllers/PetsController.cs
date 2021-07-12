namespace PetCare.Controllers
{
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Data;
    using PetCare.Data.Models.Pet;
    using PetCare.Models.Pets;

    public class PetsController : Controller
    {
        private readonly PetCareDbContext data;

        public PetsController(PetCareDbContext data)
            => this.data = data;

        public IActionResult Add() 
            => View(new AddPetFormModel 
            {
                AnimalTypes = this.GetAnimalTypes()            
            });

        [HttpPost]
        public IActionResult Add(AddPetFormModel pet)
        {
            if (!this.data.Animals.Any(c => c.Id == pet.AnimalId))
            {
                this.ModelState.AddModelError(nameof(pet.AnimalId), "Plese select some of the options.");
            }

            if (pet.AnimalId == 1)
            {
                this.ModelState.AddModelError(nameof(pet.AnimalId), "Plese select some of the options , N/A is not valid.");
            }

            if (!ModelState.IsValid)
            {
                pet.AnimalTypes = this.GetAnimalTypes();
                
                return View(pet);
            }

            var addPet = new Pet
            {
                Name = pet.Name,
                Age = pet.Age,
                Breed = pet.Breed,
                AnimalId = pet.AnimalId,
                Description = pet.Description,
                BirthDate = pet.BirthDate

            };

            this.data.Pets.Add(addPet);

            this.data.SaveChanges();

            return RedirectToAction("Details", "Pets"); 
        }

        public IEnumerable<AnimalTypeViewModel> GetAnimalTypes()
                => this.data
                    .Animals
                    .Select(a => new AnimalTypeViewModel
                    {
                        Id = a.Id,
                        Type = a.Type
                    })
                    .ToList();

        public IActionResult Details() 
        {
            var pet = this.data.Pets
                .Select(p => new DetailsPetFormModel
                {
                    Name = p.Name,
                    Age = p.Age,
                    Breed = p.Breed,
                    Description = p.Description,
                    AnimalType = p.AnimalType.Type
                })
                .ToList();

            return View(pet);
        }

    }
}
