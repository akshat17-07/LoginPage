using Microsoft.AspNetCore.Mvc;
using UiDevelopmentWeb.Models;

namespace UiDevelopmentWeb.Controllers
{
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IConfiguration _User;
        public LoginController(IConfiguration user)
        {
            _User = user;
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        [Route("registration")]
        public ViewResult Registration()
        {
            return View();
        }

        [HttpPost]
        [Route("registration")]
        public IActionResult Register(RegistrationViewModel model)
        {
            return View();
        }
    }
}
