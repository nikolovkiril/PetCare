namespace PetCare.Data.Models.User
{
    using Microsoft.AspNetCore.Identity;


    using static PetCare.Models.DataConstants.User;

    public class User : IdentityUser 
    {
        public string NickName { get; set; }
    }
}
