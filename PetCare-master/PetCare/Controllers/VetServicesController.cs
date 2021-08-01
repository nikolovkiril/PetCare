namespace PetCare.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Services.VetService;

    public class VetServicesController : Controller
    {
        private readonly IVetServiceService vetService;

        public VetServicesController(IVetServiceService vetService)
            => this.vetService = vetService;


        public IActionResult All()
        {
            var pet = this.vetService.VetServiceAll();

            return View(pet);
        }
        public IActionResult Details(int vetServiceId)
        {
            if (!this.vetService.VetServiceAny(vetServiceId))
            {
                return Redirect("/VetServices/All");
            }

            var vetService = this.vetService.Details(vetServiceId);

            return View(vetService);
        }
    }
}
