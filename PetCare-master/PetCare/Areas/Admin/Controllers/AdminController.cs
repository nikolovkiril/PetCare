namespace PetCare.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static AdminConstans;

    [Area(AdminConstans.AreaName)]
    [Authorize(Roles = AdministartorRoleName)]

    public abstract class AdminController : Controller
    { 

    }
}
