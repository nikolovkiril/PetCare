namespace PetCare.Infrastructure
{
    using System.Security.Claims;

    using static PetCare.Areas.Admin.AdminConstans;

    public static class ClaimsPrincipalExtensions
    {
        public static string GetId(this ClaimsPrincipal user)
            => user.FindFirstValue(ClaimTypes.NameIdentifier);

        public static bool IsAdmin(this ClaimsPrincipal user)
            => user.IsInRole(AdministartorRoleName);
    }
}
