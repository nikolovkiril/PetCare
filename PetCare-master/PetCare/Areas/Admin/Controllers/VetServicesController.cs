namespace PetCare.Areas.Admin.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Data;
    using PetCare.Data.Models.VetService;
    using PetCare.Models.VetServices;
    using PetCare.Services.VetService;

    public class VetServicesController : AdminController
    {
        private readonly IVetServiceService vetService;

        public VetServicesController(IVetServiceService vetService) 
            => this.vetService = vetService;

        [Authorize(Roles = "Administrator")]
        public IActionResult Add() 
            => View();


        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult Add(AddVetService vetService) 
        {
            if (!ModelState.IsValid)
            {
                return View(vetService);
            }

            this.vetService.NewVetService(
                vetService.Description , 
                vetService.ImgUrl,
                vetService.ServiceName);

            return RedirectToAction("All", "VetServices");
        }


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
