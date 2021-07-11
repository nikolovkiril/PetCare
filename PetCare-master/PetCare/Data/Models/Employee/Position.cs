namespace PetCare.Data.Models.Employee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Position
    {
        public int Id { get; init; }

        [Required]
        public string EmployeePosition { get; set; }
        public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
    }
}
