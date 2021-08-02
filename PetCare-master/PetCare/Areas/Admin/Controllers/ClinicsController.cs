namespace PetCare.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Models.Clinics;
    using PetCare.Services.Clinic;
    using System;

    public class ClinicsController : AdminController
    {
        private readonly IClinicService clinicService;

        public ClinicsController(IClinicService clinicService)
           => this.clinicService = clinicService;


        public IActionResult Add()
            => View(new ClinicFormModel
            {
                CityNames = this.clinicService.GetCityNames()
            });


        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult Add(ClinicFormModel clinic)
        {
            if (!this.clinicService.IsCityExist(clinic.CityId))
            {
                this.ModelState.AddModelError(nameof(clinic.CityId), "Plese select some of the options.");
            }

            if (!ModelState.IsValid)
            {
                clinic.CityNames = this.clinicService.GetCityNames();

                return View(clinic);
            }
            this.clinicService.CreateClinic(
                clinic.Name,
                clinic.Street,
                clinic.CityId,
                clinic.PhoneNumber);

            return RedirectToAction("All", "Clinics");
        }

        public IActionResult All()
        {
            var clinic = this.clinicService.All();

            return View(clinic);
        }

        public IActionResult Details()
        {
            return null;
        }
    }
}
