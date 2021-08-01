namespace PetCare.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Services.Employee;

    public class EmployeesController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
           => this.employeeService = employeeService;

       
        public IActionResult Team()
        {
            var employees = this.employeeService.All();

            return View(employees);
        }

        public IActionResult Details(string employeeId)
        {
            if (!this.employeeService.IsEmployeeExist(employeeId))
            {
                return Redirect("/Employees/Team");
            }

            var employee = this.employeeService.Details(employeeId);

            return View(employee);
        }
    }
}
