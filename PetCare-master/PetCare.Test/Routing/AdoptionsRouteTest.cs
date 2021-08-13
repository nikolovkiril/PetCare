namespace PetCare.Test.Routing
{
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;
    using Xunit;

    public class AdoptionsRouteTest
    {
        [Fact]
        public void GetAllShouldBeRoutedCorrectly()
            => MyRouting
                .Configuration()
                .ShouldMap("/Adoptions/All")
                .To<AdoptionsController>(c => c.All());

        [Fact]
        public void GetDetailsShouldBeRoutedCorrectly()
           => MyRouting
               .Configuration()
               .ShouldMap("/Adoptions/Details")
               .To<AdoptionsController>(c => c.Details(null));

        [Fact]
        public void GetAdoptShouldBeRoutedCorrectly()
           => MyRouting
               .Configuration()
               .ShouldMap("/Adoptions/Adopt")
               .To<AdoptionsController>(c => c.Adopt(null));
    }
}
