namespace PetCare.Models.Employees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DetailsEmployeeViewModel
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public byte Age { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; init; }
    }
}
