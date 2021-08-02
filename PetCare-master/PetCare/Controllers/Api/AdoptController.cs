namespace PetCare.Controllers.Api
{
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Services.Pet;

    [ApiController]
    [Route("api/[controller]")]
    public class AdoptController : ControllerBase
    {

        private readonly IPetService petService;

        public AdoptController(IPetService petService) 
            => this.petService = petService;


        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
