namespace PetCare.Services.Employee
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using PetCare.Data;
    using PetCare.Data.Models.Employee;
    using PetCare.Services.Employee.Models;

    public class EmployeeService : IEmployeeService
    {
        private readonly PetCareDbContext data;
        private readonly IMapper mapper;

        public EmployeeService(
            PetCareDbContext data, 
            IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }


        public void CreateEmployee(
            string firstName, 
            string lastName, 
            byte age,
            DateTime hireDate, 
            int positionId, 
            string autobiography, 
            string imageUrl)
        {
            var addEmployee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                HireDate = DateTime.UtcNow,
                PositionId = positionId,
                Image = imageUrl,
                Autobiography = autobiography
            };

            this.data.Employees.Add(addEmployee);

            this.data.SaveChanges();
        }

        public IEnumerable<PositionTypeServiceModel> GetEmployeeTypes()
            => this.data
                    .Positions
                    .ProjectTo<PositionTypeServiceModel>(this.mapper.ConfigurationProvider)
                    .ToList();

        public bool IsPositionExist(int positionId)
            => this.data
            .Positions
            .Any(p => p.Id == positionId);


        public IEnumerable<EmployeeDetailsServiceModel> All()
            => this.data
                .Employees
                .Select(e => new EmployeeDetailsServiceModel
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LasttName = e.LastName,
                    Age = e.Age,
                    Position = e.Position.EmployeePosition,
                    Image = e.Image,
                })
                .OrderByDescending(p => p.Position.StartsWith("D"))
                .ThenByDescending(n => n.Position.StartsWith("N"))
                .ThenBy(e => e.FirstName)
                .ToList();


        public EmployeeDetailsServiceModel Details(string employeeId)
            => this.data
                 .Employees
                 .Where(e => e.Id == employeeId)
                 .Select(e => new EmployeeDetailsServiceModel
                 {
                     Id = employeeId,
                     FirstName = e.FirstName,
                     LasttName = e.LastName,
                     HireDate = e.HireDate.ToString("d"),
                     Age = e.Age,
                     Image = e.Image,
                     Position = e.Position.EmployeePosition,
                     PositionId = e.Position.Id,
                     Autobiography = e.Autobiography
                 })
                 .FirstOrDefault();

        public bool IsEmployeeExist(string employeeId)
            => this.data
            .Employees
            .Any(t => t.Id == employeeId);

        public bool Edit(
            string employeeId,
            string firstName,
            string lastName,
            int positionId,
            byte age,
            string autobiography,
            string imageUrl)
        {
            var employeeToEdit = this.data.Employees.Find(employeeId);

            if (employeeToEdit == null)
            {
                return false;
            }

            employeeToEdit.FirstName = firstName;
            employeeToEdit.LastName = lastName;
            employeeToEdit.PositionId = positionId;
            employeeToEdit.Age = age;
            employeeToEdit.Autobiography = autobiography;
            employeeToEdit.Image = imageUrl;

            this.data.SaveChanges();

            return true;
        }
    }
}
