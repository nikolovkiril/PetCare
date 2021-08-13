namespace PetCare.Test.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;

    public class HomeControllerTest
    {
        [Fact]
        public void ErrorShouldReturnCorrectView()
            => MyController<HomeController>
                .Instance()
                .Calling(c => c.Error())
                .ShouldReturn()
                .View();

        [Fact]
        public void IndexPageShouldReturnCorrectView()
           => MyController<HomeController>
               .Instance()
               .Calling(c => c.Index())
               .ShouldReturn()
               .View();
    }
}
