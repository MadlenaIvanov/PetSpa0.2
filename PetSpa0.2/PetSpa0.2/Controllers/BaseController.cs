using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PetSpa0._2.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
