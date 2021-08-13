namespace PetCare.Test.Routing
{
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;
    using Xunit;

    public class EmployeesRouteTest
    {
        [Fact]
        public void GetAllShouldBeRoutedCorrectly()
            => MyRouting
                .Configuration()
                .ShouldMap("/Employees/Team")
                .To<EmployeesController>(c => c.Team());

        [Fact]
        public void GetDetailsShouldBeRoutedCorrectly()
           => MyRouting
               .Configuration()
               .ShouldMap("/Employees/Details")
               .To<EmployeesController>(c => c.Details(null));

    }
}
