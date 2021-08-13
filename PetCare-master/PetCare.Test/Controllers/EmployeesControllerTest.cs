namespace PetCare.Test.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;
    using PetCare.Controllers;

    public class EmployeesControllerTest
    {
        [Fact]
        public void AllShouldReturnCorrectView()
         => MyController<EmployeesController>
             .Instance()
             .Calling(c => c.Team())
             .ShouldReturn()
             .View();
    }
}
