namespace PetCare.Test.Routing
{
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;
    using Xunit;

    public class VetServicesRouteTest
    {
        [Fact]
        public void GetAllShouldBeRoutedCorrectly()
          => MyRouting
              .Configuration()
              .ShouldMap("/VetServices/All")
              .To<VetServicesController>(c => c.All());

    }
}
