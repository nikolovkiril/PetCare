namespace PetCare.Services.Employee
{
    using System;
    using System.Collections.Generic;
    using PetCare.Services.Employee.Models;

    public interface IEmployeeService
    {
        bool IsPositionExist(int positionId);

        IEnumerable<PositionTypeServiceModel> GetEmployeeTypes();

        void CreateEmployee(
            string firstName,
            string lastName,
            byte age,
            DateTime hireDate,
            int positionId,
            string autobiography,
            string imageUrl);

        bool Edit(
            string employeeId,
            string firstName,
            string lastName,
            int positionId,
            byte Age,
            string autobiography,
            string imageUrl);

        IEnumerable<EmployeeDetailsServiceModel> All();

        EmployeeDetailsServiceModel Details(string employeeId);

        bool IsEmployeeExist(string employeeId);
    }
}
