namespace PetCare.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Data;
    using PetCare.Data.Models.VetService;
    using PetCare.Models.VetServices;

    public class VetServicesController : Controller
    {
        private readonly PetCareDbContext data;

        public VetServicesController(PetCareDbContext data)
           => this.data = data;


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
            var service = new VetService
            {
                Description = vetService.Description,
                ImgUrl = vetService.ImgUrl,
                ServiceName = vetService.ServiceName
            };

            this.data.VetServices.Add(service);

            this.data.SaveChanges();

            return RedirectToAction("All", "VetServices");
        }


        public IActionResult All() 
        {
            var pet = this.data.VetServices
                .Select(vs => new AllVetServicesFormModel
                {
                    Id = vs.Id,
                    Description = vs.Description,
                    ServiceName = vs.ServiceName,
                    ImgUrl = vs.ImgUrl
                })
                .OrderByDescending(vs => vs.Id)
                .ToList();

            return View(pet);
        }

        public IActionResult Details(int vetServiceId)
        {
            if (!this.data.VetServices.Any(vs => vs.Id == vetServiceId))
            {
                return Redirect("/VetServices/All");
            }

            var vetService = this.data
                 .VetServices
                 .Where(vs => vs.Id == vetServiceId)
                 .Select(vs => new DetailsVetServiceViewModel
                 {
                     Id = vetServiceId,
                     Description = vs.Description,
                     ImgUrl = vs.ImgUrl,
                     ServiceName = vs.ServiceName

                 })
                 .FirstOrDefault();

            return View(vetService);
        }
    }
}
