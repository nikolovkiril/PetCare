namespace PetCare.Data.Models.ApplicationUser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ApplicationUser
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Nickname { get; set; }

        
    }
}
