namespace PetCare.Controllers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using PetCare.Data;
    using PetCare.Models.Employees;
    using PetCare.Data.Models.Employee;

    public class EmployeesController : Controller
    {
        private readonly PetCareDbContext data;

        public EmployeesController(PetCareDbContext data)
           => this.data = data;

        [Authorize]

        public IActionResult Add()
             => View(new AddEmployeeFormModel
             {
                 EmployeePosition = this.GetEmployeeTypes()
             });


        [HttpPost]
        [Authorize]
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
                LastName = employee.LastName,
                Age = employee.Age,
                HireDate = DateTime.UtcNow,
                PositionId = employee.PositionId,
                Image = employee.ImageUrl,
                Autobiography = employee.Autobiography
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
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LasttName = e.LastName,
                    Age = e.Age,
                    Position = e.Position.EmployeePosition,
                    HireDate = e.HireDate.ToString("dd MMMM yy"),
                    Image = e.Image,
                })
                .OrderByDescending(p => p.Position.StartsWith("D"))
                .ThenByDescending(n => n.Position.StartsWith("N"))
                .ThenBy(e => e.FirstName)
                .ToList();

            return View(employees);
        }

        public IActionResult Details(string employeeId)
        {
            if (!this.data.Employees.Any(t => t.Id == employeeId))
            {
                return Redirect("/Employees/Team");
            }

            var employee = this.data
                 .Employees
                 .Where(e => e.Id == employeeId)
                 .Select(e => new DetailsEmployeeViewModel
                 {
                     Id = employeeId,
                     FirstName = e.FirstName,
                     LasttName = e.LastName,
                     Age = e.Age,
                     HireDate = e.HireDate.ToString("dd MMMM yy"),
                     Image = e.Image,
                     Position = e.Position.EmployeePosition,
                     Autobiography = e.Autobiography
                 })
                 .FirstOrDefault();

            return View(employee);
        }
    }
}
