namespace PetCare.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Models.Clinics;
    using PetCare.Services.Clinic;

    public class ClinicsController : Controller
    {
        private readonly IClinicService clinicService;

        public ClinicsController(IClinicService clinicService)
           => this.clinicService = clinicService;

        public IActionResult All()
        {
            var clinic = this.clinicService.All();

            return View(clinic);
        }

    }
}
