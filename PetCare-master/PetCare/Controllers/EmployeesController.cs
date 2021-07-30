namespace PetCare.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using PetCare.Models.Employees;
    using PetCare.Services.Employees;

    public class EmployeesController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
           => this.employeeService = employeeService;

        [Authorize(Roles = "Administrator")]

        public IActionResult Add()
             => View(new EmployeeFormModel
             {
                 EmployeePosition = this.employeeService.GetEmployeeTypes()
             });


        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult Add(EmployeeFormModel employee)
        {
            if (!this.employeeService.IsPositionExist(employee.PositionId))
            {
                this.ModelState.AddModelError(nameof(employee.PositionId), "Plese select some of the options.");
            }

            if (!ModelState.IsValid)
            {
                employee.EmployeePosition = this.employeeService.GetEmployeeTypes();

                return View(employee);
            }

            this.employeeService.CreateEmployee(
                employee.FirstName,
                employee.LastName,
                employee.Age,
                employee.HireDate,
                employee.PositionId,
                employee.Autobiography,
                employee.ImageUrl);

            return RedirectToAction("Team", "Employees");
        }

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

        public IActionResult Edit(string employeeId)
        {
            var employee = this.employeeService.Details(employeeId);

            return View(new EmployeeFormModel
            {
                FirstName = employee.FirstName,
                LastName = employee.LasttName,
                Age = employee.Age,
                PositionId = employee.PositionId,
                Autobiography = employee.Autobiography,
                EmployeePosition = this.employeeService.GetEmployeeTypes(),
                ImageUrl = employee.Image
            });

        }

        [HttpPost]
        public IActionResult Edit(string employeeId, EmployeeFormModel employee)
        {
            if (!this.employeeService.IsPositionExist(employee.PositionId))
            {
                this.ModelState.AddModelError(nameof(employee.PositionId), "Plese select some of the options.");
            }

            if (!ModelState.IsValid)
            {
                employee.EmployeePosition = this.employeeService.GetEmployeeTypes();

                return View(employee);
            }

            var employeeIsEdited = this.employeeService.Edit(
                employeeId,
                employee.FirstName,
                employee.LastName,
                employee.PositionId,
                employee.Age,
                employee.Autobiography,
                employee.ImageUrl);

            if (!employeeIsEdited)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Team));
        }
    }
}
