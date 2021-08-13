namespace PetCare.Test.Routing
{
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;
    using Xunit;

    public class ClinicsRouteTest
    {
        [Fact]
        public void GetAllShouldBeRoutedCorrectly()
               => MyRouting
                   .Configuration()
                   .ShouldMap("/Clinics/All")
                   .To<ClinicsController>(c => c.All());

    }
}
