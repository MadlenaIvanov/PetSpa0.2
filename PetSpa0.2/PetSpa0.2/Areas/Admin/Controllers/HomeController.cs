using Microsoft.AspNetCore.Mvc;

namespace PetSpa0._2.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
