namespace PetCare.Data.Models.Employe
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
        public string EmployePosition { get; set; }
        public IEnumerable<Employe> Employes { get; set; } = new List<Employe>();
    }
}
