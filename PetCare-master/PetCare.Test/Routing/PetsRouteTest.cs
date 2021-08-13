namespace PetCare.Test.Routing
{
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;
    using Xunit;

    public class PetsRouteTest
    {
        [Fact]
        public void GetAllShouldBeRoutedCorrectly()
           => MyRouting
               .Configuration()
               .ShouldMap("/Pets/All")
               .To<PetsController>(c => c.All());

        [Fact]
        public void GetAddShouldBeRoutedCorrectly()
           => MyRouting
               .Configuration()
               .ShouldMap("/Pets/Add")
               .To<PetsController>(c => c.Add());

        [Fact]
        public void GetDetailsShouldBeRoutedCorrectly()
          => MyRouting
              .Configuration()
              .ShouldMap("/Pets/Details")
              .To<PetsController>(c => c.Details(null));

        [Fact]
        public void GetEditShouldBeRoutedCorrectly()
           => MyRouting
               .Configuration()
               .ShouldMap("/Pets/Edit")
               .To<PetsController>(c => c.Edit(null));

        [Fact]
        public void GetDeleteShouldBeRoutedCorrectly()
          => MyRouting
              .Configuration()
              .ShouldMap("/Pets/Delete")
              .To<PetsController>(c => c.Delete(null));
    }

}
