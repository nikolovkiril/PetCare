namespace PetCare.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using PetCare.Data;
    using PetCare.Models.Employees;
    using PetCare.Data.Models.Employee;

    public class EmployeesController : Controller
    {
        private readonly PetCareDbContext data;

        public EmployeesController(PetCareDbContext data)
           => this.data = data;

        public IActionResult Add()
             => View(new AddEmployeeFormModel
             {
                 EmployeePosition = this.GetEmployeeTypes()
             });

        [HttpPost]
        public IActionResult Add(AddEmployeeFormModel employee)
        {
            if (!this.data.Positions.Any(p => p.Id == employee.PositionId))
            {
                this.ModelState.AddModelError(nameof(employee.PositionId), "Plese select some of the options.");
            }

            if (!ModelState.IsValid)
            {
                employee.EmployeePosition = this.GetEmployeeTypes();

                return View(employee);
            }

            var addEmployee = new Employee
            {
                FirstName = employee.FirstName,
                LastName  = employee.LastName,
                Age = employee.Age,
                HireDate = DateTime.UtcNow,
                PositionId = employee.PositionId,
            };

            this.data.Employees.Add(addEmployee);

            this.data.SaveChanges();

            return RedirectToAction("Team", "Employees");
        }

        public IEnumerable<PositionViewModel> GetEmployeeTypes()
                => this.data
                    .Positions
                    .Select(e => new PositionViewModel
                    {
                       Id = e.Id,
                       EmployeePosition = e.EmployeePosition
                    })
                    .ToList();
        public IActionResult Team()
        {
            var employees = this.data
                .Employees
                .Select(e => new DetailsEmployeeViewModel
                {
                    FirstName = e.FirstName,
                    LasttName = e.LastName,
                    Age = e.Age,
                    Position = e.Position.EmployeePosition,
                    HireDate = e.HireDate
                })
                .ToList();

            return View(employees);
        }
    }
}
