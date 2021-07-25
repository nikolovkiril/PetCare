namespace PetCare.Data.Models.Employee
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Position
    {
        public int Id { get; init; }

        [Required]
        public string EmployeePosition { get; set; }
        public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
    }
}
