namespace PetCare.Test.Controllers.Admin
{

    using Xunit;
    using MyTested.AspNetCore.Mvc;
    using PetCare.Areas.Admin.Controllers;
    using PetCare.Areas.Admin;
    using PetCare.Services.Pet.Models;
    using System.Collections.Generic;
    using static PetCare.Models.DataConstants;

    public class PetsAdminControllerTest
    {
        [Fact]
        public void ControllerShouldBeInAdminArea()
           => MyController<PetsController>
               .ShouldHave()
               .Attributes(attrs => attrs
                    .SpecifyingArea(AdminConstans.AreaName)
                    .RestrictingForAuthorizedRequests(AdminConstans.AdministartorRoleName));


        [Fact]
        public void ShouldReturnViewWithAllPets()
           => MyController<PetsController>
               .Instance()
               .Calling(c => c.All())
               .ShouldReturn()
               .View(view => view
                   .WithModelOfType<IEnumerable<PetDetailsServiceModel>>());


        [Fact]
        public void EditShouldReturnViewWithEditPet()
          => MyController<PetsController>
              .Instance()
              .Calling(c => c.Details("asd adsa sd"))
              .ShouldReturn()
              .RedirectToAction("All");
    }
}
