namespace PetCare.Test.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;

    public class VetServicesRouteTest
    {
        [Fact]
        public void AllShouldReturnCorrectView()
          => MyController<VetServicesController>
              .Instance()
              .Calling(c => c.All())
              .ShouldReturn()
              .View();
    }
}
