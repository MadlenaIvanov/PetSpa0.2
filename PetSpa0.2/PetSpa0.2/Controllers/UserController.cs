using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetSpa.Core.Contracts;
using PetSpa.Infrastructure.Data.Identity;

namespace PetSpa0._2.Controllers
{
    public class UserController : BaseController
    {
        private readonly RoleManager<IdentityRole> roleManager;

        private readonly UserManager<ApplicationUser> userManager;

        private readonly IUserService service;

        public UserController(
            RoleManager<IdentityRole> _roleManager,
            UserManager<ApplicationUser> _userManager,
            IUserService _service)
        {
            roleManager = _roleManager;
            userManager = _userManager;
            service = _service;
        }

        public async Task<IActionResult> ManageUsers()
        {
            var users = await service.GetUsers();

            return View(users);
        } 

        public IActionResult Index()
        {
            return View();
        }
    }
}
