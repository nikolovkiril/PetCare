namespace PetCare.Test.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;
    using PetCare.Test.Data;
    using PetCare.Services.Pet.Models;

    public class AdoptionsControllerTest
    {
        [Fact]
        public void GetAllShouldReturnCorrectView()
          => MyController<AdoptionsController>
              .Instance()
              .Calling(c => c.All())
              .ShouldReturn()
              .View();

        [Fact]
        public void GetDetailsShouldReturnCorrectView()
            => MyController<AdoptionsController>
                 .Instance(controller => controller
                    .WithUser()
                    .WithData(PetTestData.CreatePet()))
                 .Calling(c => c.Details(PetTestData.PetId()))
                 .ShouldReturn()
                 .View(view => view
                       .WithModelOfType<PetDetailsServiceModel>());

    }
}
