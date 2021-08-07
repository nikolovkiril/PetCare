namespace PetCare.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Infrastructure;
    using PetCare.Services.Adoption;

    public class AdoptionsController : Controller
    {
        private readonly IAdoptionService adoptionService;

        public AdoptionsController(IAdoptionService adoptionService) 
            => this.adoptionService = adoptionService;

        public IActionResult All()
        {
            var pet = this.adoptionService.All();

            return View(pet);
        }

        public IActionResult Details(string petId)
        {
            var userId = this.User.GetId();

            var pet = this.adoptionService.Details(petId , userId);

            return View(pet);
        }

        public IActionResult Adopt(string petId)
        {
            var userId = this.User.GetId();

            var pet = this.adoptionService.Edit(petId, userId);

            return RedirectToAction("All","/Pets");
        }
    }
}
