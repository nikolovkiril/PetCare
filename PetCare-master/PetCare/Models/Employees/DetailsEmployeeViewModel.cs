namespace PetCare.Models.Employees
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    public class DetailsEmployeeViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public byte Age { get; set; }
        public string Position { get; set; }
        public string HireDate { get; init; }
        public string Image { get; set; }
        public string Autobiography { get; set; }
    }
}
