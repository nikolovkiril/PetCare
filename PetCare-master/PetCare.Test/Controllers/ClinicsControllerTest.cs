namespace PetCare.Test.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;

    public class ClinicsControllerTest
    {
        [Fact]
        public void AllShouldReturnCorrectView()
         => MyController<ClinicsController>
             .Instance()
             .Calling(c => c.All())
             .ShouldReturn()
             .View();
    }
}
