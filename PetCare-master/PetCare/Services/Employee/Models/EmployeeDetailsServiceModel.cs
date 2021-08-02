namespace PetCare.Services.Employee.Models
{
    public class EmployeeDetailsServiceModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public byte Age { get; set; }
        public string HireDate { get; set; }
        public int PositionId { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public string Autobiography { get; set; }
    }
}
